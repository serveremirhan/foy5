namespace foy5
{
    partial class OgrenciSorgula
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FakulteSorgulatextBox = new System.Windows.Forms.TextBox();
            this.BolumSorgulatextBox = new System.Windows.Forms.TextBox();
            this.IsımSoyısımlabel = new System.Windows.Forms.Label();
            this.FakulteSorgulalabel = new System.Windows.Forms.Label();
            this.BolumSorgulalabel = new System.Windows.Forms.Label();
            this.Sorgulabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FakulteSorgulatextBox
            // 
            this.FakulteSorgulatextBox.Location = new System.Drawing.Point(72, 205);
            this.FakulteSorgulatextBox.Name = "FakulteSorgulatextBox";
            this.FakulteSorgulatextBox.ReadOnly = true;
            this.FakulteSorgulatextBox.Size = new System.Drawing.Size(167, 20);
            this.FakulteSorgulatextBox.TabIndex = 2;
            this.FakulteSorgulatextBox.TextChanged += new System.EventHandler(this.FakulteSorgulatextBox_TextChanged);
            // 
            // BolumSorgulatextBox
            // 
            this.BolumSorgulatextBox.Location = new System.Drawing.Point(72, 245);
            this.BolumSorgulatextBox.Name = "BolumSorgulatextBox";
            this.BolumSorgulatextBox.ReadOnly = true;
            this.BolumSorgulatextBox.Size = new System.Drawing.Size(165, 20);
            this.BolumSorgulatextBox.TabIndex = 3;
            this.BolumSorgulatextBox.TextChanged += new System.EventHandler(this.BolumSorgulatextBox_TextChanged);
            // 
            // IsımSoyısımlabel
            // 
            this.IsımSoyısımlabel.AutoSize = true;
            this.IsımSoyısımlabel.Location = new System.Drawing.Point(69, 55);
            this.IsımSoyısımlabel.Name = "IsımSoyısımlabel";
            this.IsımSoyısımlabel.Size = new System.Drawing.Size(63, 13);
            this.IsımSoyısımlabel.TabIndex = 4;
            this.IsımSoyısımlabel.Text = "İsim-Soyisim";
            // 
            // FakulteSorgulalabel
            // 
            this.FakulteSorgulalabel.AutoSize = true;
            this.FakulteSorgulalabel.Location = new System.Drawing.Point(69, 189);
            this.FakulteSorgulalabel.Name = "FakulteSorgulalabel";
            this.FakulteSorgulalabel.Size = new System.Drawing.Size(42, 13);
            this.FakulteSorgulalabel.TabIndex = 6;
            this.FakulteSorgulalabel.Text = "Fakülte";
            this.FakulteSorgulalabel.Click += new System.EventHandler(this.FakulteSorgulalabel_Click);
            // 
            // BolumSorgulalabel
            // 
            this.BolumSorgulalabel.AutoSize = true;
            this.BolumSorgulalabel.Location = new System.Drawing.Point(69, 229);
            this.BolumSorgulalabel.Name = "BolumSorgulalabel";
            this.BolumSorgulalabel.Size = new System.Drawing.Size(36, 13);
            this.BolumSorgulalabel.TabIndex = 7;
            this.BolumSorgulalabel.Text = "Bölüm";
            this.BolumSorgulalabel.Click += new System.EventHandler(this.BolumSorgulalabel_Click);
            // 
            // Sorgulabutton
            // 
            this.Sorgulabutton.Location = new System.Drawing.Point(162, 108);
            this.Sorgulabutton.Name = "Sorgulabutton";
            this.Sorgulabutton.Size = new System.Drawing.Size(75, 23);
            this.Sorgulabutton.TabIndex = 8;
            this.Sorgulabutton.Text = "Sorgula";
            this.Sorgulabutton.UseVisualStyleBackColor = true;
            this.Sorgulabutton.Click += new System.EventHandler(this.Sorgulabutton_Click);
            // 
            // OgrenciSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.Sorgulabutton);
            this.Controls.Add(this.BolumSorgulalabel);
            this.Controls.Add(this.FakulteSorgulalabel);
            this.Controls.Add(this.IsımSoyısımlabel);
            this.Controls.Add(this.BolumSorgulatextBox);
            this.Controls.Add(this.FakulteSorgulatextBox);
            this.Controls.Add(this.comboBox1);
            this.Name = "OgrenciSorgula";
            this.Text = "OgrenciSorgula";
            this.Load += new System.EventHandler(this.OgrenciSorgula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox BolumSorgulatextBox;
        private System.Windows.Forms.Label IsımSoyısımlabel;
        private System.Windows.Forms.Label FakulteSorgulalabel;
        private System.Windows.Forms.Label BolumSorgulalabel;
        private System.Windows.Forms.Button Sorgulabutton;
        private System.Windows.Forms.TextBox FakulteSorgulatextBox;
    }
}