namespace SNHUber_Eats
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
            this.label2 = new System.Windows.Forms.Label();
            this.Username_entry = new System.Windows.Forms.TextBox();
            this.Password_entry = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.Signup_label = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log in to Your Account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Username_entry
            // 
            this.Username_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_entry.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Username_entry.Location = new System.Drawing.Point(137, 247);
            this.Username_entry.Name = "Username_entry";
            this.Username_entry.Size = new System.Drawing.Size(569, 30);
            this.Username_entry.TabIndex = 2;
            // 
            // Password_entry
            // 
            this.Password_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_entry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password_entry.Location = new System.Drawing.Point(137, 303);
            this.Password_entry.Name = "Password_entry";
            this.Password_entry.PasswordChar = '*';
            this.Password_entry.Size = new System.Drawing.Size(569, 30);
            this.Password_entry.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Blue;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(167, 431);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(438, 51);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Signup_label
            // 
            this.Signup_label.AutoSize = true;
            this.Signup_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_label.ForeColor = System.Drawing.Color.Blue;
            this.Signup_label.Location = new System.Drawing.Point(134, 361);
            this.Signup_label.Name = "Signup_label";
            this.Signup_label.Size = new System.Drawing.Size(180, 17);
            this.Signup_label.TabIndex = 5;
            this.Signup_label.Text = "Not a member yet? Sign up";
            this.Signup_label.Click += new System.EventHandler(this.Signup_label_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(369, 280);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(153, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(477, 128);
            this.label7.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(24, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(24, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Signup_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.Password_entry);
            this.Controls.Add(this.Username_entry);
            this.Controls.Add(this.label2);
            this.Name = "Login";
            this.Text = "Log-in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username_entry;
        private System.Windows.Forms.TextBox Password_entry;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label Signup_label;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}