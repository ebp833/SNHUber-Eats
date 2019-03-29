namespace SNHUber_Eats
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.name_entry = new System.Windows.Forms.TextBox();
            this.email_entry = new System.Windows.Forms.TextBox();
            this.room_entry = new System.Windows.Forms.TextBox();
            this.building = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentIDEntry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Password_label = new System.Windows.Forms.Label();
            this.Passord_Entry = new System.Windows.Forms.TextBox();
            this.Password_Re_entry = new System.Windows.Forms.TextBox();
            this.ValidationLabel = new System.Windows.Forms.Label();
            this.PasswordDouble = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_entry
            // 
            this.name_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_entry.Location = new System.Drawing.Point(146, 280);
            this.name_entry.Name = "name_entry";
            this.name_entry.Size = new System.Drawing.Size(456, 30);
            this.name_entry.TabIndex = 3;
            this.name_entry.TextChanged += new System.EventHandler(this.name_entry_TextChanged);
            // 
            // email_entry
            // 
            this.email_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_entry.Location = new System.Drawing.Point(146, 140);
            this.email_entry.Name = "email_entry";
            this.email_entry.Size = new System.Drawing.Size(456, 30);
            this.email_entry.TabIndex = 0;
            this.email_entry.TextChanged += new System.EventHandler(this.email_entry_TextChanged);
            // 
            // room_entry
            // 
            this.room_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_entry.Location = new System.Drawing.Point(146, 355);
            this.room_entry.Name = "room_entry";
            this.room_entry.Size = new System.Drawing.Size(456, 30);
            this.room_entry.TabIndex = 5;
            this.room_entry.TextChanged += new System.EventHandler(this.room_entry_TextChanged);
            // 
            // building
            // 
            this.building.AllowDrop = true;
            this.building.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.building.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.building.FormattingEnabled = true;
            this.building.ImeMode = System.Windows.Forms.ImeMode.On;
            this.building.Items.AddRange(new object[] {
            "Hampton",
            "Kingston",
            "Manadnock",
            "New Castle",
            "Tuckerman",
            "Washington",
            "Windsor"});
            this.building.Location = new System.Drawing.Point(146, 316);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(456, 33);
            this.building.Sorted = true;
            this.building.TabIndex = 4;
            this.building.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Building";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Payment";
            // 
            // StudentIDEntry
            // 
            this.StudentIDEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDEntry.Location = new System.Drawing.Point(160, 473);
            this.StudentIDEntry.Name = "StudentIDEntry";
            this.StudentIDEntry.Size = new System.Drawing.Size(442, 30);
            this.StudentIDEntry.TabIndex = 6;
            this.StudentIDEntry.TextChanged += new System.EventHandler(this.StudentIDEntry_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Student ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(252, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(31, 179);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(98, 25);
            this.Password_label.TabIndex = 25;
            this.Password_label.Text = "Password";
            // 
            // Passord_Entry
            // 
            this.Passord_Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passord_Entry.Location = new System.Drawing.Point(146, 176);
            this.Passord_Entry.Name = "Passord_Entry";
            this.Passord_Entry.PasswordChar = '*';
            this.Passord_Entry.Size = new System.Drawing.Size(456, 30);
            this.Passord_Entry.TabIndex = 1;
            // 
            // Password_Re_entry
            // 
            this.Password_Re_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Re_entry.Location = new System.Drawing.Point(146, 226);
            this.Password_Re_entry.Name = "Password_Re_entry";
            this.Password_Re_entry.PasswordChar = '*';
            this.Password_Re_entry.Size = new System.Drawing.Size(456, 30);
            this.Password_Re_entry.TabIndex = 2;
            this.Password_Re_entry.TextChanged += new System.EventHandler(this.Password_Re_entry_TextChanged);
            // 
            // ValidationLabel
            // 
            this.ValidationLabel.AutoSize = true;
            this.ValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ValidationLabel.Location = new System.Drawing.Point(402, 535);
            this.ValidationLabel.Name = "ValidationLabel";
            this.ValidationLabel.Size = new System.Drawing.Size(0, 25);
            this.ValidationLabel.TabIndex = 27;
            // 
            // PasswordDouble
            // 
            this.PasswordDouble.AutoSize = true;
            this.PasswordDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordDouble.Location = new System.Drawing.Point(31, 217);
            this.PasswordDouble.Name = "PasswordDouble";
            this.PasswordDouble.Size = new System.Drawing.Size(98, 50);
            this.PasswordDouble.TabIndex = 28;
            this.PasswordDouble.Text = "Re-Type\r\nPassword";
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(89, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(471, 128);
            this.label7.TabIndex = 29;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(640, 572);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PasswordDouble);
            this.Controls.Add(this.ValidationLabel);
            this.Controls.Add(this.Password_Re_entry);
            this.Controls.Add(this.Passord_Entry);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StudentIDEntry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.building);
            this.Controls.Add(this.room_entry);
            this.Controls.Add(this.email_entry);
            this.Controls.Add(this.name_entry);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_entry;
        private System.Windows.Forms.TextBox email_entry;
        private System.Windows.Forms.TextBox room_entry;
        private System.Windows.Forms.ComboBox building;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StudentIDEntry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Passord_Entry;
        private System.Windows.Forms.TextBox Password_Re_entry;
        private System.Windows.Forms.Label ValidationLabel;
        private System.Windows.Forms.Label PasswordDouble;
        private System.Windows.Forms.Label label7;
    }
}