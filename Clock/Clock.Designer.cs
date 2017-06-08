namespace Clock
{
    partial class clock
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gComboBox = new System.Windows.Forms.ComboBox();
            this.GBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clockPictureBox = new System.Windows.Forms.PictureBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.TypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gComboBox
            // 
            this.gComboBox.DataSource = this.GBindingSource;
            this.gComboBox.FormattingEnabled = true;
            this.gComboBox.Location = new System.Drawing.Point(166, 41);
            this.gComboBox.Name = "gComboBox";
            this.gComboBox.Size = new System.Drawing.Size(121, 21);
            this.gComboBox.TabIndex = 0;
            this.gComboBox.SelectedIndexChanged += new System.EventHandler(this.gComboBox_SelectedIndexChanged);
            this.gComboBox.SelectedValueChanged += new System.EventHandler(this.gComboBox_SelectedValueChanged);
            // 
            // GBindingSource
            // 
            this.GBindingSource.DataSource = typeof(Clock.Unit.ClockLogic);
            // 
            // clockPictureBox
            // 
            this.clockPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.clockPictureBox.Location = new System.Drawing.Point(0, 0);
            this.clockPictureBox.Name = "clockPictureBox";
            this.clockPictureBox.Size = new System.Drawing.Size(163, 163);
            this.clockPictureBox.TabIndex = 1;
            this.clockPictureBox.TabStop = false;
            this.clockPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.clockPictureBox_Paint);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataSource = this.TypesBindingSource;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(166, 103);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 2;
            this.typeComboBox.SelectedValueChanged += new System.EventHandler(this.typeComboBox_SelectedValueChanged);
            // 
            // TypesBindingSource
            // 
            this.TypesBindingSource.DataSource = typeof(Clock.Unit.ClockLogic);
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(169, 16);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(15, 13);
            this.gLabel.TabIndex = 3;
            this.gLabel.Text = "G";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(169, 77);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Type";
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.clockPictureBox);
            this.Controls.Add(this.gComboBox);
            this.Name = "clock";
            this.Size = new System.Drawing.Size(290, 163);
            ((System.ComponentModel.ISupportInitialize)(this.GBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gComboBox;
        private System.Windows.Forms.PictureBox clockPictureBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.BindingSource GBindingSource;
        private System.Windows.Forms.BindingSource TypesBindingSource;
    }
}
