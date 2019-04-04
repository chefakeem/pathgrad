namespace PathGrad
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.login = new System.Windows.Forms.Button();
            this.createAccount = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.UserLogin = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.Label();
            this.nsuLogo = new System.Windows.Forms.PictureBox();
            this.firstCreate = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.Label();
            this.trackSelect = new System.Windows.Forms.Label();
            this.enterFirstName = new System.Windows.Forms.TextBox();
            this.enterLastName = new System.Windows.Forms.TextBox();
            this.enterIdNum = new System.Windows.Forms.TextBox();
            this.basicCS = new System.Windows.Forms.CheckedListBox();
            this.createNew = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nsuLogo)).BeginInit();
            this.createNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(702, 12);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(96, 298);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(137, 23);
            this.createAccount.TabIndex = 1;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(596, 13);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 2;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(379, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 22);
            this.username.TabIndex = 3;
            // 
            // UserLogin
            // 
            this.UserLogin.AutoSize = true;
            this.UserLogin.Location = new System.Drawing.Point(300, 17);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(73, 17);
            this.UserLogin.TabIndex = 4;
            this.UserLogin.Text = "Username";
            // 
            // userPass
            // 
            this.userPass.AutoSize = true;
            this.userPass.Location = new System.Drawing.Point(517, 17);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(69, 17);
            this.userPass.TabIndex = 5;
            this.userPass.Text = "Password";
            // 
            // nsuLogo
            // 
            this.nsuLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("nsuLogo.ErrorImage")));
            this.nsuLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("nsuLogo.InitialImage")));
            this.nsuLogo.Location = new System.Drawing.Point(55, 121);
            this.nsuLogo.Name = "nsuLogo";
            this.nsuLogo.Size = new System.Drawing.Size(178, 205);
            this.nsuLogo.TabIndex = 6;
            this.nsuLogo.TabStop = false;
            // 
            // firstCreate
            // 
            this.firstCreate.AutoSize = true;
            this.firstCreate.Location = new System.Drawing.Point(35, 30);
            this.firstCreate.Name = "firstCreate";
            this.firstCreate.Size = new System.Drawing.Size(76, 17);
            this.firstCreate.TabIndex = 7;
            this.firstCreate.Text = "First Name";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(37, 60);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(76, 17);
            this.LName.TabIndex = 8;
            this.LName.Text = "Last Name";
            // 
            // studentID
            // 
            this.studentID.AutoSize = true;
            this.studentID.Location = new System.Drawing.Point(37, 90);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(74, 17);
            this.studentID.TabIndex = 9;
            this.studentID.Text = "Student ID";
            this.studentID.Click += new System.EventHandler(this.studentID_Click);
            // 
            // trackSelect
            // 
            this.trackSelect.AutoSize = true;
            this.trackSelect.Location = new System.Drawing.Point(122, 163);
            this.trackSelect.Name = "trackSelect";
            this.trackSelect.Size = new System.Drawing.Size(87, 17);
            this.trackSelect.TabIndex = 10;
            this.trackSelect.Text = "Select Track";
            // 
            // enterFirstName
            // 
            this.enterFirstName.Location = new System.Drawing.Point(140, 27);
            this.enterFirstName.Name = "enterFirstName";
            this.enterFirstName.Size = new System.Drawing.Size(100, 22);
            this.enterFirstName.TabIndex = 11;
            // 
            // enterLastName
            // 
            this.enterLastName.Location = new System.Drawing.Point(140, 60);
            this.enterLastName.Name = "enterLastName";
            this.enterLastName.Size = new System.Drawing.Size(100, 22);
            this.enterLastName.TabIndex = 12;
            // 
            // enterIdNum
            // 
            this.enterIdNum.Location = new System.Drawing.Point(140, 90);
            this.enterIdNum.Name = "enterIdNum";
            this.enterIdNum.Size = new System.Drawing.Size(100, 22);
            this.enterIdNum.TabIndex = 13;
            // 
            // basicCS
            // 
            this.basicCS.FormattingEnabled = true;
            this.basicCS.Items.AddRange(new object[] {
            "basicCs",
            "IT",
            "IA"});
            this.basicCS.Location = new System.Drawing.Point(114, 183);
            this.basicCS.Name = "basicCS";
            this.basicCS.Size = new System.Drawing.Size(120, 89);
            this.basicCS.TabIndex = 14;
            // 
            // createNew
            // 
            this.createNew.Controls.Add(this.enterLastName);
            this.createNew.Controls.Add(this.basicCS);
            this.createNew.Controls.Add(this.trackSelect);
            this.createNew.Controls.Add(this.firstCreate);
            this.createNew.Controls.Add(this.enterIdNum);
            this.createNew.Controls.Add(this.LName);
            this.createNew.Controls.Add(this.studentID);
            this.createNew.Controls.Add(this.enterFirstName);
            this.createNew.Controls.Add(this.createAccount);
            this.createNew.Location = new System.Drawing.Point(410, 78);
            this.createNew.Name = "createNew";
            this.createNew.Size = new System.Drawing.Size(325, 327);
            this.createNew.TabIndex = 15;
            this.createNew.TabStop = false;
            this.createNew.Text = "Create New Account";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createNew);
            this.Controls.Add(this.nsuLogo);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "Welcome";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.nsuLogo)).EndInit();
            this.createNew.ResumeLayout(false);
            this.createNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label UserLogin;
        private System.Windows.Forms.Label userPass;
        private System.Windows.Forms.PictureBox nsuLogo;
        private System.Windows.Forms.Label firstCreate;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label studentID;
        private System.Windows.Forms.Label trackSelect;
        private System.Windows.Forms.TextBox enterFirstName;
        private System.Windows.Forms.TextBox enterLastName;
        private System.Windows.Forms.TextBox enterIdNum;
        private System.Windows.Forms.CheckedListBox basicCS;
        private System.Windows.Forms.GroupBox createNew;
    }
}