
namespace Project_2
{
    partial class Aform
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtano = new System.Windows.Forms.TextBox();
            this.txtreason = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btngetletter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.policyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absenceFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "Absence No.";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(141, 43);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(216, 20);
            this.txtfname.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "School Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Reason ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Full name";
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(141, 109);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(216, 20);
            this.txtano.TabIndex = 40;
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(141, 151);
            this.txtreason.Multiline = true;
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(290, 106);
            this.txtreason.TabIndex = 39;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(141, 69);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(216, 20);
            this.txtsname.TabIndex = 38;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.DimGray;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(141, 279);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(126, 53);
            this.btnsubmit.TabIndex = 46;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btngetletter
            // 
            this.btngetletter.BackColor = System.Drawing.Color.DimGray;
            this.btngetletter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetletter.Location = new System.Drawing.Point(305, 279);
            this.btngetletter.Name = "btngetletter";
            this.btngetletter.Size = new System.Drawing.Size(207, 53);
            this.btngetletter.TabIndex = 47;
            this.btngetletter.Text = "Click here to get your letter";
            this.btngetletter.UseVisualStyleBackColor = false;
            this.btngetletter.Click += new System.EventHandler(this.btngetletter_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 48;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "ABSENCE FORM";
            // 
            // Aform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btngetletter);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtreason);
            this.Controls.Add(this.txtsname);
            this.Name = "Aform";
            this.Text = "Aform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtreason;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btngetletter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem policyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absenceFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}