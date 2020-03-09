namespace PasswordStorage
{
    partial class PasswordManager
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
            this.lblServerName = new System.Windows.Forms.Label();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.lblDatabseName = new System.Windows.Forms.Label();
            this.tbDatabseName = new System.Windows.Forms.TextBox();
            this.tbSQLUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbSQLPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.dgPasswordInfo = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPasswordInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(13, 13);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(69, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name";
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(88, 10);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(310, 20);
            this.tbServerName.TabIndex = 1;
            // 
            // lblDatabseName
            // 
            this.lblDatabseName.AutoSize = true;
            this.lblDatabseName.Location = new System.Drawing.Point(404, 13);
            this.lblDatabseName.Name = "lblDatabseName";
            this.lblDatabseName.Size = new System.Drawing.Size(84, 13);
            this.lblDatabseName.TabIndex = 2;
            this.lblDatabseName.Text = "Database Name";
            // 
            // tbDatabseName
            // 
            this.tbDatabseName.Location = new System.Drawing.Point(494, 10);
            this.tbDatabseName.Name = "tbDatabseName";
            this.tbDatabseName.Size = new System.Drawing.Size(294, 20);
            this.tbDatabseName.TabIndex = 3;
            // 
            // tbSQLUsername
            // 
            this.tbSQLUsername.Location = new System.Drawing.Point(169, 42);
            this.tbSQLUsername.Name = "tbSQLUsername";
            this.tbSQLUsername.Size = new System.Drawing.Size(100, 20);
            this.tbSQLUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(13, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "SQL Authentication Username";
            // 
            // tbSQLPassword
            // 
            this.tbSQLPassword.Location = new System.Drawing.Point(431, 41);
            this.tbSQLPassword.Name = "tbSQLPassword";
            this.tbSQLPassword.Size = new System.Drawing.Size(100, 20);
            this.tbSQLPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(279, 45);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(148, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "SQL Authentication Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(552, 39);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(129, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect / Refresh";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgPasswordInfo
            // 
            this.dgPasswordInfo.AllowUserToAddRows = false;
            this.dgPasswordInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPasswordInfo.Location = new System.Drawing.Point(16, 89);
            this.dgPasswordInfo.Name = "dgPasswordInfo";
            this.dgPasswordInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPasswordInfo.Size = new System.Drawing.Size(772, 214);
            this.dgPasswordInfo.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Selected Row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(222, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New Entry";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgPasswordInfo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbSQLPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbSQLUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbDatabseName);
            this.Controls.Add(this.lblDatabseName);
            this.Controls.Add(this.tbServerName);
            this.Controls.Add(this.lblServerName);
            this.Name = "PasswordManager";
            this.Text = "Password Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgPasswordInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.Label lblDatabseName;
        private System.Windows.Forms.TextBox tbDatabseName;
        private System.Windows.Forms.TextBox tbSQLUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbSQLPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView dgPasswordInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}

