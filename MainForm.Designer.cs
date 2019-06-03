namespace Project_5
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.yearLabel = new System.Windows.Forms.Label();
            this.birthMonthLabel = new System.Windows.Forms.Label();
            this.birthDayLabel = new System.Windows.Forms.Label();
            this.favoriteColorLabel1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.birthYearComboBox = new System.Windows.Forms.ComboBox();
            this.birthMonthComboBox = new System.Windows.Forms.ComboBox();
            this.favoriteColorTextBox = new System.Windows.Forms.TextBox();
            this.birthDayComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(32, 25);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(115, 14);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Enter your birth year:";
            // 
            // birthMonthLabel
            // 
            this.birthMonthLabel.AutoSize = true;
            this.birthMonthLabel.Location = new System.Drawing.Point(32, 53);
            this.birthMonthLabel.Name = "birthMonthLabel";
            this.birthMonthLabel.Size = new System.Drawing.Size(128, 14);
            this.birthMonthLabel.TabIndex = 1;
            this.birthMonthLabel.Text = "Enter your birth month:";
            // 
            // birthDayLabel
            // 
            this.birthDayLabel.AutoSize = true;
            this.birthDayLabel.Location = new System.Drawing.Point(32, 81);
            this.birthDayLabel.Name = "birthDayLabel";
            this.birthDayLabel.Size = new System.Drawing.Size(112, 14);
            this.birthDayLabel.TabIndex = 2;
            this.birthDayLabel.Text = "Enter your birth day:";
            // 
            // favoriteColorLabel1
            // 
            this.favoriteColorLabel1.AutoSize = true;
            this.favoriteColorLabel1.Location = new System.Drawing.Point(32, 109);
            this.favoriteColorLabel1.Name = "favoriteColorLabel1";
            this.favoriteColorLabel1.Size = new System.Drawing.Size(134, 14);
            this.favoriteColorLabel1.TabIndex = 3;
            this.favoriteColorLabel1.Text = "Enter your favorite color:";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.BlueViolet;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(43, 138);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(225, 45);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Get Your Lucky Number!!!";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // birthYearComboBox
            // 
            this.birthYearComboBox.FormattingEnabled = true;
            this.birthYearComboBox.Location = new System.Drawing.Point(170, 22);
            this.birthYearComboBox.Name = "birthYearComboBox";
            this.birthYearComboBox.Size = new System.Drawing.Size(112, 22);
            this.birthYearComboBox.TabIndex = 9;
            this.birthYearComboBox.SelectedIndexChanged += new System.EventHandler(this.BirthYearComboBox_SelectedIndexChanged);
            // 
            // birthMonthComboBox
            // 
            this.birthMonthComboBox.FormattingEnabled = true;
            this.birthMonthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.birthMonthComboBox.Location = new System.Drawing.Point(170, 50);
            this.birthMonthComboBox.Name = "birthMonthComboBox";
            this.birthMonthComboBox.Size = new System.Drawing.Size(112, 22);
            this.birthMonthComboBox.TabIndex = 10;
            this.birthMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.BirthMonthComboBox_SelectedIndexChanged);
            // 
            // favoriteColorTextBox
            // 
            this.favoriteColorTextBox.AcceptsReturn = true;
            this.favoriteColorTextBox.Location = new System.Drawing.Point(170, 106);
            this.favoriteColorTextBox.Name = "favoriteColorTextBox";
            this.favoriteColorTextBox.Size = new System.Drawing.Size(112, 21);
            this.favoriteColorTextBox.TabIndex = 12;
            // 
            // birthDayComboBox
            // 
            this.birthDayComboBox.FormattingEnabled = true;
            this.birthDayComboBox.Location = new System.Drawing.Point(170, 78);
            this.birthDayComboBox.Name = "birthDayComboBox";
            this.birthDayComboBox.Size = new System.Drawing.Size(112, 22);
            this.birthDayComboBox.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 196);
            this.Controls.Add(this.birthDayComboBox);
            this.Controls.Add(this.favoriteColorTextBox);
            this.Controls.Add(this.birthMonthComboBox);
            this.Controls.Add(this.birthYearComboBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.favoriteColorLabel1);
            this.Controls.Add(this.birthDayLabel);
            this.Controls.Add(this.birthMonthLabel);
            this.Controls.Add(this.yearLabel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lucky Number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label birthMonthLabel;
        private System.Windows.Forms.Label birthDayLabel;
        private System.Windows.Forms.Label favoriteColorLabel1;
        private System.Windows.Forms.ComboBox birthYearComboBox;
        private System.Windows.Forms.ComboBox birthMonthComboBox;
        private System.Windows.Forms.ComboBox birthDayComboBox;
        public System.Windows.Forms.Button calculateButton;
        public System.Windows.Forms.TextBox favoriteColorTextBox;
    }
}

