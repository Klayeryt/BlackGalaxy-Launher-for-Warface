using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string warn = "Внимание!";
            InitializeComponent();
            MessageBox.Show("Данная програма сделана для ознакомление с демо-версией продукта\n\nЛюбое копирование продукта является нарушением авторского права!\n\nKlayeryt programm ©\n\nЕсли возникли вопросы, то можно обратиться по адресу: |klayeryt@bk.ru|", warn);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            dbmysqlcon db = new dbmysqlcon();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Вы успешно авторизированы нажмите ок для запуска игры!");
            else
            {
                MessageBox.Show("Неправильные данные!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Point onePoint;
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            onePoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - onePoint.X;
                this.Top += e.Y - onePoint.Y;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form f2 = new Register();
            this.Visible = false;
            f2.Show();
        }
    }
}
