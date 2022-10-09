
namespace Ivan
{
    partial class regForm
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
            this.regpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.repeatpassBox = new System.Windows.Forms.TextBox();
            this.BackauthButt = new System.Windows.Forms.Button();
            this.regcomfButt = new System.Windows.Forms.Button();
            this.regpassBox = new System.Windows.Forms.TextBox();
            this.regloginBox = new System.Windows.Forms.TextBox();
            this.regpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // regpanel
            // 
            this.regpanel.Controls.Add(this.label3);
            this.regpanel.Controls.Add(this.label2);
            this.regpanel.Controls.Add(this.label1);
            this.regpanel.Controls.Add(this.repeatpassBox);
            this.regpanel.Controls.Add(this.BackauthButt);
            this.regpanel.Controls.Add(this.regcomfButt);
            this.regpanel.Controls.Add(this.regpassBox);
            this.regpanel.Controls.Add(this.regloginBox);
            this.regpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regpanel.Location = new System.Drawing.Point(0, 0);
            this.regpanel.Name = "regpanel";
            this.regpanel.Size = new System.Drawing.Size(384, 462);
            this.regpanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Повторите \r\nпароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // repeatpassBox
            // 
            this.repeatpassBox.Location = new System.Drawing.Point(100, 160);
            this.repeatpassBox.Name = "repeatpassBox";
            this.repeatpassBox.Size = new System.Drawing.Size(189, 20);
            this.repeatpassBox.TabIndex = 4;
            // 
            // BackauthButt
            // 
            this.BackauthButt.Location = new System.Drawing.Point(120, 299);
            this.BackauthButt.Name = "BackauthButt";
            this.BackauthButt.Size = new System.Drawing.Size(145, 30);
            this.BackauthButt.TabIndex = 3;
            this.BackauthButt.Text = "Назад";
            this.BackauthButt.UseVisualStyleBackColor = true;
            this.BackauthButt.Click += new System.EventHandler(this.BackauthButt_Click);
            // 
            // regcomfButt
            // 
            this.regcomfButt.Location = new System.Drawing.Point(120, 213);
            this.regcomfButt.Name = "regcomfButt";
            this.regcomfButt.Size = new System.Drawing.Size(145, 30);
            this.regcomfButt.TabIndex = 2;
            this.regcomfButt.Text = "Зарегистрироваться";
            this.regcomfButt.UseVisualStyleBackColor = true;
            this.regcomfButt.Click += new System.EventHandler(this.regcomfButt_Click);
            // 
            // regpassBox
            // 
            this.regpassBox.Location = new System.Drawing.Point(100, 120);
            this.regpassBox.Name = "regpassBox";
            this.regpassBox.Size = new System.Drawing.Size(189, 20);
            this.regpassBox.TabIndex = 1;
            // 
            // regloginBox
            // 
            this.regloginBox.Location = new System.Drawing.Point(100, 80);
            this.regloginBox.Name = "regloginBox";
            this.regloginBox.Size = new System.Drawing.Size(189, 20);
            this.regloginBox.TabIndex = 0;
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.regpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "regForm";
            this.Text = "regForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.regForm_FormClosing);
            this.regpanel.ResumeLayout(false);
            this.regpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel regpanel;
        private System.Windows.Forms.TextBox regpassBox;
        private System.Windows.Forms.TextBox regloginBox;
        private System.Windows.Forms.Button regcomfButt;
        private System.Windows.Forms.Button BackauthButt;
        private System.Windows.Forms.TextBox repeatpassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}