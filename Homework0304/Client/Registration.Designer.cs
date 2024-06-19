namespace Client
{
    partial class Registration
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
            this.name = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.nameinput = new System.Windows.Forms.TextBox();
            this.emailinput = new System.Windows.Forms.TextBox();
            this.passwordinput = new System.Windows.Forms.TextBox();
            this.roleinput = new System.Windows.Forms.TextBox();
            this.registrationlabel = new System.Windows.Forms.Label();
            this.regsubmitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(249, 99);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 16);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(249, 138);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(249, 173);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 16);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(249, 212);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(36, 16);
            this.Role.TabIndex = 3;
            this.Role.Text = "Role";
            // 
            // nameinput
            // 
            this.nameinput.Location = new System.Drawing.Point(381, 99);
            this.nameinput.Name = "nameinput";
            this.nameinput.Size = new System.Drawing.Size(158, 22);
            this.nameinput.TabIndex = 4;
            this.nameinput.Text = "nameinput";
            this.nameinput.TextChanged += new System.EventHandler(this.nameinput_TextChanged);
            // 
            // emailinput
            // 
            this.emailinput.Location = new System.Drawing.Point(381, 138);
            this.emailinput.Name = "emailinput";
            this.emailinput.Size = new System.Drawing.Size(158, 22);
            this.emailinput.TabIndex = 5;
            this.emailinput.Text = "emailinput";
            this.emailinput.TextChanged += new System.EventHandler(this.emailinput_TextChanged);
            // 
            // passwordinput
            // 
            this.passwordinput.Location = new System.Drawing.Point(381, 173);
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.Size = new System.Drawing.Size(158, 22);
            this.passwordinput.TabIndex = 6;
            this.passwordinput.Text = "password";
            this.passwordinput.TextChanged += new System.EventHandler(this.passwordinput_TextChanged);
            // 
            // roleinput
            // 
            this.roleinput.Location = new System.Drawing.Point(381, 212);
            this.roleinput.Name = "roleinput";
            this.roleinput.Size = new System.Drawing.Size(158, 22);
            this.roleinput.TabIndex = 7;
            this.roleinput.Text = "roleinput";
            this.roleinput.TextChanged += new System.EventHandler(this.roleinput_TextChanged);
            // 
            // registrationlabel
            // 
            this.registrationlabel.AutoSize = true;
            this.registrationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.registrationlabel.Location = new System.Drawing.Point(292, 22);
            this.registrationlabel.Name = "registrationlabel";
            this.registrationlabel.Size = new System.Drawing.Size(199, 39);
            this.registrationlabel.TabIndex = 8;
            this.registrationlabel.Text = "Registration";
            // 
            // regsubmitbtn
            // 
            this.regsubmitbtn.Location = new System.Drawing.Point(299, 307);
            this.regsubmitbtn.Name = "regsubmitbtn";
            this.regsubmitbtn.Size = new System.Drawing.Size(75, 23);
            this.regsubmitbtn.TabIndex = 9;
            this.regsubmitbtn.Text = "Submit";
            this.regsubmitbtn.UseVisualStyleBackColor = true;
            this.regsubmitbtn.Click += new System.EventHandler(this.regsubmitbtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regsubmitbtn);
            this.Controls.Add(this.registrationlabel);
            this.Controls.Add(this.roleinput);
            this.Controls.Add(this.passwordinput);
            this.Controls.Add(this.emailinput);
            this.Controls.Add(this.nameinput);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.name);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.TextBox nameinput;
        private System.Windows.Forms.TextBox emailinput;
        private System.Windows.Forms.TextBox passwordinput;
        private System.Windows.Forms.TextBox roleinput;
        private System.Windows.Forms.Label registrationlabel;
        private System.Windows.Forms.Button regsubmitbtn;
    }
}