using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ivan
{
    public partial class regForm : Form
    {
        void openchild(Panel panel, Form eform)
        {
            eform.TopLevel = false;
            eform.FormBorderStyle = FormBorderStyle.None;
            eform.Dock = DockStyle.Fill;
            panel.Controls.Add(eform);
            eform.BringToFront();
            eform.Show();
        }

        public regForm()
        {
            InitializeComponent();
        }

        private void regForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackauthButt_Click(object sender, EventArgs e)
        {
            openchild(regpanel, new authForm());
        }

        private void regcomfButt_Click(object sender, EventArgs e)
        {
            if (regpassBox.Text == repeatpassBox.Text)
            {
                string regg = "insert into auth(login,parol) values('" + regloginBox.Text + "','" + repeatpassBox.Text + "');";
                MySqlConnection conn = DBUntils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(regg, conn);
                conn.Open();

                Convert.ToInt32(cmDB.ExecuteScalar());
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show(" Ошибка регистрации");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
