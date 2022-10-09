using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivan
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button_exist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void privet_mum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет мама");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kypit1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем с покупкой \nТеперь вы счастливый обладатель танка Тигр\nНадеемся вы будете применять его по значению");
        }

        private void kypit2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем с покупкой \nТеперь вы счастливый обладатель танка САУ Фердинанд\nНадеемся вы будете применять его по значению");
        }

        private void kypit3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем с покупкой \nТеперь вы счастливый обладатель танка Пантера \nНадеемся вы будете применять его по значению");
        }
    }
}
