
namespace Ivan
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.button_exist = new System.Windows.Forms.Button();
            this.privet_mum = new System.Windows.Forms.Button();
            this.kypit1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kypit2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.kypit3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exist
            // 
            this.button_exist.Location = new System.Drawing.Point(665, 396);
            this.button_exist.Name = "button_exist";
            this.button_exist.Size = new System.Drawing.Size(123, 42);
            this.button_exist.TabIndex = 0;
            this.button_exist.Text = "Выход";
            this.button_exist.UseVisualStyleBackColor = true;
            this.button_exist.Click += new System.EventHandler(this.button_exist_Click);
            // 
            // privet_mum
            // 
            this.privet_mum.Location = new System.Drawing.Point(665, 331);
            this.privet_mum.Name = "privet_mum";
            this.privet_mum.Size = new System.Drawing.Size(123, 45);
            this.privet_mum.TabIndex = 1;
            this.privet_mum.Text = "Сказать привет маме";
            this.privet_mum.UseVisualStyleBackColor = true;
            this.privet_mum.Click += new System.EventHandler(this.privet_mum_Click);
            // 
            // kypit1
            // 
            this.kypit1.Location = new System.Drawing.Point(12, 201);
            this.kypit1.Name = "kypit1";
            this.kypit1.Size = new System.Drawing.Size(228, 35);
            this.kypit1.TabIndex = 2;
            this.kypit1.Text = "Купить";
            this.kypit1.UseVisualStyleBackColor = true;
            this.kypit1.Click += new System.EventHandler(this.kypit1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 158);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // kypit2
            // 
            this.kypit2.Location = new System.Drawing.Point(292, 201);
            this.kypit2.Name = "kypit2";
            this.kypit2.Size = new System.Drawing.Size(228, 35);
            this.kypit2.TabIndex = 5;
            this.kypit2.Text = "Купить";
            this.kypit2.UseVisualStyleBackColor = true;
            this.kypit2.Click += new System.EventHandler(this.kypit2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(292, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 158);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Танк тигр";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Танк САУ Фердинанд";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(560, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(228, 158);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(560, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Танк Пантера";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // kypit3
            // 
            this.kypit3.Location = new System.Drawing.Point(560, 201);
            this.kypit3.Name = "kypit3";
            this.kypit3.Size = new System.Drawing.Size(228, 35);
            this.kypit3.TabIndex = 11;
            this.kypit3.Text = "Купить";
            this.kypit3.UseVisualStyleBackColor = true;
            this.kypit3.Click += new System.EventHandler(this.kypit3_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kypit3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kypit2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kypit1);
            this.Controls.Add(this.privet_mum);
            this.Controls.Add(this.button_exist);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exist;
        private System.Windows.Forms.Button privet_mum;
        private System.Windows.Forms.Button kypit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kypit2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button kypit3;
    }
}