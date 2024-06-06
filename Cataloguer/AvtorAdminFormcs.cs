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

namespace Cataloguer
{
    public partial class AvtorAdminForm : Form
    {
        public AvtorAdminForm()
        {
            InitializeComponent();

            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Size.Width, 55);
            AvtorPanel.MouseMove += AvtorPanel_MouseMove;
            AvtPanel.MouseMove += AvtPanel_MouseMove;

            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;

            EmailField.Text = "Введите email";
            EmailField.ForeColor = Color.Gray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastpoint_1;

        private void AvtorPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Control.ModifierKeys != Keys.Control)
            {
                // Проверяем время после последнего движения мыши
                TimeSpan elapsedTime = DateTime.Now - lastMouseMoveTime;
                if (elapsedTime.TotalMilliseconds > 50) // Проверьте и измените это значение по мере необходимости
                {
                    int offsetX = e.X - lastpoint_2.X;
                    int offsetY = e.Y - lastpoint_2.Y;

                    this.Left = this.Left + offsetX;
                    this.Top = this.Top + offsetY;

                    lastMouseMoveTime = DateTime.Now; // Обновляем время последнего движения мыши
                }
            }
        }

        private void AvtorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint_1 = new Point(e.X, e.Y);
        }

        Point lastpoint_2;

        private DateTime lastMouseMoveTime;

        private void AvtPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Control.ModifierKeys != Keys.Control)
            {
                // Проверяем время после последнего движения мыши
                TimeSpan elapsedTime = DateTime.Now - lastMouseMoveTime;
                if (elapsedTime.TotalMilliseconds > 50) // Проверьте и измените это значение по мере необходимости
                {
                    int offsetX = e.X - lastpoint_2.X;
                    int offsetY = e.Y - lastpoint_2.Y;

                    this.Left = this.Left + offsetX;
                    this.Top = this.Top + offsetY;

                    lastMouseMoveTime = DateTime.Now; // Обновляем время последнего движения мыши
                }
            }
        }

        private void AvtPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint_2 = new Point(e.X, e.Y);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            String LoginUser = LoginField.Text;
            String PasswordUser = PasswordField.Text;
            String EmailUser = EmailField.Text;

            DataBase database = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter Adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users  WHERE login = @uL AND password = @uP AND email = @uE", database.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PasswordUser;
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = EmailUser;

            Adapter.SelectCommand = command;
            Adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataRow firstRow = table.Rows[0];
                string emailFromDatabase = firstRow["email"].ToString();
                string passwordFromDatabase = firstRow["password"].ToString();
                string loginUserFromDatabase = firstRow["login"].ToString();

                if (EmailUser == emailFromDatabase && PasswordUser == passwordFromDatabase && LoginUser == loginUserFromDatabase)
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Повторите авторизацию");
                }
            }
            else
            {
                MessageBox.Show("Повторите авторизацию");
            }
        }

        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (EmailField.Text == "Введите email")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.Black;
            }
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (EmailField.Text == "")
            {
                EmailField.Text = "Введите email";
                EmailField.ForeColor = Color.Gray;
            }
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Введите логин";
                LoginField.ForeColor = Color.Gray;
            }
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
