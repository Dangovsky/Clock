using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clock.Unit;

namespace Clock
{
    public partial class clock: UserControl
    {
        private ClockLogic logic;

        public clock()
        {
            logic = new ClockLogic();
            InitializeComponent();
            logic = new ClockLogic((string)gComboBox.SelectedItem, (string)typeComboBox.SelectedItem, clockPictureBox.Image);
            GBindingSource.DataSource = logic.G;
            TypesBindingSource.DataSource = logic.Types;
        }

        private void clockPictureBox_Paint(object sender, PaintEventArgs e)
        {
            clockPictureBox.Image = logic.GetImage();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void typeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            logic.Type = (string)typeComboBox.SelectedItem;
        }

        private void gComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            logic.GCorrection = (string)gComboBox.SelectedItem;
        }
    }
}
