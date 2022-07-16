namespace EjemplosPatrones
{
    partial class PatronSingelton
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
            this.grdUsers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.etUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.etUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.etEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.etPassword = new System.Windows.Forms.TextBox();
            this.btActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdUsers
            // 
            this.grdUsers.AllowUserToAddRows = false;
            this.grdUsers.AllowUserToDeleteRows = false;
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUsers.Location = new System.Drawing.Point(0, 0);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.RowTemplate.Height = 24;
            this.grdUsers.Size = new System.Drawing.Size(600, 441);
            this.grdUsers.TabIndex = 0;
            this.grdUsers.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 441);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btActualizar);
            this.panel2.Controls.Add(this.etPassword);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.etEmail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.etUserName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.etUserId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(600, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 441);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // etUserId
            // 
            this.etUserId.Location = new System.Drawing.Point(119, 52);
            this.etUserId.Name = "etUserId";
            this.etUserId.ReadOnly = true;
            this.etUserId.Size = new System.Drawing.Size(150, 22);
            this.etUserId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName";
            // 
            // etUserName
            // 
            this.etUserName.Location = new System.Drawing.Point(119, 85);
            this.etUserName.Name = "etUserName";
            this.etUserName.Size = new System.Drawing.Size(150, 22);
            this.etUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // etEmail
            // 
            this.etEmail.Location = new System.Drawing.Point(119, 118);
            this.etEmail.Name = "etEmail";
            this.etEmail.Size = new System.Drawing.Size(150, 22);
            this.etEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // etPassword
            // 
            this.etPassword.Location = new System.Drawing.Point(119, 157);
            this.etPassword.Name = "etPassword";
            this.etPassword.Size = new System.Drawing.Size(150, 22);
            this.etPassword.TabIndex = 7;
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(119, 208);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(98, 23);
            this.btActualizar.TabIndex = 8;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // PatronSingelton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PatronSingelton";
            this.Text = "PatronSingelton";
            this.Load += new System.EventHandler(this.PatronSingelton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox etUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox etUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox etEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox etPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btActualizar;
    }
}