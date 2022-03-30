namespace Student_Enrolment_System_Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(169, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Enrolment System";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.BackColor = System.Drawing.Color.Transparent;
            this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uname.Location = new System.Drawing.Point(203, 193);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(119, 25);
            this.uname.TabIndex = 1;
            this.uname.Text = "User Name";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(365, 190);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(276, 30);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(365, 243);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(276, 30);
            this.password.TabIndex = 4;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pass.Location = new System.Drawing.Point(203, 246);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(106, 25);
            this.pass.TabIndex = 3;
            this.pass.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(208, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(495, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Login";
            this.Text = "Student Enrolment System";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

