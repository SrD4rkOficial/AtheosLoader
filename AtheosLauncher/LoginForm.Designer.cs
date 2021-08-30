namespace AtheosLauncher
{
    /// <summary>
    /// Defines the <see cref="LoginForm" />.
    /// </summary>
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable......
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginbutton = new System.Windows.Forms.Button();
            this.nomeprograma = new System.Windows.Forms.Label();
            this.loginlabel = new System.Windows.Forms.Label();
            this.dbstatus = new System.Windows.Forms.Label();
            this.cheatstatus = new System.Windows.Forms.Label();
            this.cheatstatusresult = new System.Windows.Forms.Label();
            this.dbstatusresult = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.hex = new System.Windows.Forms.Label();
            this.injectstatus = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(192, 248);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(0);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(111, 39);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.TabStop = false;
            this.loginbutton.Text = "Login and Inject";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginfunc);
            // 
            // nomeprograma
            // 
            this.nomeprograma.AutoSize = true;
            this.nomeprograma.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeprograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nomeprograma.Location = new System.Drawing.Point(6, 6);
            this.nomeprograma.Name = "nomeprograma";
            this.nomeprograma.Size = new System.Drawing.Size(125, 19);
            this.nomeprograma.TabIndex = 6;
            this.nomeprograma.Text = "𝘼𝙏𝙃𝙀𝙊𝙎 Loader";
            this.nomeprograma.Click += new System.EventHandler(this.nomeprogramafunc);
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginlabel.Location = new System.Drawing.Point(111, 48);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(90, 32);
            this.loginlabel.TabIndex = 8;
            this.loginlabel.Text = "Login";
            this.loginlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbstatus
            // 
            this.dbstatus.AutoSize = true;
            this.dbstatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dbstatus.Location = new System.Drawing.Point(7, 249);
            this.dbstatus.Name = "dbstatus";
            this.dbstatus.Size = new System.Drawing.Size(119, 15);
            this.dbstatus.TabIndex = 9;
            this.dbstatus.Text = "Database status:";
            // 
            // cheatstatus
            // 
            this.cheatstatus.AutoSize = true;
            this.cheatstatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cheatstatus.Location = new System.Drawing.Point(7, 272);
            this.cheatstatus.Name = "cheatstatus";
            this.cheatstatus.Size = new System.Drawing.Size(98, 15);
            this.cheatstatus.TabIndex = 10;
            this.cheatstatus.Text = "Cheat status:";
            // 
            // cheatstatusresult
            // 
            this.cheatstatusresult.AutoSize = true;
            this.cheatstatusresult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatstatusresult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cheatstatusresult.Location = new System.Drawing.Point(105, 273);
            this.cheatstatusresult.Name = "cheatstatusresult";
            this.cheatstatusresult.Size = new System.Drawing.Size(35, 15);
            this.cheatstatusresult.TabIndex = 11;
            this.cheatstatusresult.Text = "Null";
            // 
            // dbstatusresult
            // 
            this.dbstatusresult.AutoSize = true;
            this.dbstatusresult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbstatusresult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dbstatusresult.Location = new System.Drawing.Point(127, 249);
            this.dbstatusresult.Name = "dbstatusresult";
            this.dbstatusresult.Size = new System.Drawing.Size(35, 15);
            this.dbstatusresult.TabIndex = 12;
            this.dbstatusresult.Text = "Null";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.username.Location = new System.Drawing.Point(99, 112);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(115, 26);
            this.username.TabIndex = 13;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.password.Location = new System.Drawing.Point(99, 169);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(115, 26);
            this.password.TabIndex = 14;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.usernamelabel.Location = new System.Drawing.Point(116, 89);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(81, 19);
            this.usernamelabel.TabIndex = 15;
            this.usernamelabel.Text = "Username";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.passwordlabel.Location = new System.Drawing.Point(116, 146);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(81, 19);
            this.passwordlabel.TabIndex = 16;
            this.passwordlabel.Text = "Password";
            this.passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.hex.Location = new System.Drawing.Point(134, 224);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(56, 15);
            this.hex.TabIndex = 17;
            this.hex.Text = "Waiting";
            this.hex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // injectstatus
            // 
            this.injectstatus.AutoSize = true;
            this.injectstatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.injectstatus.Location = new System.Drawing.Point(7, 224);
            this.injectstatus.Name = "injectstatus";
            this.injectstatus.Size = new System.Drawing.Size(126, 15);
            this.injectstatus.TabIndex = 18;
            this.injectstatus.Text = "Injection status:";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Black;
            this.close.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(286, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 28);
            this.close.TabIndex = 19;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.closefunc);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AtheosLauncher.Properties.Resources.discordwhiteresized;
            this.pictureBox1.Location = new System.Drawing.Point(257, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AtheosLauncher.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(69, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AtheosLauncher.Properties.Resources.username;
            this.pictureBox3.Location = new System.Drawing.Point(69, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AtheosLauncher.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(312, 298);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.injectstatus);
            this.Controls.Add(this.hex);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.dbstatusresult);
            this.Controls.Add(this.cheatstatusresult);
            this.Controls.Add(this.cheatstatus);
            this.Controls.Add(this.dbstatus);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.nomeprograma);
            this.Controls.Add(this.loginbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Atheos Loader";
            this.Load += new System.EventHandler(this.loadingfunc);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Defines the loginbutton.
        /// </summary>
        private System.Windows.Forms.Button loginbutton;

        /// <summary>
        /// Defines the nomeprograma.
        /// </summary>
        private System.Windows.Forms.Label nomeprograma;

        /// <summary>
        /// Defines the loginlabel.
        /// </summary>
        private System.Windows.Forms.Label loginlabel;

        /// <summary>
        /// Defines the dbstatus.
        /// </summary>
        private System.Windows.Forms.Label dbstatus;

        /// <summary>
        /// Defines the cheatstatus.
        /// </summary>
        private System.Windows.Forms.Label cheatstatus;

        /// <summary>
        /// Defines the cheatstatusresult.
        /// </summary>
        private System.Windows.Forms.Label cheatstatusresult;

        /// <summary>
        /// Defines the dbstatusresult.
        /// </summary>
        private System.Windows.Forms.Label dbstatusresult;

        /// <summary>
        /// Defines the username.
        /// </summary>
        private System.Windows.Forms.TextBox username;

        /// <summary>
        /// Defines the password.
        /// </summary>
        private System.Windows.Forms.TextBox password;

        /// <summary>
        /// Defines the usernamelabel.
        /// </summary>
        private System.Windows.Forms.Label usernamelabel;

        /// <summary>
        /// Defines the passwordlabel.
        /// </summary>
        private System.Windows.Forms.Label passwordlabel;

        /// <summary>
        /// Defines the hex.
        /// </summary>
        private System.Windows.Forms.Label hex;

        /// <summary>
        /// Defines the injectstatus.
        /// </summary>
        private System.Windows.Forms.Label injectstatus;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
