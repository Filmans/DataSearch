using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataSearch
{
    public partial class AddData : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Путь базы данных";
        private OleDbConnection Conection;
        public AddData()
        {
            InitializeComponent();
            Conection = new OleDbConnection(connectString);
            Conection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string Name = textBox2.Text;
            string Surname = textBox3.Text;
            string Email = textBox4.Text;
            string Pass = textBox5.Text;
            string Phone = textBox6.Text;
            string zapros = "INSERT INTO данные ([Код], Имя, Фамилия, Почта, Пароль, Телефон) VALUES (" + kod + ",'" + Name + "','" + Surname + "','" + Email + "','" + Pass + "','" + Phone + "')";
            OleDbCommand command = new OleDbCommand(zapros, Conection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены!");
        }
    }
}
