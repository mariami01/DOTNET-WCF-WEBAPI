namespace Client
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
            this.loginlabel = new System.Windows.Forms.Label();
            this.passwordinput = new System.Windows.Forms.TextBox();
            this.emailinput = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.loginlabel.Location = new System.Drawing.Point(324, 29);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(101, 39);
            this.loginlabel.TabIndex = 9;
            this.loginlabel.Text = "Login";
            // 
            // passwordinput
            // 
            this.passwordinput.Location = new System.Drawing.Point(386, 147);
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.Size = new System.Drawing.Size(158, 22);
            this.passwordinput.TabIndex = 13;
            this.passwordinput.Text = "password";
            this.passwordinput.TextChanged += new System.EventHandler(this.passwordinput_TextChanged);
            // 
            // emailinput
            // 
            this.emailinput.Location = new System.Drawing.Point(386, 112);
            this.emailinput.Name = "emailinput";
            this.emailinput.Size = new System.Drawing.Size(158, 22);
            this.emailinput.TabIndex = 12;
            this.emailinput.Text = "emailinput";
            this.emailinput.TextChanged += new System.EventHandler(this.emailinput_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(254, 147);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 16);
            this.password.TabIndex = 11;
            this.password.Text = "Password";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(254, 112);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(331, 212);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 14;
            this.loginbtn.Text = "Submit";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(405, 294);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(75, 23);
            this.registerbtn.TabIndex = 15;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.register.Location = new System.Drawing.Point(182, 297);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(217, 20);
            this.register.TabIndex = 16;
            this.register.Text = "if you don\'t have an account";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordinput);
            this.Controls.Add(this.emailinput);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.loginlabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.TextBox passwordinput;
        private System.Windows.Forms.TextBox emailinput;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label register;
    }
}