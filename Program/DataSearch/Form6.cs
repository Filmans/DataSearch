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
    public partial class SearchToNumber : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Мое видео Владик\\Система поиска\\База данных.accdb";
        private OleDbConnection myConnection;
        public SearchToNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string Phone = textBox1.Text;
            string zapros = "Select Имя, Фамилия, Почта, Пароль, Телефон FROM данные WHERE Телефон LIKE '%" + Phone + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(zapros, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
