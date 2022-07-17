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
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Путь базы данных";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void данныеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.данныеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.база_данныхDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet.Данные". При необходимости она может быть перемещена или удалена.
            this.данныеTableAdapter.Fill(this.база_данныхDataSet.Данные);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void поискПоИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchToName f2 = new SearchToName();
            f2.Owner = this;
            f2.Show();
        }

        private void поискПоФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchToLast f3 = new SearchToLast();
            f3.Owner = this;
            f3.Show();
        }

        private void поискПоПочтеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchToEmail f4 = new SearchToEmail();
            f4.Owner = this;
            f4.Show();
        }

        private void поискПоПаролюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchToPass f5 = new SearchToPass();
            f5.Owner = this;
            f5.Show();
        }

        private void поискПоНомеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchToNumber f6 = new SearchToNumber();
            f6.Owner = this;
            f6.Show();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 f7 = new AboutBox1();
            f7.Owner = this;
            f7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.данныеTableAdapter.Fill(this.база_данныхDataSet.Данные);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogAdmin f8 = new LogAdmin();
            f8.Owner = this;
            f8.Show();
            MessageBox.Show("Добавить данные в базу могут те, у кого есть ключ активации! Если он у вас есть, то введите его.");
        }
    }
}
