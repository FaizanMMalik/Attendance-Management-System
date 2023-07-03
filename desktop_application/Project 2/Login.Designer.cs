
namespace Project_2
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnsign = new System.Windows.Forms.Button();
            this.lblEpass = new System.Windows.Forms.Label();
            this.lblEname = new System.Windows.Forms.Label();
            this.txtEpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(359, 85);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(85, 31);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "Login";
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.Color.DimGray;
            this.btnsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsign.Location = new System.Drawing.Point(339, 312);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(126, 53);
            this.btnsign.TabIndex = 17;
            this.btnsign.Text = "Sign In";
            this.btnsign.UseVisualStyleBackColor = false;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // lblEpass
            // 
            this.lblEpass.AutoSize = true;
            this.lblEpass.BackColor = System.Drawing.Color.Transparent;
            this.lblEpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpass.ForeColor = System.Drawing.Color.Black;
            this.lblEpass.Location = new System.Drawing.Point(311, 230);
            this.lblEpass.Name = "lblEpass";
            this.lblEpass.Size = new System.Drawing.Size(114, 25);
            this.lblEpass.TabIndex = 16;
            this.lblEpass.Text = "Password";
            // 
            // lblEname
            // 
            this.lblEname.AutoSize = true;
            this.lblEname.BackColor = System.Drawing.Color.Transparent;
            this.lblEname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEname.ForeColor = System.Drawing.Color.Black;
            this.lblEname.Location = new System.Drawing.Point(307, 131);
            this.lblEname.Name = "lblEname";
            this.lblEname.Size = new System.Drawing.Size(118, 25);
            this.lblEname.TabIndex = 15;
            this.lblEname.Text = "Username";
            // 
            // txtEpass
            // 
            this.txtEpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpass.ForeColor = System.Drawing.Color.Black;
            this.txtEpass.Location = new System.Drawing.Point(312, 258);
            this.txtEpass.Name = "txtEpass";
            this.txtEpass.Size = new System.Drawing.Size(181, 31);
            this.txtEpass.TabIndex = 14;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(312, 159);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(181, 31);
            this.txtusername.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.lblEpass);
            this.Controls.Add(this.lblEname);
            this.Controls.Add(this.txtEpass);
            this.Controls.Add(this.txtusername);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.Label lblEpass;
        private System.Windows.Forms.Label lblEname;
        private System.Windows.Forms.TextBox txtEpass;
        private System.Windows.Forms.TextBox txtusername;
    }
}