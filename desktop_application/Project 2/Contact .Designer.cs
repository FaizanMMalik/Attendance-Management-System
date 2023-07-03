
namespace Project_2
{
    partial class Contact
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsy = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.policyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absenceFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.dob,
            this.Sy,
            this.email});
            this.DGV.Location = new System.Drawing.Point(12, 96);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(472, 342);
            this.DGV.TabIndex = 24;
            // 
            // id
            // 
            this.id.HeaderText = "no.";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // dob
            // 
            this.dob.HeaderText = "D.O.B";
            this.dob.Name = "dob";
            // 
            // Sy
            // 
            this.Sy.HeaderText = "School Year";
            this.Sy.Name = "Sy";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(604, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "D.O.B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(608, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "School Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Name";
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(695, 192);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(216, 20);
            this.txtdob.TabIndex = 34;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(695, 279);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(216, 20);
            this.txtemail.TabIndex = 33;
            // 
            // txtsy
            // 
            this.txtsy.Location = new System.Drawing.Point(695, 241);
            this.txtsy.Name = "txtsy";
            this.txtsy.Size = new System.Drawing.Size(216, 20);
            this.txtsy.TabIndex = 32;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(695, 152);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(216, 20);
            this.txtname.TabIndex = 31;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DimGray;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(746, 385);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(126, 53);
            this.Add.TabIndex = 51;
            this.Add.Text = "Add ";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.DimGray;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(526, 385);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(126, 53);
            this.display.TabIndex = 52;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 53;
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
            this.label2.Location = new System.Drawing.Point(365, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "CONTACTS";
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsy);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.DGV);
            this.Name = "Contact";
            this.Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sy;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsy;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem policyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absenceFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}