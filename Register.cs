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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            loginReg.Text = "Ввидите логин";
            loginReg.ForeColor = Color.Gray;
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

        Point lastsas;
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastsas.X;
                this.Top += e.Y - lastsas.Y;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastsas = new Point(e.X, e.Y);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginReg_Enter(object sender, EventArgs e)
        {
            if (loginReg.Text == "Ввидите логин")
            {
                loginReg.Text = "";
                loginReg.ForeColor = Color.Black;
            }
        }

        private void passreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void passreg_Enter(object sender, EventArgs e)
        {

        }

        private void loginReg_Leave(object sender, EventArgs e)
        {
            if (loginReg.Text == "")
            {
                loginReg.Text = "Ввидите логин";
                loginReg.ForeColor = Color.Gray;
            }
        }

        private void passreg_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form1();
            this.Visible = false;
            f2.Show();
        }

        private void loginReg_Click(object sender, EventArgs e)
        {
            if (loginReg.Text == "Ввидите логин")
            {
                loginReg.Text = "";
            }
        }

        private void registered_Click(object sender, EventArgs e)
        {
            if (loginReg.Text == "Ввидите логин")
            {
                MessageBox.Show("Вы не можете зарегистрировать аккаунт с такими данными!");
                return;
            }

            if (passreg.Text == "Ввидите пароль")
            {
                MessageBox.Show("Вы не можете зарегистрировать аккаунт с такими данными!");
                return;
            }

            if(loginReg.Text == "")
            {
                MessageBox.Show("Вы не можете зарегистрировать аккаунт с такими данными!");
                return;
            }

            if(passreg.Text == "")
            {
                MessageBox.Show("Вы не можете зарегистрировать аккаунт с такими данными!");
                return;
            }

            if (IsUserExist())
                return;
         

                dbmysqlcon db = new dbmysqlcon();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`) VALUES (@login, @password);", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginReg.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passreg.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно зарегестрировались!");
            }
            else
            {
                MessageBox.Show("Произошла ошибка или игрок с таким именем существует!");
            }

            db.closeConnection();
        }

        public Boolean IsUserExist()
        {
            dbmysqlcon db = new dbmysqlcon();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginReg.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный пользователь уже зарегестрирован!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
