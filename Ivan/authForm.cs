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
    public partial class authForm : Form
    {
        public authForm()
        {
            InitializeComponent();
        }

        void openchild(Panel panel,Form eform) 
        {
            eform.TopLevel = false;
            eform.FormBorderStyle = FormBorderStyle.None;
            eform.Dock = DockStyle.Fill;
            panel.Controls.Add(eform);
            eform.BringToFront();
            eform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void regButt_Click(object sender, EventArgs e)
        {
            openchild(authpanel, new regForm());




        }

        private void authForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void authButt_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT id_user FROM auth WHERE login='" + authloginBox.Text + "' and parol = '" + authpassBox.Text + "';";
                MySqlConnection conn = DBUntils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                conn.Open();

                int id = 0;
                id = Convert.ToInt32(cmDB.ExecuteScalar());
                if (id > 0)
                {

                    this.Hide();
                    mainForm Win = new mainForm();
                    Win.Show();
                    
                }
                else
                {
                    MessageBox.Show(" Ошибка авторизации");
                }


            }
            catch
            {
                MessageBox.Show(" Ошибка подключения(вы лох)");
            }

        }
    }
}
