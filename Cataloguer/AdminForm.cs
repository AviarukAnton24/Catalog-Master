using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cataloguer
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            SearchField.Text = "Найти пользователя";
            SearchField.ForeColor = Color.Gray;

            System.Windows.Forms.Button AddButton = new System.Windows.Forms.Button();

            AddButton.Text = "AddButton";
            AddButton.Text = "Добавить";
            AddButton.ForeColor = Color.White;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Cursor = Cursors.Hand;
            AddButton.BackgroundImageLayout = ImageLayout.Tile;
            AddButton.BackColor = Color.FromArgb(3, 10, 103);
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            AddButton.TextAlign = ContentAlignment.MiddleCenter;
            AddButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            AddButton.Size = new Size(126, 37);
            AddButton.Visible = true;
            AddButton.Location = new Point(15,250);

            // Добавление обработчика события нажатия на кнопку сохранения товара
            AddButton.Click += AddButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(AddButton);

            System.Windows.Forms.Button RemoveButton = new System.Windows.Forms.Button();

            RemoveButton.Text = "RemoveButtton";
            RemoveButton.Text = "Удалить";
            RemoveButton.ForeColor = Color.White;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Cursor = Cursors.Hand;
            RemoveButton.BackgroundImageLayout = ImageLayout.Tile;
            RemoveButton.BackColor = Color.FromArgb(3, 10, 103);
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            RemoveButton.TextAlign = ContentAlignment.MiddleCenter;
            RemoveButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            RemoveButton.Size = new Size(126, 37);
            RemoveButton.Visible = true;
            RemoveButton.Location = new Point(165, 250);

            // Добавление обработчика события нажатия на кнопку сохранения товара
            RemoveButton.Click += RemoveButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(RemoveButton);

            System.Windows.Forms.Button SaveButton = new System.Windows.Forms.Button();

            SaveButton.Text = "SaveButton";
            SaveButton.Text = "Сохранить";
            SaveButton.ForeColor = Color.White;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.BackgroundImageLayout = ImageLayout.Tile;
            SaveButton.BackColor = Color.FromArgb(3, 10, 103);
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            SaveButton.TextAlign = ContentAlignment.MiddleCenter;
            SaveButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            SaveButton.Size = new Size(126, 37);
            SaveButton.Visible = true;
            SaveButton.Location = new Point(315, 250);

            // Добавление обработчика события нажатия на кнопку сохранения товара
            SaveButton.Click += SaveButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(SaveButton);

            System.Windows.Forms.Button ComeBackButton = new System.Windows.Forms.Button();

            ComeBackButton.Text = "ComeBackButtton";
            ComeBackButton.Text = "Вернуться обратно";
            ComeBackButton.ForeColor = Color.White;
            ComeBackButton.FlatStyle = FlatStyle.Flat;
            ComeBackButton.Cursor = Cursors.Hand;
            ComeBackButton.BackgroundImageLayout = ImageLayout.Tile;
            ComeBackButton.BackColor = Color.FromArgb(3, 10, 103);
            ComeBackButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ComeBackButton.TextAlign = ContentAlignment.MiddleCenter;
            ComeBackButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            ComeBackButton.Size = new Size(206, 37);
            ComeBackButton.Visible = true;
            ComeBackButton.Location = new Point(15, 380);

            // Добавление обработчика события нажатия на кнопку сохранения товара
            ComeBackButton.Click += ComeBackButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(ComeBackButton);

            System.Windows.Forms.Button GoToWareHouseButton = new System.Windows.Forms.Button();

            GoToWareHouseButton.Text = "GoToWareHouseButton";
            GoToWareHouseButton.Text = "Перейти на склад";
            GoToWareHouseButton.ForeColor = Color.White;
            GoToWareHouseButton.FlatStyle = FlatStyle.Flat;
            GoToWareHouseButton.Cursor = Cursors.Hand;
            GoToWareHouseButton.BackgroundImageLayout = ImageLayout.Tile;
            GoToWareHouseButton.BackColor = Color.FromArgb(3, 10, 103);
            GoToWareHouseButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            GoToWareHouseButton.TextAlign = ContentAlignment.MiddleCenter;
            GoToWareHouseButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            GoToWareHouseButton.Size = new Size(206, 37);
            GoToWareHouseButton.Visible = true;
            GoToWareHouseButton.Location = new Point(255, 380);

            // Добавление обработчика события нажатия на кнопку сохранения товара
            GoToWareHouseButton.Click += GoToWareHouseButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(GoToWareHouseButton);

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы
            string query = "SELECT * FROM users";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в DataGridView
                    dataGridView1.Columns.Clear();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Изменяем стиль ячеек в DataGridView
                    dataGridView1.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в DataGridView
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.HeaderCell.Style.BackColor = Color.LightBlue; // Голубой цвет фона названия столбца
                        column.HeaderCell.Style.ForeColor = Color.Black; // Черный цвет текста названия столбца
                        column.HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль
                    }

                    // Читаем данные и добавляем их в DataGridView
                    while (reader.Read())
                    {
                        // Создаем массив объектов для хранения значений полей в текущей строке
                        object[] values = new object[reader.FieldCount];

                        // Заполняем массив значениями полей в текущей строке
                        reader.GetValues(values);

                        // Добавляем массив значений как новую строку в DataGridView
                        dataGridView1.Rows.Add(values);
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void GoToWareHouseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            WareHouseForm WareHouseForm = new WareHouseForm();
            WareHouseForm.Show();
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
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

        private void SearchText_Enter(object sender, EventArgs e)
        {
            if (SearchField.Text == "Найти пользователя")
            {
                SearchField.Text = "";
                SearchField.ForeColor = Color.Black;
            }
        }

        private void SearchText_Leave(object sender, EventArgs e)
        {
            if (SearchField.Text == "")
            {
                SearchField.Text = "Найти пользователя";
                SearchField.ForeColor = Color.Gray;
            }
        }

        private void ChangeSearchField(string searchString)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы, где login содержит заданный поисковый запрос
            string query = "SELECT * FROM users WHERE BINARY login LIKE @searchString";

            // Создаем команду SQL с использованием подготовленного запроса
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                command.Parameters.Add("@searchString", MySqlDbType.VarChar).Value = "%" + searchString + "%";

                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы и выделение в DataGridView
                    dataGridView1.Columns.Clear();
                    dataGridView1.ClearSelection();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Заполняем DataGridView данными из таблицы
                    while (reader.Read())
                    {
                        // Создаем массив объектов для хранения значений полей в текущей строке
                        object[] values = new object[reader.FieldCount];

                        // Заполняем массив значениями полей в текущей строке
                        reader.GetValues(values);

                        // Добавляем массив значений как новую строку в DataGridView
                        int rowIndex = dataGridView1.Rows.Add(values);

                        // Получаем логин пользователя из текущей строки
                        string login = reader["login"].ToString();
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            string searchString = SearchField.Text;

            if (!string.IsNullOrEmpty(searchString))
            {
                ChangeSearchField(searchString);
            }
            else
            {
                // Обновите DataGridView без фильтрации, чтобы загрузить все данные из базы данных
                RefreshDataGridView();
            }
        }

        private void RefreshDataGridView()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы
            string query = "SELECT * FROM users";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в DataGridView
                    dataGridView1.Columns.Clear();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Изменяем стиль ячеек в DataGridView
                    dataGridView1.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в DataGridView
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.HeaderCell.Style.BackColor = Color.LightBlue; // Голубой цвет фона названия столбца
                        column.HeaderCell.Style.ForeColor = Color.Black; // Черный цвет текста названия столбца
                        column.HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль
                    }

                    // Читаем данные и добавляем их в DataGridView
                    while (reader.Read())
                    {
                        // Создаем массив объектов для хранения значений полей в текущей строке
                        object[] values = new object[reader.FieldCount];

                        // Заполняем массив значениями полей в текущей строке
                        reader.GetValues(values);

                        // Добавляем массив значений как новую строку в DataGridView
                        dataGridView1.Rows.Add(values);
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;
            string selectedCriteria = checkBox.Text;

            if (checkBox.Checked)
            {
                if (IsOnlyOneCheckBoxChecked())
                {
                    switch (selectedCriteria)
                    {
                        case "Логину":
                            SortByLogin();
                            break;
                        case "Паролю":
                            SortByPassword();
                            break;
                        case "Почте":
                            SortByEmail();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите только один критерий", "Ошибка");
                    checkBox.Checked = false;
                }
            }
            else
            {
                if (!IsAnyCheckBoxChecked())
                {
                    // Обновляем таблицу и отображаем все данные из базы данных
                    RefreshDataGridView();
                }
            }
        }

        private bool IsOnlyOneCheckBoxChecked()
        {
            int checkedCount = 0;

            foreach (System.Windows.Forms.CheckBox checkBox in GroupBox.Controls.OfType<System.Windows.Forms.CheckBox>())
            {
                if (checkBox.Checked)
                {
                    checkedCount++;

                    if (checkedCount > 1)
                        return false;
                }
            }

            return checkedCount == 1;
        }

        private bool IsAnyCheckBoxChecked()
        {
            foreach (System.Windows.Forms.CheckBox checkBox in GroupBox.Controls.OfType<System.Windows.Forms.CheckBox>())
            {
                if (checkBox.Checked)
                {
                    return true;
                }
            }

            return false;
        }

        private void SortByLogin()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            string query = "SELECT * FROM users ORDER BY login ASC";
            ExecuteQueryAndUpdateDataGridView(query);

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void SortByPassword()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();
            
            string query = "SELECT * FROM users ORDER BY password DESC";
            ExecuteQueryAndUpdateDataGridView(query);

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void SortByEmail()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            string query = "SELECT * FROM users ORDER BY email DESC";
            ExecuteQueryAndUpdateDataGridView(query);

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void ExecuteQueryAndUpdateDataGridView(string query)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в DataGridView
                    dataGridView1.Columns.Clear();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Изменяем стиль ячеек в DataGridView
                    dataGridView1.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в DataGridView
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.HeaderCell.Style.BackColor = Color.LightBlue; // Голубой цвет фона названия столбца
                        column.HeaderCell.Style.ForeColor = Color.Black; // Черный цвет текста названия столбца
                        column.HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль
                    }

                    // Читаем данные и добавляем их в DataGridView
                    while (reader.Read())
                    {
                        // Создаем массив объектов для хранения значений полей в текущей строке
                        object[] values = new object[reader.FieldCount];

                        // Заполняем массив значениями полей в текущей строке
                        reader.GetValues(values);

                        // Добавляем массив значений как новую строку в DataGridView
                        dataGridView1.Rows.Add(values);
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }
        bool isElementsCreated = false; // Флаг, указывающий, созданы ли элементы

        System.Windows.Forms.Button AddUserButton;

        System.Windows.Forms.Label LoginLabel;
        System.Windows.Forms.TextBox LoginField;

        System.Windows.Forms.Label PasswordLabel;
        System.Windows.Forms.TextBox PasswordField;

        System.Windows.Forms.Label EmailLabel;
        System.Windows.Forms.TextBox EmailField;

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Проверяем, созданы ли элементы
            if (!isElementsCreated)
            {
                AddUserButton = new System.Windows.Forms.Button();

                AddUserButton.Name = "AddUserButton";
                AddUserButton.Text = "Добавить User";
                AddUserButton.ForeColor = Color.White;
                AddUserButton.FlatStyle = FlatStyle.Flat;
                AddUserButton.Cursor = Cursors.Hand;
                AddUserButton.BackgroundImageLayout = ImageLayout.Tile;
                AddUserButton.BackColor = Color.FromArgb(3, 10, 103);
                AddUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                AddUserButton.TextAlign = ContentAlignment.MiddleCenter;
                AddUserButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                AddUserButton.Size = new Size(126, 67);
                AddUserButton.Visible = true;
                AddUserButton.Location = new Point(15, 300);

                // Добавление обработчика события нажатия на кнопку сохранения товара
                AddUserButton.Click += AddUserButton_Click;

                // Добавление кнопки на форму
                AvtorPanel.Controls.Add(AddUserButton);

                LoginLabel = new System.Windows.Forms.Label();

                LoginLabel.Name = "LoginLabel";
                LoginLabel.Text = "Логин:";
                LoginLabel.BorderStyle = BorderStyle.None;
                LoginLabel.ForeColor = Color.White;
                LoginLabel.FlatStyle = FlatStyle.Flat;
                LoginLabel.Cursor = Cursors.Hand;
                LoginLabel.BackgroundImageLayout = ImageLayout.Tile;
                LoginLabel.BackColor = Color.FromArgb(128, 57, 30);
                LoginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                LoginLabel.TextAlign = ContentAlignment.MiddleCenter;
                LoginLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                LoginLabel.Size = new Size(80, 37);
                LoginLabel.Visible = true;
                LoginLabel.Location = new Point(620, 18);

                // Добавление label на форму
                AvtorPanel.Controls.Add(LoginLabel);

                LoginField = new System.Windows.Forms.TextBox();

                LoginField.Name = "LoginField";
                LoginField.BorderStyle = BorderStyle.None;
                LoginField.ForeColor = Color.Black;
                LoginField.Cursor = Cursors.IBeam;
                LoginField.BackgroundImageLayout = ImageLayout.Tile;
                LoginField.BackColor = Color.White;
                LoginField.Anchor = AnchorStyles.Top;
                LoginField.TextAlign = HorizontalAlignment.Center;
                LoginField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                LoginField.Size = new Size(180, 57);
                LoginField.Visible = true;
                LoginField.Location = new Point(650, 24);

                // Добавление label на форму
                AvtorPanel.Controls.Add(LoginField);

                PasswordLabel = new System.Windows.Forms.Label();

                PasswordLabel.Name = "PasswordLabel";
                PasswordLabel.Text = "Пароль:";
                PasswordLabel.BorderStyle = BorderStyle.None;
                PasswordLabel.ForeColor = Color.White;
                PasswordLabel.FlatStyle = FlatStyle.Flat;
                PasswordLabel.Cursor = Cursors.Hand;
                PasswordLabel.BackgroundImageLayout = ImageLayout.Tile;
                PasswordLabel.BackColor = Color.FromArgb(128, 57, 30);
                PasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
                PasswordLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PasswordLabel.Size = new Size(80, 37);
                PasswordLabel.Visible = true;
                PasswordLabel.Location = new Point(620, 58);

                // Добавление label на форму
                AvtorPanel.Controls.Add(PasswordLabel);

                PasswordField = new System.Windows.Forms.TextBox();

                PasswordField.Name = "PasaswordField";
                PasswordField.BorderStyle = BorderStyle.None;
                PasswordField.ForeColor = Color.Black;
                PasswordField.Cursor = Cursors.IBeam;
                PasswordField.BackgroundImageLayout = ImageLayout.Tile;
                PasswordField.BackColor = Color.White;
                PasswordField.Anchor = AnchorStyles.Top;
                PasswordField.TextAlign = HorizontalAlignment.Center;
                PasswordField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PasswordField.Size = new Size(180, 57);
                PasswordField.Visible = true;
                PasswordField.Location = new Point(650, 64);

                AvtorPanel.Controls.Add(PasswordField);

                EmailLabel = new System.Windows.Forms.Label();

                EmailLabel.Name = "EmailLabel";
                EmailLabel.Text = "Email:";
                EmailLabel.BorderStyle = BorderStyle.None;
                EmailLabel.ForeColor = Color.White;
                EmailLabel.FlatStyle = FlatStyle.Flat;
                EmailLabel.Cursor = Cursors.Hand;
                EmailLabel.BackgroundImageLayout = ImageLayout.Tile;
                EmailLabel.BackColor = Color.FromArgb(128, 57, 30);
                EmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                EmailLabel.TextAlign = ContentAlignment.MiddleCenter;
                EmailLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                EmailLabel.Size = new Size(80, 37);
                EmailLabel.Visible = true;
                EmailLabel.Location = new Point(620, 98);

                // Добавление label на форму
                AvtorPanel.Controls.Add(EmailLabel);

                EmailField = new System.Windows.Forms.TextBox();

                EmailField.Name = "EmailField";
                EmailField.BorderStyle = BorderStyle.None;
                EmailField.ForeColor = Color.Black;
                EmailField.Cursor = Cursors.IBeam;
                EmailField.BackgroundImageLayout = ImageLayout.Tile;
                EmailField.BackColor = Color.White;
                EmailField.Anchor = AnchorStyles.Top;
                EmailField.TextAlign = HorizontalAlignment.Center;
                EmailField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                EmailField.Size = new Size(180, 57);
                EmailField.Visible = true;
                EmailField.Location = new Point(650, 104);

                AvtorPanel.Controls.Add(EmailField);
                // Устанавливаем флаг, что элементы были созданы
                isElementsCreated = true;
            }
            else
            {
                // Если элементы уже созданы, делаем их невидимыми
                AddUserButton.Visible = false;

                LoginLabel.Visible = false;
                LoginField.Visible = false;

                PasswordLabel.Visible = false;
                PasswordField.Visible = false;

                EmailLabel.Visible = false;
                EmailField.Visible = false;

                isElementsCreated = false;
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            string login = LoginField.Text;
            string password = PasswordField.Text;
            string email = EmailField.Text;

            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            // Проверка логина на разрешенные символы и длину
            if (!IsValidLogin(login))
            {
                MessageBox.Show("Использование неразрешенных символов при вводе логина");
                return;
            }
            else if (login.Length < 4)
            {
                MessageBox.Show("Недостаточно символов при вводе логина");
                return;
            }
            else if (login.Length > 8)
            {
                MessageBox.Show("Уменьшите количество символов при вводе логина");
                return;
            }

            // Проверка пароля на разрешенные символы и длину
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Использование неразрешенных символов при вводе пароля");
                return;
            }
            else if (password.Length < 3)
            {
                MessageBox.Show("Недостаточно символов при вводе пароля");
                return;
            }
            else if (password.Length > 8)
            {
                MessageBox.Show("Уменьшите количество символов при вводе пароля");
                return;
            }

            // Проверка email на разрешенные символы и длину
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Использование неразрешенных символов при вводе почты");
                return;
            }
            else if (email.Length < 4)
            {
                MessageBox.Show("Недостаточно символов при вводе почты");
                return;
            }
            else if (email.Length > 20)
            {
                MessageBox.Show("Уменьшите количество символов при вводе почты");
                return;
            }

            // Проверка наличия пользователя в базе данных
            if (IsUserExists(login, password, email))
            {
                MessageBox.Show("Пользователь с таким логином, паролем и почтой уже существует");
                return;
            }

            // Добавление пользователя в базу данных
            AddUserToDatabase(login, password, email);

            // Обновите DataGridView без фильтрации, чтобы загрузить все данные из базы данных
            RefreshDataGridView();

            MessageBox.Show("Пользователь успешно добавлен");
        }

        // Метод для проверки логина на разрешенные символы (английские символы и цифры)
        private bool IsValidLogin(string login)
        {
            foreach (char c in login)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        // Метод для проверки пароля на разрешенные символы (только цифры)
        private bool IsValidPassword(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        // Метод для проверки email на разрешенные символы (английские символы, цифры и знаки препинания)
        private bool IsValidEmail(string email)
        {
            foreach (char c in email)
            {
                if (char.IsLetterOrDigit(c) || char.IsLetter(c) || char.IsDigit(c) || c != '@' || c != '.')
                {
                    return true;
                }
            }
            return false;
        }

        // Метод для проверки наличия пользователя в базе данных
        private bool IsUserExists(string login, string password, string email)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы
            string query = "SELECT COUNT(*) FROM users WHERE login = @login AND password = @password AND email = @email";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Параметры запроса
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);

                // Выполнение запроса и получение количества строк, удовлетворяющих условиям
                object result = command.ExecuteScalar();
                int count = Convert.ToInt32(result);

                // Проверка наличия пользователя
                if (count > 0)
                {
                        return true;
                }

                database.CloseConnection();

                return false;
            }
        }

        // Метод для добавления пользователя в базу данных
        private void AddUserToDatabase(string login, string password, string email)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Получение id последней строки в таблице users
            string getLastIdQuery = "SELECT id FROM users ORDER BY id DESC LIMIT 1";
            int lastId = 0;
            using (MySqlCommand getLastIdCommand = new MySqlCommand(getLastIdQuery, database.GetConnection()))
            {
                object result = getLastIdCommand.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    lastId = Convert.ToInt32(result);
                }
            }

            // Генерация нового id для нового пользователя
            int newId = lastId + 1;

            // Создание запроса к базе данных для добавления нового пользователя
            string query = "INSERT INTO users (id, login, password, email) VALUES (@id, @login, @password, @email)";
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Параметры запроса
                command.Parameters.AddWithValue("@id", newId);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);

                // Выполнение запроса для добавления нового пользователя в базу данных
                command.ExecuteNonQuery();
            }

            database.CloseConnection();
        }

        System.Windows.Forms.Button RemoveUserButton;

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Проверяем, созданы ли элементы
            if (!isElementsCreated)
            {
                RemoveUserButton = new System.Windows.Forms.Button();

                RemoveUserButton.Name = "RemoveUserButton";
                RemoveUserButton.Text = "Удалить User";
                RemoveUserButton.ForeColor = Color.White;
                RemoveUserButton.FlatStyle = FlatStyle.Flat;
                RemoveUserButton.Cursor = Cursors.Hand;
                RemoveUserButton.BackgroundImageLayout = ImageLayout.Tile;
                RemoveUserButton.BackColor = Color.FromArgb(3, 10, 103);
                RemoveUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                RemoveUserButton.TextAlign = ContentAlignment.MiddleCenter;
                RemoveUserButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                RemoveUserButton.Size = new Size(126, 67);
                RemoveUserButton.Visible = true;
                RemoveUserButton.Location = new Point(165, 300);

                // Добавление обработчика события нажатия на кнопку сохранения товара
                RemoveUserButton.Click += RemoveUserButton_Click;

                // Добавление кнопки на форму
                AvtorPanel.Controls.Add(RemoveUserButton);

                LoginLabel = new System.Windows.Forms.Label();

                LoginLabel.Name = "LoginLabel";
                LoginLabel.Text = "Логин:";
                LoginLabel.BorderStyle = BorderStyle.None;
                LoginLabel.ForeColor = Color.White;
                LoginLabel.FlatStyle = FlatStyle.Flat;
                LoginLabel.Cursor = Cursors.Hand;
                LoginLabel.BackgroundImageLayout = ImageLayout.Tile;
                LoginLabel.BackColor = Color.FromArgb(128, 57, 30);
                LoginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                LoginLabel.TextAlign = ContentAlignment.MiddleCenter;
                LoginLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                LoginLabel.Size = new Size(80, 37);
                LoginLabel.Visible = true;
                LoginLabel.Location = new Point(620, 18);

                // Добавление label на форму
                AvtorPanel.Controls.Add(LoginLabel);

                LoginField = new System.Windows.Forms.TextBox();

                LoginField.Name = "LoginField";
                LoginField.BorderStyle = BorderStyle.None;
                LoginField.ForeColor = Color.Black;
                LoginField.Cursor = Cursors.IBeam;
                LoginField.BackgroundImageLayout = ImageLayout.Tile;
                LoginField.BackColor = Color.White;
                LoginField.Anchor = AnchorStyles.Top;
                LoginField.TextAlign = HorizontalAlignment.Center;
                LoginField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                LoginField.Size = new Size(180, 57);
                LoginField.Visible = true;
                LoginField.Location = new Point(650, 24);

                // Добавление label на форму
                AvtorPanel.Controls.Add(LoginField);

                PasswordLabel = new System.Windows.Forms.Label();

                PasswordLabel.Name = "PasswordLabel";
                PasswordLabel.Text = "Пароль:";
                PasswordLabel.BorderStyle = BorderStyle.None;
                PasswordLabel.ForeColor = Color.White;
                PasswordLabel.FlatStyle = FlatStyle.Flat;
                PasswordLabel.Cursor = Cursors.Hand;
                PasswordLabel.BackgroundImageLayout = ImageLayout.Tile;
                PasswordLabel.BackColor = Color.FromArgb(128, 57, 30);
                PasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
                PasswordLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PasswordLabel.Size = new Size(80, 37);
                PasswordLabel.Visible = true;
                PasswordLabel.Location = new Point(620, 58);

                // Добавление label на форму
                AvtorPanel.Controls.Add(PasswordLabel);

                PasswordField = new System.Windows.Forms.TextBox();

                PasswordField.Name = "PasaswordField";
                PasswordField.BorderStyle = BorderStyle.None;
                PasswordField.ForeColor = Color.Black;
                PasswordField.Cursor = Cursors.IBeam;
                PasswordField.BackgroundImageLayout = ImageLayout.Tile;
                PasswordField.BackColor = Color.White;
                PasswordField.Anchor = AnchorStyles.Top;
                PasswordField.TextAlign = HorizontalAlignment.Center;
                PasswordField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PasswordField.Size = new Size(180, 57);
                PasswordField.Visible = true;
                PasswordField.Location = new Point(650, 64);

                AvtorPanel.Controls.Add(PasswordField);

                EmailLabel = new System.Windows.Forms.Label();

                EmailLabel.Name = "EmailLabel";
                EmailLabel.Text = "Email:";
                EmailLabel.BorderStyle = BorderStyle.None;
                EmailLabel.ForeColor = Color.White;
                EmailLabel.FlatStyle = FlatStyle.Flat;
                EmailLabel.Cursor = Cursors.Hand;
                EmailLabel.BackgroundImageLayout = ImageLayout.Tile;
                EmailLabel.BackColor = Color.FromArgb(128, 57, 30);
                EmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                EmailLabel.TextAlign = ContentAlignment.MiddleCenter;
                EmailLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                EmailLabel.Size = new Size(80, 37);
                EmailLabel.Visible = true;
                EmailLabel.Location = new Point(620, 98);

                // Добавление label на форму
                AvtorPanel.Controls.Add(EmailLabel);

                EmailField = new System.Windows.Forms.TextBox();

                EmailField.Name = "EmailField";
                EmailField.BorderStyle = BorderStyle.None;
                EmailField.ForeColor = Color.Black;
                EmailField.Cursor = Cursors.IBeam;
                EmailField.BackgroundImageLayout = ImageLayout.Tile;
                EmailField.BackColor = Color.White;
                EmailField.Anchor = AnchorStyles.Top;
                EmailField.TextAlign = HorizontalAlignment.Center;
                EmailField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                EmailField.Size = new Size(180, 57);
                EmailField.Visible = true;
                EmailField.Location = new Point(650, 104);

                AvtorPanel.Controls.Add(EmailField);
                // Устанавливаем флаг, что элементы были созданы
                isElementsCreated = true;
            }
            else
            {
                // Если элементы уже созданы, делаем их невидимыми
                RemoveUserButton.Visible = false;

                LoginLabel.Visible = false;
                LoginField.Visible = false;

                PasswordLabel.Visible = false;
                PasswordField.Visible = false;

                EmailLabel.Visible = false;
                EmailField.Visible = false;

                isElementsCreated = false;
            }
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            string login = LoginField.Text;
            string password = PasswordField.Text;
            string email = EmailField.Text;

            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            // Проверка логина на разрешенные символы и длину
            if (!IsValidLogin(login))
            {
                MessageBox.Show("Использование неразрешенных символов при вводе логина");
                return;
            }
            else if (login.Length < 4)
            {
                MessageBox.Show("Недостаточно символов при вводе логина");
                return;
            }
            else if (login.Length > 8)
            {
                MessageBox.Show("Уменьшите количество символов при вводе логина");
                return;
            }

            // Проверка пароля на разрешенные символы и длину
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Использование неразрешенных символов при вводе пароля");
                return;
            }
            else if (password.Length < 3)
            {
                MessageBox.Show("Недостаточно символов при вводе пароля");
                return;
            }
            else if (password.Length > 8)
            {
                MessageBox.Show("Уменьшите количество символов при вводе пароля");
                return;
            }

            // Проверка email на разрешенные символы и длину
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Использование неразрешенных символов при вводе почты");
                return;
            }
            else if (email.Length < 4)
            {
                MessageBox.Show("Недостаточно символов при вводе почты");
                return;
            }
            else if (email.Length > 20)
            {
                MessageBox.Show("Уменьшите количество символов при вводе почты");
                return;
            }

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Поиск пользователя в базе данных
            bool userFound = false;

            // Запрос для поиска строки с совпадающими данными
            string query = "SELECT * FROM users WHERE login = @login AND password = @password AND email = @email";
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Параметры запроса
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Проверяем, есть ли строки с совпадающими данными
                    if (reader.HasRows)
                    {
                        userFound = true;
                    }
                }
            }

            // Закрываем соединение с базой данных
            database.CloseConnection();

            // Если пользователь не найден, выводим сообщение
            if (!userFound)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            // Удаление пользователя из базы данных
            RemoveUserFromDatabase(login, password, email);

            // Обновите DataGridView без фильтрации, чтобы загрузить все данные из базы данных
            RefreshDataGridView();

            MessageBox.Show("Пользователь успешно удален");
        }

        private void RemoveUserFromDatabase(string login, string password, string email)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создание запроса к базе данных для удаления пользователя
            string query = "DELETE FROM users WHERE login = @login AND password = @password AND email = @email";
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Параметры запроса
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);

                // Выполнение запроса для удаления пользователя из базы данных
                command.ExecuteNonQuery();
            }

            // Закрываем соединение с базой данных
            database.CloseConnection();
        }

        System.Windows.Forms.Button SaveUserButton;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Проверяем, созданы ли элементы
            if (!isElementsCreated)
            {
                SaveUserButton = new System.Windows.Forms.Button();

                SaveUserButton.Text = "Сохранить User";
                SaveUserButton.ForeColor = Color.White;
                SaveUserButton.FlatStyle = FlatStyle.Flat;
                SaveUserButton.Cursor = Cursors.Hand;
                SaveUserButton.BackgroundImageLayout = ImageLayout.Tile;
                SaveUserButton.BackColor = Color.FromArgb(3, 10, 103);
                SaveUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                SaveUserButton.TextAlign = ContentAlignment.MiddleCenter;
                SaveUserButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                SaveUserButton.Size = new Size(126, 67);
                SaveUserButton.Visible = true;
                SaveUserButton.Location = new Point(315, 300);

                // Добавление обработчика события нажатия на кнопку сохранения товара
                SaveUserButton.Click += SaveUserButton_Click;

                // Добавление кнопки на форму
                AvtorPanel.Controls.Add(SaveUserButton);

                LoginLabel = new System.Windows.Forms.Label();

                LoginLabel.Name = "LoginLabel";
                LoginLabel.Text = "Логин:";
                LoginLabel.BorderStyle = BorderStyle.None;
                LoginLabel.ForeColor = Color.White;
                LoginLabel.FlatStyle = FlatStyle.Flat;
                LoginLabel.Cursor = Cursors.Hand;
                LoginLabel.BackgroundImageLayout = ImageLayout.Tile;
                LoginLabel.BackColor = Color.FromArgb(128, 57, 30);
                LoginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                LoginLabel.TextAlign = ContentAlignment.MiddleCenter;
                LoginLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                LoginLabel.Size = new Size(80, 37);
                LoginLabel.Visible = true;
                LoginLabel.Location = new Point(620, 18);

                // Добавление label на форму
                AvtorPanel.Controls.Add(LoginLabel);

                LoginField = new System.Windows.Forms.TextBox();

                LoginField.Name = "LoginField";
                LoginField.BorderStyle = BorderStyle.None;
                LoginField.ForeColor = Color.Black;
                LoginField.Cursor = Cursors.IBeam;
                LoginField.BackgroundImageLayout = ImageLayout.Tile;
                LoginField.BackColor = Color.White;
                LoginField.Anchor = AnchorStyles.Top;
                LoginField.TextAlign = HorizontalAlignment.Center;
                LoginField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                LoginField.Size = new Size(180, 57);
                LoginField.Visible = true;
                LoginField.Location = new Point(650, 24);

                // Добавление label на форму
                AvtorPanel.Controls.Add(LoginField);

                PasswordLabel = new System.Windows.Forms.Label();

                PasswordLabel.Name = "PasswordLabel";
                PasswordLabel.Text = "Пароль:";
                PasswordLabel.BorderStyle = BorderStyle.None;
                PasswordLabel.ForeColor = Color.White;
                PasswordLabel.FlatStyle = FlatStyle.Flat;
                PasswordLabel.Cursor = Cursors.Hand;
                PasswordLabel.BackgroundImageLayout = ImageLayout.Tile;
                PasswordLabel.BackColor = Color.FromArgb(128, 57, 30);
                PasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
                PasswordLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PasswordLabel.Size = new Size(80, 37);
                PasswordLabel.Visible = true;
                PasswordLabel.Location = new Point(620, 58);

                // Добавление label на форму
                AvtorPanel.Controls.Add(PasswordLabel);

                PasswordField = new System.Windows.Forms.TextBox();

                PasswordField.Name = "PasaswordField";
                PasswordField.BorderStyle = BorderStyle.None;
                PasswordField.ForeColor = Color.Black;
                PasswordField.Cursor = Cursors.IBeam;
                PasswordField.BackgroundImageLayout = ImageLayout.Tile;
                PasswordField.BackColor = Color.White;
                PasswordField.Anchor = AnchorStyles.Top;
                PasswordField.TextAlign = HorizontalAlignment.Center;
                PasswordField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PasswordField.Size = new Size(180, 57);
                PasswordField.Visible = true;
                PasswordField.Location = new Point(650, 64);

                AvtorPanel.Controls.Add(PasswordField);

                EmailLabel = new System.Windows.Forms.Label();

                EmailLabel.Name = "EmailLabel";
                EmailLabel.Text = "Email:";
                EmailLabel.BorderStyle = BorderStyle.None;
                EmailLabel.ForeColor = Color.White;
                EmailLabel.FlatStyle = FlatStyle.Flat;
                EmailLabel.Cursor = Cursors.Hand;
                EmailLabel.BackgroundImageLayout = ImageLayout.Tile;
                EmailLabel.BackColor = Color.FromArgb(128, 57, 30);
                EmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                EmailLabel.TextAlign = ContentAlignment.MiddleCenter;
                EmailLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                EmailLabel.Size = new Size(80, 37);
                EmailLabel.Visible = true;
                EmailLabel.Location = new Point(620, 98);

                // Добавление label на форму
                AvtorPanel.Controls.Add(EmailLabel);

                EmailField = new System.Windows.Forms.TextBox();

                EmailField.Name = "EmailField";
                EmailField.BorderStyle = BorderStyle.None;
                EmailField.ForeColor = Color.Black;
                EmailField.Cursor = Cursors.IBeam;
                EmailField.BackgroundImageLayout = ImageLayout.Tile;
                EmailField.BackColor = Color.White;
                EmailField.Anchor = AnchorStyles.Top;
                EmailField.TextAlign = HorizontalAlignment.Center;
                EmailField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                EmailField.Size = new Size(180, 57);
                EmailField.Visible = true;
                EmailField.Location = new Point(650, 104);

                AvtorPanel.Controls.Add(EmailField);
                // Устанавливаем флаг, что элементы были созданы
                isElementsCreated = true;
            }
            else
            {
                // Если элементы уже созданы, делаем их невидимыми
                SaveUserButton.Visible = false;

                LoginLabel.Visible = false;
                LoginField.Visible = false;

                PasswordLabel.Visible = false;
                PasswordField.Visible = false;

                EmailLabel.Visible = false;
                EmailField.Visible = false;

                isElementsCreated = false;
            }
        }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {
            string login = LoginField.Text;
            string password = PasswordField.Text;
            string email = EmailField.Text;

            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            // Проверка логина на разрешенные символы и длину
            if (!IsValidLogin(login))
            {
                MessageBox.Show("Использование неразрешенных символов при вводе логина");
                return;
            }
            else if (login.Length < 4)
            {
                MessageBox.Show("Недостаточно символов при вводе логина");
                return;
            }
            else if (login.Length > 8)
            {
                MessageBox.Show("Уменьшите количество символов при вводе логина");
                return;
            }

            // Проверка пароля на разрешенные символы и длину
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Использование неразрешенных символов при вводе пароля");
                return;
            }
            else if (password.Length < 3)
            {
                MessageBox.Show("Недостаточно символов при вводе пароля");
                return;
            }
            else if (password.Length > 8)
            {
                MessageBox.Show("Уменьшите количество символов при вводе пароля");
                return;
            }

            // Проверка email на разрешенные символы и длину
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Использование неразрешенных символов при вводе почты");
                return;
            }
            else if (email.Length < 4)
            {
                MessageBox.Show("Недостаточно символов при вводе почты");
                return;
            }
            else if (email.Length > 20)
            {
                MessageBox.Show("Уменьшите количество символов при вводе почты");
                return;
            }

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            bool userFound = false;

            // Запрос для поиска строки с совпадающим логином
            string query = "SELECT * FROM users WHERE login = @login";
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Параметры запроса
                command.Parameters.AddWithValue("@login", login);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Проверяем, есть ли строки с совпадающим логином
                    if (reader.HasRows)
                    {
                        userFound = true;

                        // Закрываем DataReader
                        reader.Close();

                        // Обновление строки с совпадающим логином
                        string updateQuery = "UPDATE users SET password = @password, email = @email WHERE login = @login";
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, database.GetConnection()))
                        {
                            // Параметры запроса
                            updateCommand.Parameters.AddWithValue("@password", password);
                            updateCommand.Parameters.AddWithValue("@email", email);
                            updateCommand.Parameters.AddWithValue("@login", login);

                            // Выполнение запроса для обновления данных пользователя
                            updateCommand.ExecuteNonQuery();
                        }

                    }
                }
            }

            // Если пользователь не найден, выводим сообщение
            if (!userFound)
            {
                MessageBox.Show("Пользователь не найден");

                // Добавление пользователя в базу данных
                AddUserToDatabase(login, password, email);

                // Обновите DataGridView без фильтрации, чтобы загрузить все данные из базы данных
                RefreshDataGridView();

                MessageBox.Show("Пользователь успешно добавлен");

                // Закрываем соединение с базой данных
                database.CloseConnection();

                return;
            }

            // Обновление DataGridView без фильтрации, чтобы загрузить все данные из базы данных
            RefreshDataGridView();

            MessageBox.Show("Данные пользователя были успешно изменены");

            // Закрываем соединение с базой данных
            database.CloseConnection();
        }
    }
}