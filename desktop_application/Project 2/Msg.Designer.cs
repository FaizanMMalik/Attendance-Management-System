
namespace Project_2
{
    partial class Msg
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
            this.txtmsg = new System.Windows.Forms.RichTextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.policyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absenceFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmsg
            // 
            this.txtmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsg.Location = new System.Drawing.Point(41, 224);
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(364, 159);
            this.txtmsg.TabIndex = 24;
            this.txtmsg.Text = "";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(137, 96);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(216, 20);
            this.txtname.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Name";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(137, 122);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(216, 20);
            this.txtemail.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Message :";
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.DimGray;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(411, 330);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(126, 53);
            this.btnsubmit.TabIndex = 50;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.policyToolStripMenuItem,
            this.absenceFormToolStripMenuItem,
            this.contactsToolStripMenuItem,
            this.messageToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // policyToolStripMenuItem
            // 
            this.policyToolStripMenuItem.Name = "policyToolStripMenuItem";
            this.policyToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.policyToolStripMenuItem.Text = "Policy";
            this.policyToolStripMenuItem.Click += new System.EventHandler(this.policyToolStripMenuItem_Click);
            // 
            // absenceFormToolStripMenuItem
            // 
            this.absenceFormToolStripMenuItem.Name = "absenceFormToolStripMenuItem";
            this.absenceFormToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.absenceFormToolStripMenuItem.Text = "Absence Form";
            this.absenceFormToolStripMenuItem.Click += new System.EventHandler(this.absenceFormToolStripMenuItem_Click);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.contactsToolStripMenuItem.Text = "Contacts";
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.contactsToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 52;
            this.label3.Text = "Send Message";
            // 
            // Msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtmsg);
            this.Name = "Msg";
            this.Text = "Msg";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtmsg;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem policyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absenceFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}