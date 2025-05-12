namespace foy5
{
    partial class BolumEkle
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
            this.FakulteSeccomboBox = new System.Windows.Forms.ComboBox();
            this.BolumEkletextBox = new System.Windows.Forms.TextBox();
            this.FakulteSeclabel = new System.Windows.Forms.Label();
            this.BolumEklelabel = new System.Windows.Forms.Label();
            this.BolumEklebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FakulteSeccomboBox
            // 
            this.FakulteSeccomboBox.FormattingEnabled = true;
            this.FakulteSeccomboBox.Location = new System.Drawing.Point(92, 173);
            this.FakulteSeccomboBox.Name = "FakulteSeccomboBox";
            this.FakulteSeccomboBox.Size = new System.Drawing.Size(121, 21);
            this.FakulteSeccomboBox.TabIndex = 0;
            this.FakulteSeccomboBox.SelectedIndexChanged += new System.EventHandler(this.FakulteSeccomboBox_SelectedIndexChanged);
            // 
            // BolumEkletextBox
            // 
            this.BolumEkletextBox.Location = new System.Drawing.Point(92, 213);
            this.BolumEkletextBox.Name = "BolumEkletextBox";
            this.BolumEkletextBox.Size = new System.Drawing.Size(121, 20);
            this.BolumEkletextBox.TabIndex = 1;
            this.BolumEkletextBox.TextChanged += new System.EventHandler(this.BolumEkletextBox_TextChanged);
            // 
            // FakulteSeclabel
            // 
            this.FakulteSeclabel.AutoSize = true;
            this.FakulteSeclabel.Location = new System.Drawing.Point(89, 157);
            this.FakulteSeclabel.Name = "FakulteSeclabel";
            this.FakulteSeclabel.Size = new System.Drawing.Size(42, 13);
            this.FakulteSeclabel.TabIndex = 2;
            this.FakulteSeclabel.Text = "Fakülte";
            // 
            // BolumEklelabel
            // 
            this.BolumEklelabel.AutoSize = true;
            this.BolumEklelabel.Location = new System.Drawing.Point(89, 197);
            this.BolumEklelabel.Name = "BolumEklelabel";
            this.BolumEklelabel.Size = new System.Drawing.Size(36, 13);
            this.BolumEklelabel.TabIndex = 3;
            this.BolumEklelabel.Text = "Bölüm";
            // 
            // BolumEklebutton
            // 
            this.BolumEklebutton.Location = new System.Drawing.Point(167, 239);
            this.BolumEklebutton.Name = "BolumEklebutton";
            this.BolumEklebutton.Size = new System.Drawing.Size(46, 23);
            this.BolumEklebutton.TabIndex = 4;
            this.BolumEklebutton.Text = "Ekle";
            this.BolumEklebutton.UseVisualStyleBackColor = true;
            this.BolumEklebutton.Click += new System.EventHandler(this.BolumEklebutton_Click);
            // 
            // BolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.BolumEklebutton);
            this.Controls.Add(this.BolumEklelabel);
            this.Controls.Add(this.FakulteSeclabel);
            this.Controls.Add(this.BolumEkletextBox);
            this.Controls.Add(this.FakulteSeccomboBox);
            this.Name = "BolumEkle";
            this.Text = "BolumEkle";
            this.Load += new System.EventHandler(this.BolumEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FakulteSeccomboBox;
        private System.Windows.Forms.TextBox BolumEkletextBox;
        private System.Windows.Forms.Label FakulteSeclabel;
        private System.Windows.Forms.Label BolumEklelabel;
        private System.Windows.Forms.Button BolumEklebutton;
    }
}