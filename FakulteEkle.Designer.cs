namespace foy5
{
    partial class FakulteEkle
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
            this.FakultetextBox1 = new System.Windows.Forms.TextBox();
            this.Fakultelabel1 = new System.Windows.Forms.Label();
            this.FakulteEklebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FakultetextBox1
            // 
            this.FakultetextBox1.Location = new System.Drawing.Point(85, 188);
            this.FakultetextBox1.Name = "FakultetextBox1";
            this.FakultetextBox1.Size = new System.Drawing.Size(153, 20);
            this.FakultetextBox1.TabIndex = 0;
            this.FakultetextBox1.TextChanged += new System.EventHandler(this.FakultetextBox1_TextChanged);
            // 
            // Fakultelabel1
            // 
            this.Fakultelabel1.AutoSize = true;
            this.Fakultelabel1.Location = new System.Drawing.Point(85, 169);
            this.Fakultelabel1.Name = "Fakultelabel1";
            this.Fakultelabel1.Size = new System.Drawing.Size(42, 13);
            this.Fakultelabel1.TabIndex = 1;
            this.Fakultelabel1.Text = "Fakülte";
            // 
            // FakulteEklebutton
            // 
            this.FakulteEklebutton.Location = new System.Drawing.Point(182, 214);
            this.FakulteEklebutton.Name = "FakulteEklebutton";
            this.FakulteEklebutton.Size = new System.Drawing.Size(56, 23);
            this.FakulteEklebutton.TabIndex = 2;
            this.FakulteEklebutton.Text = "Ekle";
            this.FakulteEklebutton.UseVisualStyleBackColor = true;
            this.FakulteEklebutton.Click += new System.EventHandler(this.FakulteEklebutton_Click);
            // 
            // FakulteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.FakulteEklebutton);
            this.Controls.Add(this.Fakultelabel1);
            this.Controls.Add(this.FakultetextBox1);
            this.Name = "FakulteEkle";
            this.Text = "FakulteEkle";
            this.Load += new System.EventHandler(this.FakulteEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FakultetextBox1;
        private System.Windows.Forms.Label Fakultelabel1;
        private System.Windows.Forms.Button FakulteEklebutton;
    }
}