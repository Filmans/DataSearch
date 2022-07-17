using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSearch
{
    public partial class LogAdmin : Form
    {
        public LogAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                AddData f9 = new AddData();
                this.Hide();
                f9.Show();
                MessageBox.Show("Доступ к добавлению открыто!");
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Неверный ключ активации! Повторите заново.");
            }
        }
    }
}
