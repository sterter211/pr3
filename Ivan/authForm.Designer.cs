
namespace Ivan
{
    partial class authForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.authpanel = new System.Windows.Forms.Panel();
            this.regButt = new System.Windows.Forms.Button();
            this.authpassBox = new System.Windows.Forms.TextBox();
            this.authButt = new System.Windows.Forms.Button();
            this.authloginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // authpanel
            // 
            this.authpanel.Controls.Add(this.label2);
            this.authpanel.Controls.Add(this.label1);
            this.authpanel.Controls.Add(this.regButt);
            this.authpanel.Controls.Add(this.authpassBox);
            this.authpanel.Controls.Add(this.authButt);
            this.authpanel.Controls.Add(this.authloginBox);
            this.authpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authpanel.Location = new System.Drawing.Point(0, 0);
            this.authpanel.Name = "authpanel";
            this.authpanel.Size = new System.Drawing.Size(384, 462);
            this.authpanel.TabIndex = 0;
            // 
            // regButt
            // 
            this.regButt.Location = new System.Drawing.Point(120, 299);
            this.regButt.Name = "regButt";
            this.regButt.Size = new System.Drawing.Size(145, 30);
            this.regButt.TabIndex = 4;
            this.regButt.Text = "регистрация";
            this.regButt.UseVisualStyleBackColor = true;
            this.regButt.Click += new System.EventHandler(this.regButt_Click);
            // 
            // authpassBox
            // 
            this.authpassBox.Location = new System.Drawing.Point(100, 120);
            this.authpassBox.Name = "authpassBox";
            this.authpassBox.Size = new System.Drawing.Size(189, 20);
            this.authpassBox.TabIndex = 3;
            // 
            // authButt
            // 
            this.authButt.Location = new System.Drawing.Point(120, 163);
            this.authButt.Name = "authButt";
            this.authButt.Size = new System.Drawing.Size(145, 30);
            this.authButt.TabIndex = 2;
            this.authButt.Text = "Войти";
            this.authButt.UseVisualStyleBackColor = true;
            this.authButt.Click += new System.EventHandler(this.authButt_Click);
            // 
            // authloginBox
            // 
            this.authloginBox.Location = new System.Drawing.Point(100, 80);
            this.authloginBox.Name = "authloginBox";
            this.authloginBox.Size = new System.Drawing.Size(189, 20);
            this.authloginBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // authForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.authpanel);
            this.Name = "authForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.authForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.authpanel.ResumeLayout(false);
            this.authpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel authpanel;
        private System.Windows.Forms.Button authButt;
        private System.Windows.Forms.TextBox authloginBox;
        private System.Windows.Forms.Button regButt;
        private System.Windows.Forms.TextBox authpassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

