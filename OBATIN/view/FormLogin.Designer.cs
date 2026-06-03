using System;

namespace OBATIN.view
{
    partial class FormLogin
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
            this.panelkiri = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.panelkiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelkiri
            // 
            this.panelkiri.BackColor = System.Drawing.Color.LightCyan;
            this.panelkiri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelkiri.Controls.Add(this.logo);
            this.panelkiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelkiri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelkiri.Location = new System.Drawing.Point(0, 0);
            this.panelkiri.Margin = new System.Windows.Forms.Padding(2);
            this.panelkiri.Name = "panelkiri";
            this.panelkiri.Size = new System.Drawing.Size(212, 256);
            this.panelkiri.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Image = global::OBATIN.Properties.Resources.obatin;
            this.logo.Location = new System.Drawing.Point(51, 73);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 98);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Teal;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.Location = new System.Drawing.Point(319, 196);
            this.login_btn.Margin = new System.Windows.Forms.Padding(2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(103, 32);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(247, 84);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(55, 13);
            this.username_lbl.TabIndex = 4;
            this.username_lbl.Text = "Username";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(251, 138);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(53, 13);
            this.password_lbl.TabIndex = 5;
            this.password_lbl.Text = "Password";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.Color.Teal;
            this.login_lbl.Location = new System.Drawing.Point(321, 29);
            this.login_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(110, 19);
            this.login_lbl.TabIndex = 6;
            this.login_lbl.Text = "Login Apotek";
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.White;
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.ForeColor = System.Drawing.Color.Black;
            this.password_txt.Location = new System.Drawing.Point(319, 131);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.password_txt.Multiline = true;
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(182, 27);
            this.password_txt.TabIndex = 7;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged_2);
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.White;
            this.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.Black;
            this.username_txt.Location = new System.Drawing.Point(319, 77);
            this.username_txt.Margin = new System.Windows.Forms.Padding(2);
            this.username_txt.Multiline = true;
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(182, 27);
            this.username_txt.TabIndex = 8;
            this.username_txt.TextChanged += new System.EventHandler(this.username_txt_TextChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 256);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.panelkiri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelkiri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelkiri;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label login_lbl;
        private EventHandler usernzme_txt_TextChanged;
        private EventHandler password_txt_TextChanged;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
    }
}