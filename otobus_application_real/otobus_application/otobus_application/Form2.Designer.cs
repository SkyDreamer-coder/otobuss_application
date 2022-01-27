
namespace otobus_application
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtbEnter = new System.Windows.Forms.Button();
            this.RbAdmin = new System.Windows.Forms.RadioButton();
            this.RbCustomer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(422, 73);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(100, 22);
            this.TxtUser.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(422, 128);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 22);
            this.TxtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // BtbEnter
            // 
            this.BtbEnter.Location = new System.Drawing.Point(273, 284);
            this.BtbEnter.Name = "BtbEnter";
            this.BtbEnter.Size = new System.Drawing.Size(184, 33);
            this.BtbEnter.TabIndex = 4;
            this.BtbEnter.Text = "Giriş";
            this.BtbEnter.UseVisualStyleBackColor = true;
            this.BtbEnter.Click += new System.EventHandler(this.BtbEnter_Click);
            // 
            // RbAdmin
            // 
            this.RbAdmin.AutoSize = true;
            this.RbAdmin.Checked = true;
            this.RbAdmin.Location = new System.Drawing.Point(239, 202);
            this.RbAdmin.Name = "RbAdmin";
            this.RbAdmin.Size = new System.Drawing.Size(79, 21);
            this.RbAdmin.TabIndex = 5;
            this.RbAdmin.TabStop = true;
            this.RbAdmin.Text = "Yönetici";
            this.RbAdmin.UseVisualStyleBackColor = true;
            // 
            // RbCustomer
            // 
            this.RbCustomer.AutoSize = true;
            this.RbCustomer.Location = new System.Drawing.Point(422, 202);
            this.RbCustomer.Name = "RbCustomer";
            this.RbCustomer.Size = new System.Drawing.Size(64, 21);
            this.RbCustomer.TabIndex = 6;
            this.RbCustomer.Text = "Yolcu";
            this.RbCustomer.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 426);
            this.Controls.Add(this.RbCustomer);
            this.Controls.Add(this.RbAdmin);
            this.Controls.Add(this.BtbEnter);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtbEnter;
        private System.Windows.Forms.RadioButton RbAdmin;
        private System.Windows.Forms.RadioButton RbCustomer;
    }
}