namespace GEN_MD5
{
    partial class Form1
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
            this.btn_md5 = new System.Windows.Forms.Button();
            this.tb_src = new System.Windows.Forms.TextBox();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.tb_des2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_md5
            // 
            this.btn_md5.Location = new System.Drawing.Point(13, 66);
            this.btn_md5.Name = "btn_md5";
            this.btn_md5.Size = new System.Drawing.Size(75, 23);
            this.btn_md5.TabIndex = 0;
            this.btn_md5.Text = "gen md5";
            this.btn_md5.UseVisualStyleBackColor = true;
            this.btn_md5.Click += new System.EventHandler(this.btn_md5_Click);
            // 
            // tb_src
            // 
            this.tb_src.Location = new System.Drawing.Point(13, 13);
            this.tb_src.Multiline = true;
            this.tb_src.Name = "tb_src";
            this.tb_src.Size = new System.Drawing.Size(362, 47);
            this.tb_src.TabIndex = 1;
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(13, 95);
            this.tb_des.Multiline = true;
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(362, 47);
            this.tb_des.TabIndex = 2;
            // 
            // tb_des2
            // 
            this.tb_des2.Location = new System.Drawing.Point(12, 150);
            this.tb_des2.Multiline = true;
            this.tb_des2.Name = "tb_des2";
            this.tb_des2.Size = new System.Drawing.Size(362, 47);
            this.tb_des2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 209);
            this.Controls.Add(this.tb_des2);
            this.Controls.Add(this.tb_des);
            this.Controls.Add(this.tb_src);
            this.Controls.Add(this.btn_md5);
            this.Name = "Form1";
            this.Text = "MD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_md5;
        private System.Windows.Forms.TextBox tb_src;
        private System.Windows.Forms.TextBox tb_des;
        private System.Windows.Forms.TextBox tb_des2;
    }
}

