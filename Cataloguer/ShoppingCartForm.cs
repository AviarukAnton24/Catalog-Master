using Cataloguer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Cataloguer
{
    public partial class ShoppingCartForm : Form
    {
        public ShoppingCartForm()
        {
            InitializeComponent();

            WareHouseSearchField.Text = "Найти товар";
            WareHouseSearchField.ForeColor = Color.Gray;

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
            AddButton.Location = new Point(15, 310);

            // Добавление обработчика события нажатия на кнопку добавления товара
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
            RemoveButton.Location = new Point(165, 310);

            // Добавление обработчика события нажатия на кнопку удаления товара
            RemoveButton.Click += RemoveButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(RemoveButton);

            System.Windows.Forms.Button ClearButton = new System.Windows.Forms.Button();

            ClearButton.Text = "ClearButton";
            ClearButton.Text = "Очистить";
            ClearButton.ForeColor = Color.White;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.BackgroundImageLayout = ImageLayout.Tile;
            ClearButton.BackColor = Color.FromArgb(3, 10, 103);
            ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ClearButton.TextAlign = ContentAlignment.MiddleCenter;
            ClearButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            ClearButton.Size = new Size(126, 37);
            ClearButton.Visible = true;
            ClearButton.Location = new Point(315, 310);

            // Добавление обработчика события нажатия на кнопку очистить товар
            ClearButton.Click += ClearButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(ClearButton);

            System.Windows.Forms.Button ClearShoppingCartButton = new System.Windows.Forms.Button();

            ClearShoppingCartButton.Text = "ClearShoppingCartButton";
            ClearShoppingCartButton.Text = "Очистить корзину";
            ClearShoppingCartButton.ForeColor = Color.White;
            ClearShoppingCartButton.FlatStyle = FlatStyle.Flat;
            ClearShoppingCartButton.Cursor = Cursors.Hand;
            ClearShoppingCartButton.BackgroundImageLayout = ImageLayout.Tile;
            ClearShoppingCartButton.BackColor = Color.FromArgb(3, 10, 103);
            ClearShoppingCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ClearShoppingCartButton.TextAlign = ContentAlignment.MiddleCenter;
            ClearShoppingCartButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            ClearShoppingCartButton.Size = new Size(126, 57);
            ClearShoppingCartButton.Visible = true;
            ClearShoppingCartButton.Location = new Point(465, 310);

            // Добавление обработчика события нажатия на кнопку очистить товар
            ClearShoppingCartButton.Click += ClearShoppingCartButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(ClearShoppingCartButton);

            System.Windows.Forms.Button OptionsCartButton = new System.Windows.Forms.Button();

            OptionsCartButton.Text = "OptionsCartButtton";
            OptionsCartButton.Text = "Параметры корзины";
            OptionsCartButton.ForeColor = Color.White;
            OptionsCartButton.FlatStyle = FlatStyle.Flat;
            OptionsCartButton.Cursor = Cursors.Hand;
            OptionsCartButton.BackgroundImageLayout = ImageLayout.Tile;
            OptionsCartButton.BackColor = Color.FromArgb(3, 10, 103);
            OptionsCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            OptionsCartButton.TextAlign = ContentAlignment.MiddleCenter;
            OptionsCartButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            OptionsCartButton.Size = new Size(156, 57);
            OptionsCartButton.Visible = true;
            OptionsCartButton.Location = new Point(775, 310);
            
            OptionsCartButton.Click += OptionsCartButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(OptionsCartButton);

            System.Windows.Forms.Button PayCartButton = new System.Windows.Forms.Button();

            PayCartButton.Text = "PayCartButtton";
            PayCartButton.Text = "Оплатить корзину";
            PayCartButton.ForeColor = Color.White;
            PayCartButton.FlatStyle = FlatStyle.Flat;
            PayCartButton.Cursor = Cursors.Hand;
            PayCartButton.BackgroundImageLayout = ImageLayout.Tile;
            PayCartButton.BackColor = Color.FromArgb(3, 10, 103);
            PayCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            PayCartButton.TextAlign = ContentAlignment.MiddleCenter;
            PayCartButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            PayCartButton.Size = new Size(156, 57);
            PayCartButton.Visible = true;
            PayCartButton.Location = new Point(945, 310);

            PayCartButton.Click += PayCartButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(PayCartButton);

            System.Windows.Forms.Button ComeBackButton = new System.Windows.Forms.Button();

            ComeBackButton.Text = "ComeBackButtton";
            ComeBackButton.Text = "Вернуться на авторизацию";
            ComeBackButton.ForeColor = Color.White;
            ComeBackButton.FlatStyle = FlatStyle.Flat;
            ComeBackButton.Cursor = Cursors.Hand;
            ComeBackButton.BackgroundImageLayout = ImageLayout.Tile;
            ComeBackButton.BackColor = Color.FromArgb(3, 10, 103);
            ComeBackButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ComeBackButton.TextAlign = ContentAlignment.MiddleCenter;
            ComeBackButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            ComeBackButton.Size = new Size(306, 37);
            ComeBackButton.Visible = true;
            ComeBackButton.Location = new Point(15, 440);

            ComeBackButton.Click += ComeBackButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(ComeBackButton);

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы
            string query = "SELECT * FROM warehouse";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в DataGridView
                    WareHouseGridView.Columns.Clear();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        WareHouseGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Изменяем стиль ячеек в DataGridView
                    WareHouseGridView.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    WareHouseGridView.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    WareHouseGridView.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в DataGridView
                    foreach (DataGridViewColumn column in WareHouseGridView.Columns)
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
                        WareHouseGridView.Rows.Add(values);
                    }
                }
            }

            // Создаем SQL-запрос для выборки данных из таблицы
            string Query = "SELECT * FROM shopping_cart";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(Query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в DataGridView
                    ShoppingGridView.Columns.Clear();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        ShoppingGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Изменяем стиль ячеек в DataGridView
                    ShoppingGridView.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    ShoppingGridView.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    ShoppingGridView.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в DataGridView
                    foreach (DataGridViewColumn column in ShoppingGridView.Columns)
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
                        ShoppingGridView.Rows.Add(values);
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
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

        private void WareHouseSearchField_Enter(object sender, EventArgs e)
        {
            if (WareHouseSearchField.Text == "Найти товар")
            {
                WareHouseSearchField.Text = "";
                WareHouseSearchField.ForeColor = Color.Black;
            }
        }

        private void WareHouseSearchField_Leave(object sender, EventArgs e)
        {
            if (WareHouseSearchField.Text == "")
            {
                WareHouseSearchField.Text = "Найти товар";
                WareHouseSearchField.ForeColor = Color.Gray;
            }
        }

        private void ChangeWareHouseSearchField(string searchString)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы, где login содержит заданный поисковый запрос
            string query = "SELECT * FROM warehouse WHERE BINARY ProductName LIKE @searchString";

            // Создаем команду SQL с использованием подготовленного запроса
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                command.Parameters.Add("@searchString", MySqlDbType.VarChar).Value = "%" + searchString + "%";

                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы и выделение в DataGridView
                    WareHouseGridView.Columns.Clear();
                    WareHouseGridView.ClearSelection();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        WareHouseGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Заполняем DataGridView данными из таблицы
                    while (reader.Read())
                    {
                        // Создаем массив объектов для хранения значений полей в текущей строке
                        object[] values = new object[reader.FieldCount];

                        // Заполняем массив значениями полей в текущей строке
                        reader.GetValues(values);

                        // Добавляем массив значений как новую строку в DataGridView
                        int rowIndex = WareHouseGridView.Rows.Add(values);

                        // Получаем логин пользователя из текущей строки
                        string login = reader["ProductName"].ToString();
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void WareHouseSearchField_TextChanged(object sender, EventArgs e)
        {
            string searchString = WareHouseSearchField.Text;

            if (!string.IsNullOrEmpty(searchString))
            {
                ChangeWareHouseSearchField(searchString);
            }
            else
            {
                // Обновите DataGridView без фильтрации, чтобы загрузить все данные из базы данных
                RefreshWareHouseGridView();
            }
        }

        private void RefreshWareHouseGridView()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы
            string query = "SELECT * FROM warehouse";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в DataGridView
                    WareHouseGridView.Columns.Clear();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        WareHouseGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Изменяем стиль ячеек в DataGridView
                    WareHouseGridView.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    WareHouseGridView.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    WareHouseGridView.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в DataGridView
                    foreach (DataGridViewColumn column in WareHouseGridView.Columns)
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
                        WareHouseGridView.Rows.Add(values);
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void ShoppingSearchField_Enter(object sender, EventArgs e)
        {
            if (ShoppingSearchField.Text == "Найти товар")
            {
                ShoppingSearchField.Text = "";
                ShoppingSearchField.ForeColor = Color.Black;
            }
        }

        private void ShoppingSearchField_Leave(object sender, EventArgs e)
        {
            if (ShoppingSearchField.Text == "")
            {
                ShoppingSearchField.Text = "Найти товар";
                ShoppingSearchField.ForeColor = Color.Gray;
            }
        }

        private void ChangeShoppingSearchField(string searchString)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы, где login содержит заданный поисковый запрос
            string query = "SELECT * FROM shopping_cart WHERE BINARY ProductName LIKE @searchString";

            // Создаем команду SQL с использованием подготовленного запроса
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                command.Parameters.Add("@searchString", MySqlDbType.VarChar).Value = "%" + searchString + "%";

                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы и выделение в DataGridView
                    ShoppingGridView.Columns.Clear();
                    ShoppingGridView.ClearSelection();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        ShoppingGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Заполняем DataGridView данными из таблицы
                    while (reader.Read())
                    {
                        // Создаем массив объектов для хранения значений полей в текущей строке
                        object[] values = new object[reader.FieldCount];

                        // Заполняем массив значениями полей в текущей строке
                        reader.GetValues(values);

                        // Добавляем массив значений как новую строку в DataGridView
                        int rowIndex = ShoppingGridView.Rows.Add(values);

                        // Получаем название товара из текущей строки
                        string name = reader["ProductName"].ToString();
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void ShoppingSearchField_TextChanged(object sender, EventArgs e)
        {
            string searchString = ShoppingSearchField.Text;

            if (!string.IsNullOrEmpty(searchString))
            {
                ChangeShoppingSearchField(searchString);
            }
            else
            {
                // Обновите DataGridView без фильтрации, чтобы загрузить все данные из базы данных
                RefreshShoppingGridView();
            }
        }

        private void RefreshShoppingGridView()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы
            string query = "SELECT * FROM shopping_cart";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в DataGridView
                    ShoppingGridView.Columns.Clear();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        ShoppingGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Изменяем стиль ячеек в DataGridView
                    ShoppingGridView.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    ShoppingGridView.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    ShoppingGridView.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в DataGridView
                    foreach (DataGridViewColumn column in ShoppingGridView.Columns)
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
                        ShoppingGridView.Rows.Add(values);
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        bool isElementsCreated = false; // Флаг, указывающий, созданы ли элементы

        System.Windows.Forms.Button AddProductButton;

        System.Windows.Forms.Label ProductNameLabel;
        System.Windows.Forms.TextBox ProductNameField;

        System.Windows.Forms.Label QuantityLabel;
        System.Windows.Forms.TextBox QuantityField;

        System.Windows.Forms.Label SizeLabel;
        System.Windows.Forms.TextBox SizeField;

        System.Windows.Forms.Label ManufactureLabel;
        System.Windows.Forms.TextBox ManufactureField;

        System.Windows.Forms.Label PriceLabel;
        System.Windows.Forms.TextBox PriceField;

        System.Windows.Forms.Label SecurityLabel;
        System.Windows.Forms.TextBox SecurityField;

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Проверяем, созданы ли элементы
            if (!isElementsCreated)
            {
                AddProductButton = new System.Windows.Forms.Button();

                AddProductButton.Name = "AddProductButton";
                AddProductButton.Text = "Добавить товар";
                AddProductButton.ForeColor = Color.White;
                AddProductButton.FlatStyle = FlatStyle.Flat;
                AddProductButton.Cursor = Cursors.Hand;
                AddProductButton.BackgroundImageLayout = ImageLayout.Tile;
                AddProductButton.BackColor = Color.FromArgb(3, 10, 103);
                AddProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                AddProductButton.TextAlign = ContentAlignment.MiddleCenter;
                AddProductButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                AddProductButton.Size = new Size(126, 67);
                AddProductButton.Visible = true;
                AddProductButton.Location = new Point(15, 360);

                // Добавление обработчика события нажатия на кнопку сохранения товара
                AddProductButton.Click += AddProductButton_Click;

                // Добавление кнопки на форму
                AvtorPanel.Controls.Add(AddProductButton);

                ProductNameLabel = new System.Windows.Forms.Label();

                ProductNameLabel.Name = "ProductNameLabel";
                ProductNameLabel.Text = "Название:";
                ProductNameLabel.BorderStyle = BorderStyle.None;
                ProductNameLabel.ForeColor = Color.White;
                ProductNameLabel.FlatStyle = FlatStyle.Flat;
                ProductNameLabel.Cursor = Cursors.Hand;
                ProductNameLabel.BackgroundImageLayout = ImageLayout.Tile;
                ProductNameLabel.BackColor = Color.FromArgb(128, 57, 30);
                ProductNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                ProductNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                ProductNameLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ProductNameLabel.Size = new Size(110, 37);
                ProductNameLabel.Visible = true;
                ProductNameLabel.Location = new Point(860, 18);

                // Добавление label на форму
                AvtorPanel.Controls.Add(ProductNameLabel);

                ProductNameField = new System.Windows.Forms.TextBox();

                ProductNameField.Name = "ProductNameField";
                ProductNameField.BorderStyle = BorderStyle.None;
                ProductNameField.ForeColor = Color.Black;
                ProductNameField.Cursor = Cursors.IBeam;
                ProductNameField.BackgroundImageLayout = ImageLayout.Tile;
                ProductNameField.BackColor = Color.White;
                ProductNameField.Anchor = AnchorStyles.Top;
                ProductNameField.TextAlign = HorizontalAlignment.Center;
                ProductNameField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ProductNameField.Size = new Size(120, 57);
                ProductNameField.Visible = true;
                ProductNameField.Location = new Point(970, 24);

                // Добавление label на форму
                AvtorPanel.Controls.Add(ProductNameField);

                QuantityLabel = new System.Windows.Forms.Label();

                QuantityLabel.Name = "QuantityLabel";
                QuantityLabel.Text = "Количество:";
                QuantityLabel.BorderStyle = BorderStyle.None;
                QuantityLabel.ForeColor = Color.White;
                QuantityLabel.FlatStyle = FlatStyle.Flat;
                QuantityLabel.Cursor = Cursors.Hand;
                QuantityLabel.BackgroundImageLayout = ImageLayout.Tile;
                QuantityLabel.BackColor = Color.FromArgb(128, 57, 30);
                QuantityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                QuantityLabel.TextAlign = ContentAlignment.MiddleCenter;
                QuantityLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                QuantityLabel.Size = new Size(130, 37);
                QuantityLabel.Visible = true;
                QuantityLabel.Location = new Point(860, 58);

                // Добавление label на форму
                AvtorPanel.Controls.Add(QuantityLabel);

                QuantityField = new System.Windows.Forms.TextBox();

                QuantityField.Name = "QuantityField";
                QuantityField.BorderStyle = BorderStyle.None;
                QuantityField.ForeColor = Color.Black;
                QuantityField.Cursor = Cursors.IBeam;
                QuantityField.BackgroundImageLayout = ImageLayout.Tile;
                QuantityField.BackColor = Color.White;
                QuantityField.Anchor = AnchorStyles.Top;
                QuantityField.TextAlign = HorizontalAlignment.Center;
                QuantityField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                QuantityField.Size = new Size(100, 57);
                QuantityField.Visible = true;
                QuantityField.Location = new Point(990, 64);

                AvtorPanel.Controls.Add(QuantityField);

                ManufactureLabel = new System.Windows.Forms.Label();

                ManufactureLabel.Name = "ManufactureLabel";
                ManufactureLabel.Text = "Производитель:";
                ManufactureLabel.BorderStyle = BorderStyle.None;
                ManufactureLabel.ForeColor = Color.White;
                ManufactureLabel.FlatStyle = FlatStyle.Flat;
                ManufactureLabel.Cursor = Cursors.Hand;
                ManufactureLabel.BackgroundImageLayout = ImageLayout.Tile;
                ManufactureLabel.BackColor = Color.FromArgb(128, 57, 30);
                ManufactureLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                ManufactureLabel.TextAlign = ContentAlignment.MiddleCenter;
                ManufactureLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ManufactureLabel.Size = new Size(170, 37);
                ManufactureLabel.Visible = true;
                ManufactureLabel.Location = new Point(855, 98);

                // Добавление label на форму
                AvtorPanel.Controls.Add(ManufactureLabel);

                ManufactureField = new System.Windows.Forms.TextBox();

                ManufactureField.Name = "ManufactureField";
                ManufactureField.BorderStyle = BorderStyle.None;
                ManufactureField.ForeColor = Color.Black;
                ManufactureField.Cursor = Cursors.IBeam;
                ManufactureField.BackgroundImageLayout = ImageLayout.Tile;
                ManufactureField.BackColor = Color.White;
                ManufactureField.Anchor = AnchorStyles.Top;
                ManufactureField.TextAlign = HorizontalAlignment.Center;
                ManufactureField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ManufactureField.Size = new Size(60, 57);
                ManufactureField.Visible = true;
                ManufactureField.Location = new Point(1030, 104);

                AvtorPanel.Controls.Add(ManufactureField);

                SizeLabel = new System.Windows.Forms.Label();

                SizeLabel.Name = "SizeLabel";
                SizeLabel.Text = "Размер:";
                SizeLabel.BorderStyle = BorderStyle.None;
                SizeLabel.ForeColor = Color.White;
                SizeLabel.FlatStyle = FlatStyle.Flat;
                SizeLabel.Cursor = Cursors.Hand;
                SizeLabel.BackgroundImageLayout = ImageLayout.Tile;
                SizeLabel.BackColor = Color.FromArgb(128, 57, 30);
                SizeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                SizeLabel.TextAlign = ContentAlignment.MiddleCenter;
                SizeLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SizeLabel.Size = new Size(100, 37);
                SizeLabel.Visible = true;
                SizeLabel.Location = new Point(855, 138);

                // Добавление label на форму
                AvtorPanel.Controls.Add(SizeLabel);

                SizeField = new System.Windows.Forms.TextBox();

                SizeField.Name = "SizeField";
                SizeField.BorderStyle = BorderStyle.None;
                SizeField.ForeColor = Color.Black;
                SizeField.Cursor = Cursors.IBeam;
                SizeField.BackgroundImageLayout = ImageLayout.Tile;
                SizeField.BackColor = Color.White;
                SizeField.Anchor = AnchorStyles.Top;
                SizeField.TextAlign = HorizontalAlignment.Center;
                SizeField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SizeField.Size = new Size(130, 57);
                SizeField.Visible = true;
                SizeField.Location = new Point(960, 144);

                AvtorPanel.Controls.Add(SizeField);

                PriceLabel = new System.Windows.Forms.Label();

                PriceLabel.Name = "PriceLabel";
                PriceLabel.Text = "Цена:";
                PriceLabel.BorderStyle = BorderStyle.None;
                PriceLabel.ForeColor = Color.White;
                PriceLabel.FlatStyle = FlatStyle.Flat;
                PriceLabel.Cursor = Cursors.Hand;
                PriceLabel.BackgroundImageLayout = ImageLayout.Tile;
                PriceLabel.BackColor = Color.FromArgb(128, 57, 30);
                PriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                PriceLabel.TextAlign = ContentAlignment.MiddleCenter;
                PriceLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PriceLabel.Size = new Size(100, 37);
                PriceLabel.Visible = true;
                PriceLabel.Location = new Point(850, 178);

                // Добавление label на форму
                AvtorPanel.Controls.Add(PriceLabel);

                PriceField = new System.Windows.Forms.TextBox();

                PriceField.Name = "PriceField";
                PriceField.BorderStyle = BorderStyle.None;
                PriceField.ForeColor = Color.Black;
                PriceField.Cursor = Cursors.IBeam;
                PriceField.BackgroundImageLayout = ImageLayout.Tile;
                PriceField.BackColor = Color.White;
                PriceField.Anchor = AnchorStyles.Top;
                PriceField.TextAlign = HorizontalAlignment.Center;
                PriceField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PriceField.Size = new Size(140, 57);
                PriceField.Visible = true;
                PriceField.Location = new Point(950, 184);

                AvtorPanel.Controls.Add(PriceField);

                SecurityLabel = new System.Windows.Forms.Label();

                SecurityLabel.Name = "SecurityLabel";
                SecurityLabel.Text = "Срок гарантии:";
                SecurityLabel.BorderStyle = BorderStyle.None;
                SecurityLabel.ForeColor = Color.White;
                SecurityLabel.FlatStyle = FlatStyle.Flat;
                SecurityLabel.Cursor = Cursors.Hand;
                SecurityLabel.BackgroundImageLayout = ImageLayout.Tile;
                SecurityLabel.BackColor = Color.FromArgb(128, 57, 30);
                SecurityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                SecurityLabel.TextAlign = ContentAlignment.MiddleCenter;
                SecurityLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SecurityLabel.Size = new Size(200, 37);
                SecurityLabel.Visible = true;
                SecurityLabel.Location = new Point(840, 218);

                // Добавление label на форму
                AvtorPanel.Controls.Add(SecurityLabel);

                SecurityField = new System.Windows.Forms.TextBox();

                SecurityField.Name = "SecurityField";
                SecurityField.BorderStyle = BorderStyle.None;
                SecurityField.ForeColor = Color.Black;
                SecurityField.Cursor = Cursors.IBeam;
                SecurityField.BackgroundImageLayout = ImageLayout.Tile;
                SecurityField.BackColor = Color.White;
                SecurityField.Anchor = AnchorStyles.Top;
                SecurityField.TextAlign = HorizontalAlignment.Center;
                SecurityField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SecurityField.Size = new Size(50, 57);
                SecurityField.Visible = true;
                SecurityField.Location = new Point(1040, 224);

                AvtorPanel.Controls.Add(SecurityField);
                // Устанавливаем флаг, что элементы были созданы
                isElementsCreated = true;
            }
            else
            {
                // Если элементы уже созданы, делаем их невидимыми
                AddProductButton.Visible = false;

                ProductNameLabel.Visible = false;
                ProductNameField.Visible = false;

                QuantityLabel.Visible = false;
                QuantityField.Visible = false;

                SizeLabel.Visible = false;
                SizeField.Visible = false;

                ManufactureLabel.Visible = false;
                ManufactureField.Visible = false;

                PriceLabel.Visible = false;
                PriceField.Visible = false;

                SecurityLabel.Visible = false;
                SecurityField.Visible = false;

                isElementsCreated = false;
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            string productName = ProductNameField.Text;
            string quantityText = QuantityField.Text;
            string sizeText = SizeField.Text;
            string manuf = ManufactureField.Text;
            string priceText = PriceField.Text;
            string securityText = SecurityField.Text;

            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(quantityText) || string.IsNullOrEmpty(sizeText) ||
                string.IsNullOrEmpty(manuf) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(securityText))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            int quantity;
            decimal price;
            int security;

            // Проверка корректности полей
            if (!IsRussianLetters(productName))
            {
                MessageBox.Show("Поле Наименование товара должно содержать только русские символы");
                return;
            }
            if (!int.TryParse(quantityText, out quantity))
            {
                MessageBox.Show("Поле Количество должно содержать только цифры");
                return;
            }
            if (!int.TryParse(sizeText, out _))
            {
                MessageBox.Show("Поле Размер должно содержать только цифры");
                return;
            }
            if (!IsRussianLetters(manuf))
            {
                MessageBox.Show("Поле Производитель должно содержать только русские символы");
                return;
            }
            if (!decimal.TryParse(priceText, out price))
            {
                MessageBox.Show("Поле Цена должно содержать только числовые значения");
                return;
            }
            if (!int.TryParse(securityText, out security))
            {
                MessageBox.Show("Поле Срок гарантии должно содержать только цифры");
                return;
            }

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных warehouse
            database.OpenConnection();

            // Проверяем наличие строки с соответствующей информацией в таблице warehouse
            string warehouseQuery = "SELECT * FROM warehouse WHERE ProductName = @ProductName " +
                "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand warehouseCommand = new MySqlCommand(warehouseQuery, database.GetConnection());
            warehouseCommand.Parameters.AddWithValue("@ProductName", productName);
            warehouseCommand.Parameters.AddWithValue("@Size", sizeText);
            warehouseCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            warehouseCommand.Parameters.AddWithValue("@Price", price);
            warehouseCommand.Parameters.AddWithValue("@Security", security);

            MySqlDataReader warehouseReader = warehouseCommand.ExecuteReader();

            if (!warehouseReader.HasRows)
            {
                warehouseReader.Close();
                database.CloseConnection();
                MessageBox.Show("Товар не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            warehouseReader.Close();

            // Проверяем, что считанное количество меньше количества в базе данных warehouse
            string quantityQuery = "SELECT Quantity FROM warehouse WHERE ProductName = @ProductName " +
                "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand quantityCommand = new MySqlCommand(quantityQuery, database.GetConnection());
            quantityCommand.Parameters.AddWithValue("@ProductName", productName);
            quantityCommand.Parameters.AddWithValue("@Size", sizeText);
            quantityCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            quantityCommand.Parameters.AddWithValue("@Price", price);
            quantityCommand.Parameters.AddWithValue("@Security", security);

            int quantityInDB = Convert.ToInt32(quantityCommand.ExecuteScalar());

            int quantityToAdd = int.Parse(quantityText);

            if (quantityToAdd > quantityInDB)
            {
                database.CloseConnection();
                MessageBox.Show("Количество товара должно быть меньше существующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int newQuantity = quantityInDB - quantityToAdd;

            /// Обновление значения столбца Quantity в таблице warehouse
            string updateQuantityQuery = "UPDATE warehouse SET Quantity = @NewQuantity WHERE ProductName = @ProductName " +
                "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand updateQuantityCommand = new MySqlCommand(updateQuantityQuery, database.GetConnection());
            updateQuantityCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
            updateQuantityCommand.Parameters.AddWithValue("@ProductName", productName);
            updateQuantityCommand.Parameters.AddWithValue("@Size", sizeText);
            updateQuantityCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            updateQuantityCommand.Parameters.AddWithValue("@Price", priceText);
            updateQuantityCommand.Parameters.AddWithValue("@Security", securityText);

            updateQuantityCommand.ExecuteNonQuery();

            // Проверка наличия строки с соответствующей информацией в таблице shopping_cart
            string shoppingCartCheckQuery = "SELECT * FROM shopping_cart WHERE ProductName = @ProductName " +
            "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand shoppingCartCheckCommand = new MySqlCommand(shoppingCartCheckQuery, database.GetConnection());
            shoppingCartCheckCommand.Parameters.AddWithValue("@ProductName", productName);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Size", sizeText);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Price", priceText);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Security", securityText);

            using (MySqlDataReader shoppingCartCheckReader = shoppingCartCheckCommand.ExecuteReader())
            {
                if (shoppingCartCheckReader.HasRows)
                {
                    shoppingCartCheckReader.Close();

                    // Получение текущего значения столбца Quantity
                    string getQuantityQuery = "SELECT Quantity FROM shopping_cart WHERE ProductName = @ProductName " +
                        "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
                    MySqlCommand getQuantityCommand = new MySqlCommand(getQuantityQuery, database.GetConnection());
                    getQuantityCommand.Parameters.AddWithValue("@ProductName", productName);
                    getQuantityCommand.Parameters.AddWithValue("@Size", sizeText);
                    getQuantityCommand.Parameters.AddWithValue("@Manufacturer", manuf);
                    getQuantityCommand.Parameters.AddWithValue("@Price", priceText);
                    getQuantityCommand.Parameters.AddWithValue("@Security", securityText);

                    int currentQuantity = Convert.ToInt32(getQuantityCommand.ExecuteScalar());
                    int updatedQuantity = currentQuantity + quantityToAdd;

                    // Увеличение значения количества в таблице shopping_cart
                    string QuantityQuery = "UPDATE shopping_cart SET Quantity = @UpdatedQuantity " +
                        "WHERE ProductName = @ProductName AND Size = @Size AND Manufacture = @Manufacturer " +
                        "AND Price = @Price AND Security = @Security";
                    MySqlCommand QuantityCommand = new MySqlCommand(QuantityQuery, database.GetConnection());

                    QuantityCommand.Parameters.AddWithValue("@UpdatedQuantity", updatedQuantity);

                    QuantityCommand.Parameters.AddWithValue("@ProductName", productName);

                    QuantityCommand.Parameters.AddWithValue("@Size", sizeText);

                    QuantityCommand.Parameters.AddWithValue("@Manufacturer", manuf);

                    QuantityCommand.Parameters.AddWithValue("@Price", priceText);

                    QuantityCommand.Parameters.AddWithValue("@Security", securityText);



                    QuantityCommand.ExecuteNonQuery();

                    MessageBox.Show("Товар успешно добавлен в корзину", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    shoppingCartCheckReader.Close();

                    // Добавление новой строки в таблицу shopping_cart
                    string insertQuery = "INSERT INTO shopping_cart (ProductName, Quantity, Size, Manufacture, Price, Security) VALUES " +
                        "(@ProductName, @Quantity, @Size, @Manufacturer, @Price, @Security)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, database.GetConnection());
                    insertCommand.Parameters.AddWithValue("@ProductName", productName);
                    insertCommand.Parameters.AddWithValue("@Quantity", quantityText);
                    insertCommand.Parameters.AddWithValue("@Size", sizeText);
                    insertCommand.Parameters.AddWithValue("@Manufacturer", manuf);
                    insertCommand.Parameters.AddWithValue("@Price", priceText);
                    insertCommand.Parameters.AddWithValue("@Security", securityText);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Товар успешно добавлен в корзину", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            database.CloseConnection();
        }

        private bool IsRussianLetters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) || !IsRussianLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsRussianLetter(char c)
        {
            UnicodeCategory category = char.GetUnicodeCategory(c);
            return category == UnicodeCategory.LowercaseLetter || category == UnicodeCategory.UppercaseLetter;
        }

        System.Windows.Forms.Button RemoveProductButton;

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Проверяем, созданы ли элементы
            if (!isElementsCreated)
            {
                RemoveProductButton = new System.Windows.Forms.Button();

                RemoveProductButton.Name = "RemoveProductButton";
                RemoveProductButton.Text = "Удалить товар";
                RemoveProductButton.ForeColor = Color.White;
                RemoveProductButton.FlatStyle = FlatStyle.Flat;
                RemoveProductButton.Cursor = Cursors.Hand;
                RemoveProductButton.BackgroundImageLayout = ImageLayout.Tile;
                RemoveProductButton.BackColor = Color.FromArgb(3, 10, 103);
                RemoveProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                RemoveProductButton.TextAlign = ContentAlignment.MiddleCenter;
                RemoveProductButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                RemoveProductButton.Size = new Size(126, 67);
                RemoveProductButton.Visible = true;
                RemoveProductButton.Location = new Point(165, 360);

                // Добавление обработчика события нажатия на кнопку сохранения товара
                RemoveProductButton.Click += RemoveProductButton_Click;

                // Добавление кнопки на форму
                AvtorPanel.Controls.Add(RemoveProductButton);

                ProductNameLabel = new System.Windows.Forms.Label();

                ProductNameLabel.Name = "ProductNameLabel";
                ProductNameLabel.Text = "Название:";
                ProductNameLabel.BorderStyle = BorderStyle.None;
                ProductNameLabel.ForeColor = Color.White;
                ProductNameLabel.FlatStyle = FlatStyle.Flat;
                ProductNameLabel.Cursor = Cursors.Hand;
                ProductNameLabel.BackgroundImageLayout = ImageLayout.Tile;
                ProductNameLabel.BackColor = Color.FromArgb(128, 57, 30);
                ProductNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                ProductNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                ProductNameLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ProductNameLabel.Size = new Size(110, 37);
                ProductNameLabel.Visible = true;
                ProductNameLabel.Location = new Point(860, 18);

                // Добавление label на форму
                AvtorPanel.Controls.Add(ProductNameLabel);

                ProductNameField = new System.Windows.Forms.TextBox();

                ProductNameField.Name = "ProductNameField";
                ProductNameField.BorderStyle = BorderStyle.None;
                ProductNameField.ForeColor = Color.Black;
                ProductNameField.Cursor = Cursors.IBeam;
                ProductNameField.BackgroundImageLayout = ImageLayout.Tile;
                ProductNameField.BackColor = Color.White;
                ProductNameField.Anchor = AnchorStyles.Top;
                ProductNameField.TextAlign = HorizontalAlignment.Center;
                ProductNameField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ProductNameField.Size = new Size(120, 57);
                ProductNameField.Visible = true;
                ProductNameField.Location = new Point(970, 24);

                // Добавление label на форму
                AvtorPanel.Controls.Add(ProductNameField);

                QuantityLabel = new System.Windows.Forms.Label();

                QuantityLabel.Name = "QuantityLabel";
                QuantityLabel.Text = "Количество:";
                QuantityLabel.BorderStyle = BorderStyle.None;
                QuantityLabel.ForeColor = Color.White;
                QuantityLabel.FlatStyle = FlatStyle.Flat;
                QuantityLabel.Cursor = Cursors.Hand;
                QuantityLabel.BackgroundImageLayout = ImageLayout.Tile;
                QuantityLabel.BackColor = Color.FromArgb(128, 57, 30);
                QuantityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                QuantityLabel.TextAlign = ContentAlignment.MiddleCenter;
                QuantityLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                QuantityLabel.Size = new Size(130, 37);
                QuantityLabel.Visible = true;
                QuantityLabel.Location = new Point(860, 58);

                // Добавление label на форму
                AvtorPanel.Controls.Add(QuantityLabel);

                QuantityField = new System.Windows.Forms.TextBox();

                QuantityField.Name = "QuantityField";
                QuantityField.BorderStyle = BorderStyle.None;
                QuantityField.ForeColor = Color.Black;
                QuantityField.Cursor = Cursors.IBeam;
                QuantityField.BackgroundImageLayout = ImageLayout.Tile;
                QuantityField.BackColor = Color.White;
                QuantityField.Anchor = AnchorStyles.Top;
                QuantityField.TextAlign = HorizontalAlignment.Center;
                QuantityField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                QuantityField.Size = new Size(100, 57);
                QuantityField.Visible = true;
                QuantityField.Location = new Point(990, 64);

                AvtorPanel.Controls.Add(QuantityField);

                ManufactureLabel = new System.Windows.Forms.Label();

                ManufactureLabel.Name = "ManufactureLabel";
                ManufactureLabel.Text = "Производитель:";
                ManufactureLabel.BorderStyle = BorderStyle.None;
                ManufactureLabel.ForeColor = Color.White;
                ManufactureLabel.FlatStyle = FlatStyle.Flat;
                ManufactureLabel.Cursor = Cursors.Hand;
                ManufactureLabel.BackgroundImageLayout = ImageLayout.Tile;
                ManufactureLabel.BackColor = Color.FromArgb(128, 57, 30);
                ManufactureLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                ManufactureLabel.TextAlign = ContentAlignment.MiddleCenter;
                ManufactureLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ManufactureLabel.Size = new Size(170, 37);
                ManufactureLabel.Visible = true;
                ManufactureLabel.Location = new Point(855, 98);

                // Добавление label на форму
                AvtorPanel.Controls.Add(ManufactureLabel);

                ManufactureField = new System.Windows.Forms.TextBox();

                ManufactureField.Name = "ManufactureField";
                ManufactureField.BorderStyle = BorderStyle.None;
                ManufactureField.ForeColor = Color.Black;
                ManufactureField.Cursor = Cursors.IBeam;
                ManufactureField.BackgroundImageLayout = ImageLayout.Tile;
                ManufactureField.BackColor = Color.White;
                ManufactureField.Anchor = AnchorStyles.Top;
                ManufactureField.TextAlign = HorizontalAlignment.Center;
                ManufactureField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ManufactureField.Size = new Size(60, 57);
                ManufactureField.Visible = true;
                ManufactureField.Location = new Point(1030, 104);

                AvtorPanel.Controls.Add(ManufactureField);

                SizeLabel = new System.Windows.Forms.Label();

                SizeLabel.Name = "SizeLabel";
                SizeLabel.Text = "Размер:";
                SizeLabel.BorderStyle = BorderStyle.None;
                SizeLabel.ForeColor = Color.White;
                SizeLabel.FlatStyle = FlatStyle.Flat;
                SizeLabel.Cursor = Cursors.Hand;
                SizeLabel.BackgroundImageLayout = ImageLayout.Tile;
                SizeLabel.BackColor = Color.FromArgb(128, 57, 30);
                SizeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                SizeLabel.TextAlign = ContentAlignment.MiddleCenter;
                SizeLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SizeLabel.Size = new Size(100, 37);
                SizeLabel.Visible = true;
                SizeLabel.Location = new Point(855, 138);

                // Добавление label на форму
                AvtorPanel.Controls.Add(SizeLabel);

                SizeField = new System.Windows.Forms.TextBox();

                SizeField.Name = "SizeField";
                SizeField.BorderStyle = BorderStyle.None;
                SizeField.ForeColor = Color.Black;
                SizeField.Cursor = Cursors.IBeam;
                SizeField.BackgroundImageLayout = ImageLayout.Tile;
                SizeField.BackColor = Color.White;
                SizeField.Anchor = AnchorStyles.Top;
                SizeField.TextAlign = HorizontalAlignment.Center;
                SizeField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SizeField.Size = new Size(130, 57);
                SizeField.Visible = true;
                SizeField.Location = new Point(960, 144);

                AvtorPanel.Controls.Add(SizeField);

                PriceLabel = new System.Windows.Forms.Label();

                PriceLabel.Name = "PriceLabel";
                PriceLabel.Text = "Цена:";
                PriceLabel.BorderStyle = BorderStyle.None;
                PriceLabel.ForeColor = Color.White;
                PriceLabel.FlatStyle = FlatStyle.Flat;
                PriceLabel.Cursor = Cursors.Hand;
                PriceLabel.BackgroundImageLayout = ImageLayout.Tile;
                PriceLabel.BackColor = Color.FromArgb(128, 57, 30);
                PriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                PriceLabel.TextAlign = ContentAlignment.MiddleCenter;
                PriceLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PriceLabel.Size = new Size(100, 37);
                PriceLabel.Visible = true;
                PriceLabel.Location = new Point(850, 178);

                // Добавление label на форму
                AvtorPanel.Controls.Add(PriceLabel);

                PriceField = new System.Windows.Forms.TextBox();

                PriceField.Name = "PriceField";
                PriceField.BorderStyle = BorderStyle.None;
                PriceField.ForeColor = Color.Black;
                PriceField.Cursor = Cursors.IBeam;
                PriceField.BackgroundImageLayout = ImageLayout.Tile;
                PriceField.BackColor = Color.White;
                PriceField.Anchor = AnchorStyles.Top;
                PriceField.TextAlign = HorizontalAlignment.Center;
                PriceField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PriceField.Size = new Size(140, 57);
                PriceField.Visible = true;
                PriceField.Location = new Point(950, 184);

                AvtorPanel.Controls.Add(PriceField);

                SecurityLabel = new System.Windows.Forms.Label();

                SecurityLabel.Name = "SecurityLabel";
                SecurityLabel.Text = "Срок гарантии:";
                SecurityLabel.BorderStyle = BorderStyle.None;
                SecurityLabel.ForeColor = Color.White;
                SecurityLabel.FlatStyle = FlatStyle.Flat;
                SecurityLabel.Cursor = Cursors.Hand;
                SecurityLabel.BackgroundImageLayout = ImageLayout.Tile;
                SecurityLabel.BackColor = Color.FromArgb(128, 57, 30);
                SecurityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                SecurityLabel.TextAlign = ContentAlignment.MiddleCenter;
                SecurityLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SecurityLabel.Size = new Size(200, 37);
                SecurityLabel.Visible = true;
                SecurityLabel.Location = new Point(840, 218);

                // Добавление label на форму
                AvtorPanel.Controls.Add(SecurityLabel);

                SecurityField = new System.Windows.Forms.TextBox();

                SecurityField.Name = "SecurityField";
                SecurityField.BorderStyle = BorderStyle.None;
                SecurityField.ForeColor = Color.Black;
                SecurityField.Cursor = Cursors.IBeam;
                SecurityField.BackgroundImageLayout = ImageLayout.Tile;
                SecurityField.BackColor = Color.White;
                SecurityField.Anchor = AnchorStyles.Top;
                SecurityField.TextAlign = HorizontalAlignment.Center;
                SecurityField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SecurityField.Size = new Size(50, 57);
                SecurityField.Visible = true;
                SecurityField.Location = new Point(1040, 224);

                AvtorPanel.Controls.Add(SecurityField);
                // Устанавливаем флаг, что элементы были созданы
                isElementsCreated = true;
            }
            else
            {
                // Если элементы уже созданы, делаем их невидимыми
                RemoveProductButton.Visible = false;

                ProductNameLabel.Visible = false;
                ProductNameField.Visible = false;

                QuantityLabel.Visible = false;
                QuantityField.Visible = false;

                SizeLabel.Visible = false;
                SizeField.Visible = false;

                ManufactureLabel.Visible = false;
                ManufactureField.Visible = false;

                PriceLabel.Visible = false;
                PriceField.Visible = false;

                SecurityLabel.Visible = false;
                SecurityField.Visible = false;

                isElementsCreated = false;
            }
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            string productName = ProductNameField.Text;
            string quantityText = QuantityField.Text;
            string sizeText = SizeField.Text;
            string manuf = ManufactureField.Text;
            string priceText = PriceField.Text;
            string securityText = SecurityField.Text;

            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(quantityText) || string.IsNullOrEmpty(sizeText) ||
                string.IsNullOrEmpty(manuf) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(securityText))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            int quantity;
            decimal price;
            int security;

            // Проверка корректности полей
            if (!IsRussianLetters(productName))
            {
                MessageBox.Show("Поле Наименование товара должно содержать только русские символы");
                return;
            }
            if (!int.TryParse(quantityText, out quantity))
            {
                MessageBox.Show("Поле Количество должно содержать только цифры");
                return;
            }
            if (!int.TryParse(sizeText, out _))
            {
                MessageBox.Show("Поле Размер должно содержать только цифры");
                return;
            }
            if (!IsRussianLetters(manuf))
            {
                MessageBox.Show("Поле Производитель должно содержать только русские символы");
                return;
            }
            if (!decimal.TryParse(priceText, out price))
            {
                MessageBox.Show("Поле Цена должно содержать только числовые значения");
                return;
            }
            if (!int.TryParse(securityText, out security))
            {
                MessageBox.Show("Поле Срок гарантии должно содержать только цифры");
                return;
            }

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных shopping_cart
            database.OpenConnection();

            // Проверяем наличие строки с соответствующей информацией в таблице shopping_cart
            string shoppingCartCheckQuery = "SELECT * FROM shopping_cart WHERE ProductName = @ProductName " +
                "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand shoppingCartCheckCommand = new MySqlCommand(shoppingCartCheckQuery, database.GetConnection());
            shoppingCartCheckCommand.Parameters.AddWithValue("@ProductName", productName);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Size", sizeText);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Price", price);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Security", security);

            MySqlDataReader shoppingCartCheckReader = shoppingCartCheckCommand.ExecuteReader();
            if (!shoppingCartCheckReader.HasRows)
            {
                shoppingCartCheckReader.Close();
                database.CloseConnection();
                MessageBox.Show("Товар не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            shoppingCartCheckReader.Close();

            // Получаем текущее значение столбца Quantity из таблицы shopping_cart
            string getCurrentQuantityQuery = "SELECT Quantity FROM shopping_cart WHERE ProductName = @ProductName " +
                "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand getCurrentQuantityCommand = new MySqlCommand(getCurrentQuantityQuery, database.GetConnection());
            getCurrentQuantityCommand.Parameters.AddWithValue("@ProductName", productName);
            getCurrentQuantityCommand.Parameters.AddWithValue("@Size", sizeText);
            getCurrentQuantityCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            getCurrentQuantityCommand.Parameters.AddWithValue("@Price", price);
            getCurrentQuantityCommand.Parameters.AddWithValue("@Security", security);

            int currentQuantity;

            try
            {
                currentQuantity = Convert.ToInt32(getCurrentQuantityCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении текущего количества товара из базы данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.CloseConnection();
                return;
            }

            int quantityToRemove = int.Parse(quantityText);

            // Проверяем, что считанное количество меньше или равно количеству в базе данных shopping_cart
            if (quantityToRemove > currentQuantity)
            {
                database.CloseConnection();
                MessageBox.Show("Указанное количество товара больше, чем текущее количество в корзине", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Обновляем количество в таблице shopping_cart
            int updatedQuantity = currentQuantity - quantityToRemove;
            string updateQuantityQuery = "UPDATE shopping_cart SET Quantity = @UpdatedQuantity " +
                "WHERE ProductName = @ProductName AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand updateQuantityCommand = new MySqlCommand(updateQuantityQuery, database.GetConnection());
            updateQuantityCommand.Parameters.AddWithValue("@UpdatedQuantity", updatedQuantity);
            updateQuantityCommand.Parameters.AddWithValue("@ProductName", productName);
            updateQuantityCommand.Parameters.AddWithValue("@Size", sizeText);
            updateQuantityCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            updateQuantityCommand.Parameters.AddWithValue("@Price", price);
            updateQuantityCommand.Parameters.AddWithValue("@Security", security);

            try
            {
                updateQuantityCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении количества товара в корзине: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.CloseConnection();
                return;
            }

            // Открываем подключение к базе данных warehouse
            string warehouseUpdateQuery = "UPDATE warehouse SET Quantity = Quantity + @QuantityToAdd " +
                "WHERE ProductName = @ProductName AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand warehouseUpdateCommand = new MySqlCommand(warehouseUpdateQuery, database.GetConnection());
            warehouseUpdateCommand.Parameters.AddWithValue("@QuantityToAdd", quantityToRemove);
            warehouseUpdateCommand.Parameters.AddWithValue("@ProductName", productName);
            warehouseUpdateCommand.Parameters.AddWithValue("@Size", sizeText);
            warehouseUpdateCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            warehouseUpdateCommand.Parameters.AddWithValue("@Price", price);
            warehouseUpdateCommand.Parameters.AddWithValue("@Security", security);

            try
            {
                warehouseUpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Часть товара успешно возвращена на склад", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении количества товара на складе: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            database.CloseConnection();
        }

        System.Windows.Forms.Button ClearProductButton;

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Проверяем, созданы ли элементы
            if (!isElementsCreated)
            {
                ClearProductButton = new System.Windows.Forms.Button();

                ClearProductButton.Text = "Очистить товар";
                ClearProductButton.ForeColor = Color.White;
                ClearProductButton.FlatStyle = FlatStyle.Flat;
                ClearProductButton.Cursor = Cursors.Hand;
                ClearProductButton.BackgroundImageLayout = ImageLayout.Tile;
                ClearProductButton.BackColor = Color.FromArgb(3, 10, 103);
                ClearProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                ClearProductButton.TextAlign = ContentAlignment.MiddleCenter;
                ClearProductButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                ClearProductButton.Size = new Size(126, 67);
                ClearProductButton.Visible = true;
                ClearProductButton.Location = new Point(315, 360);

                // Добавление обработчика события нажатия на кнопку сохранения товара
                ClearProductButton.Click += ClearProductButton_Click;

                // Добавление кнопки на форму
                AvtorPanel.Controls.Add(ClearProductButton);

                ProductNameLabel = new System.Windows.Forms.Label();

                ProductNameLabel.Name = "ProductNameLabel";
                ProductNameLabel.Text = "Название:";
                ProductNameLabel.BorderStyle = BorderStyle.None;
                ProductNameLabel.ForeColor = Color.White;
                ProductNameLabel.FlatStyle = FlatStyle.Flat;
                ProductNameLabel.Cursor = Cursors.Hand;
                ProductNameLabel.BackgroundImageLayout = ImageLayout.Tile;
                ProductNameLabel.BackColor = Color.FromArgb(128, 57, 30);
                ProductNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                ProductNameLabel.TextAlign = ContentAlignment.MiddleCenter;
                ProductNameLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ProductNameLabel.Size = new Size(110, 37);
                ProductNameLabel.Visible = true;
                ProductNameLabel.Location = new Point(860, 18);

                // Добавление label на форму
                AvtorPanel.Controls.Add(ProductNameLabel);

                ProductNameField = new System.Windows.Forms.TextBox();

                ProductNameField.Name = "ProductNameField";
                ProductNameField.BorderStyle = BorderStyle.None;
                ProductNameField.ForeColor = Color.Black;
                ProductNameField.Cursor = Cursors.IBeam;
                ProductNameField.BackgroundImageLayout = ImageLayout.Tile;
                ProductNameField.BackColor = Color.White;
                ProductNameField.Anchor = AnchorStyles.Top;
                ProductNameField.TextAlign = HorizontalAlignment.Center;
                ProductNameField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ProductNameField.Size = new Size(120, 57);
                ProductNameField.Visible = true;
                ProductNameField.Location = new Point(970, 24);

                // Добавление label на форму
                AvtorPanel.Controls.Add(ProductNameField);

                ManufactureLabel = new System.Windows.Forms.Label();

                ManufactureLabel.Name = "ManufactureLabel";
                ManufactureLabel.Text = "Производитель:";
                ManufactureLabel.BorderStyle = BorderStyle.None;
                ManufactureLabel.ForeColor = Color.White;
                ManufactureLabel.FlatStyle = FlatStyle.Flat;
                ManufactureLabel.Cursor = Cursors.Hand;
                ManufactureLabel.BackgroundImageLayout = ImageLayout.Tile;
                ManufactureLabel.BackColor = Color.FromArgb(128, 57, 30);
                ManufactureLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                ManufactureLabel.TextAlign = ContentAlignment.MiddleCenter;
                ManufactureLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ManufactureLabel.Size = new Size(170, 37);
                ManufactureLabel.Visible = true;
                ManufactureLabel.Location = new Point(855, 58);

                // Добавление label на форму
                AvtorPanel.Controls.Add(ManufactureLabel);

                ManufactureField = new System.Windows.Forms.TextBox();

                ManufactureField.Name = "ManufactureField";
                ManufactureField.BorderStyle = BorderStyle.None;
                ManufactureField.ForeColor = Color.Black;
                ManufactureField.Cursor = Cursors.IBeam;
                ManufactureField.BackgroundImageLayout = ImageLayout.Tile;
                ManufactureField.BackColor = Color.White;
                ManufactureField.Anchor = AnchorStyles.Top;
                ManufactureField.TextAlign = HorizontalAlignment.Center;
                ManufactureField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                ManufactureField.Size = new Size(60, 57);
                ManufactureField.Visible = true;
                ManufactureField.Location = new Point(1030, 64);

                AvtorPanel.Controls.Add(ManufactureField);

                SizeLabel = new System.Windows.Forms.Label();

                SizeLabel.Name = "SizeLabel";
                SizeLabel.Text = "Размер:";
                SizeLabel.BorderStyle = BorderStyle.None;
                SizeLabel.ForeColor = Color.White;
                SizeLabel.FlatStyle = FlatStyle.Flat;
                SizeLabel.Cursor = Cursors.Hand;
                SizeLabel.BackgroundImageLayout = ImageLayout.Tile;
                SizeLabel.BackColor = Color.FromArgb(128, 57, 30);
                SizeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                SizeLabel.TextAlign = ContentAlignment.MiddleCenter;
                SizeLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SizeLabel.Size = new Size(100, 37);
                SizeLabel.Visible = true;
                SizeLabel.Location = new Point(855, 98);

                // Добавление label на форму
                AvtorPanel.Controls.Add(SizeLabel);

                SizeField = new System.Windows.Forms.TextBox();

                SizeField.Name = "SizeField";
                SizeField.BorderStyle = BorderStyle.None;
                SizeField.ForeColor = Color.Black;
                SizeField.Cursor = Cursors.IBeam;
                SizeField.BackgroundImageLayout = ImageLayout.Tile;
                SizeField.BackColor = Color.White;
                SizeField.Anchor = AnchorStyles.Top;
                SizeField.TextAlign = HorizontalAlignment.Center;
                SizeField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SizeField.Size = new Size(130, 57);
                SizeField.Visible = true;
                SizeField.Location = new Point(960, 104);

                AvtorPanel.Controls.Add(SizeField);

                PriceLabel = new System.Windows.Forms.Label();

                PriceLabel.Name = "PriceLabel";
                PriceLabel.Text = "Цена:";
                PriceLabel.BorderStyle = BorderStyle.None;
                PriceLabel.ForeColor = Color.White;
                PriceLabel.FlatStyle = FlatStyle.Flat;
                PriceLabel.Cursor = Cursors.Hand;
                PriceLabel.BackgroundImageLayout = ImageLayout.Tile;
                PriceLabel.BackColor = Color.FromArgb(128, 57, 30);
                PriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                PriceLabel.TextAlign = ContentAlignment.MiddleCenter;
                PriceLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PriceLabel.Size = new Size(100, 37);
                PriceLabel.Visible = true;
                PriceLabel.Location = new Point(850, 138);

                // Добавление label на форму
                AvtorPanel.Controls.Add(PriceLabel);

                PriceField = new System.Windows.Forms.TextBox();

                PriceField.Name = "PriceField";
                PriceField.BorderStyle = BorderStyle.None;
                PriceField.ForeColor = Color.Black;
                PriceField.Cursor = Cursors.IBeam;
                PriceField.BackgroundImageLayout = ImageLayout.Tile;
                PriceField.BackColor = Color.White;
                PriceField.Anchor = AnchorStyles.Top;
                PriceField.TextAlign = HorizontalAlignment.Center;
                PriceField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PriceField.Size = new Size(140, 57);
                PriceField.Visible = true;
                PriceField.Location = new Point(950, 144);

                AvtorPanel.Controls.Add(PriceField);

                SecurityLabel = new System.Windows.Forms.Label();

                SecurityLabel.Name = "SecurityLabel";
                SecurityLabel.Text = "Срок гарантии:";
                SecurityLabel.BorderStyle = BorderStyle.None;
                SecurityLabel.ForeColor = Color.White;
                SecurityLabel.FlatStyle = FlatStyle.Flat;
                SecurityLabel.Cursor = Cursors.Hand;
                SecurityLabel.BackgroundImageLayout = ImageLayout.Tile;
                SecurityLabel.BackColor = Color.FromArgb(128, 57, 30);
                SecurityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                SecurityLabel.TextAlign = ContentAlignment.MiddleCenter;
                SecurityLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SecurityLabel.Size = new Size(200, 37);
                SecurityLabel.Visible = true;
                SecurityLabel.Location = new Point(840, 178);

                // Добавление label на форму
                AvtorPanel.Controls.Add(SecurityLabel);

                SecurityField = new System.Windows.Forms.TextBox();

                SecurityField.Name = "SecurityField";
                SecurityField.BorderStyle = BorderStyle.None;
                SecurityField.ForeColor = Color.Black;
                SecurityField.Cursor = Cursors.IBeam;
                SecurityField.BackgroundImageLayout = ImageLayout.Tile;
                SecurityField.BackColor = Color.White;
                SecurityField.Anchor = AnchorStyles.Top;
                SecurityField.TextAlign = HorizontalAlignment.Center;
                SecurityField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                SecurityField.Size = new Size(50, 57);
                SecurityField.Visible = true;
                SecurityField.Location = new Point(1040, 184);

                AvtorPanel.Controls.Add(SecurityField);
                // Устанавливаем флаг, что элементы были созданы
                isElementsCreated = true;
            }
            else
            {
                // Если элементы уже созданы, делаем их невидимыми
                ClearProductButton.Visible = false;

                ProductNameLabel.Visible = false;
                ProductNameField.Visible = false;

                SizeLabel.Visible = false;
                SizeField.Visible = false;

                ManufactureLabel.Visible = false;
                ManufactureField.Visible = false;

                PriceLabel.Visible = false;
                PriceField.Visible = false;

                SecurityLabel.Visible = false;
                SecurityField.Visible = false;

                isElementsCreated = false;
            }
        }

        private void ClearProductButton_Click(object sender, EventArgs e)
        {
            string productName = ProductNameField.Text;
            string sizeText = SizeField.Text;
            string manuf = ManufactureField.Text;
            string priceText = PriceField.Text;
            string securityText = SecurityField.Text;

            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(sizeText) ||
                string.IsNullOrEmpty(manuf) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(securityText))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }
            decimal price;
            int security;

            // Проверка корректности полей
            if (!IsRussianLetters(productName))
            {
                MessageBox.Show("Поле Наименование товара должно содержать только русские символы");
                return;
            }
            if (!int.TryParse(sizeText, out _))
            {
                MessageBox.Show("Поле Размер должно содержать только цифры");
                return;
            }
            if (!IsRussianLetters(manuf))
            {
                MessageBox.Show("Поле Производитель должно содержать только русские символы");
                return;
            }
            if (!decimal.TryParse(priceText, out price))
            {
                MessageBox.Show("Поле Цена должно содержать только числовые значения");
                return;
            }
            if (!int.TryParse(securityText, out security))
            {
                MessageBox.Show("Поле Срок гарантии должно содержать только цифры");
                return;
            }

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных shopping_cart
            database.OpenConnection();

            // Проверяем наличие строки с соответствующей информацией в таблице shopping_cart
            string shoppingCartCheckQuery = "SELECT * FROM shopping_cart WHERE ProductName = @ProductName " +
                "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand shoppingCartCheckCommand = new MySqlCommand(shoppingCartCheckQuery, database.GetConnection());
            shoppingCartCheckCommand.Parameters.AddWithValue("@ProductName", productName);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Size", sizeText);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Price", price);
            shoppingCartCheckCommand.Parameters.AddWithValue("@Security", security);

            MySqlDataReader shoppingCartCheckReader = shoppingCartCheckCommand.ExecuteReader();
            if (!shoppingCartCheckReader.HasRows)
            {
                shoppingCartCheckReader.Close();
                database.CloseConnection();

                MessageBox.Show("Товар не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            shoppingCartCheckReader.Close();

            // Получаем текущее значение столбца Quantity из таблицы shopping_cart
            string getCurrentQuantityQuery = "SELECT Quantity FROM shopping_cart WHERE ProductName = @ProductName " +
                "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand getCurrentQuantityCommand = new MySqlCommand(getCurrentQuantityQuery, database.GetConnection());
            getCurrentQuantityCommand.Parameters.AddWithValue("@ProductName", productName);
            getCurrentQuantityCommand.Parameters.AddWithValue("@Size", sizeText);
            getCurrentQuantityCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            getCurrentQuantityCommand.Parameters.AddWithValue("@Price", price);
            getCurrentQuantityCommand.Parameters.AddWithValue("@Security", security);

            int currentQuantity;

            try
            {
                currentQuantity = Convert.ToInt32(getCurrentQuantityCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении текущего количества товара из базы данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.CloseConnection();
                return;
            }

            // Удаляем строку из таблицы shopping_cart
            string deleteProductQuery = "DELETE FROM shopping_cart WHERE ProductName = @ProductName " +
                "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand deleteProductCommand = new MySqlCommand(deleteProductQuery, database.GetConnection());
            deleteProductCommand.Parameters.AddWithValue("@ProductName", productName);
            deleteProductCommand.Parameters.AddWithValue("@Size", sizeText);
            deleteProductCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            deleteProductCommand.Parameters.AddWithValue("@Price", price);
            deleteProductCommand.Parameters.AddWithValue("@Security", security);

            try
            {
                deleteProductCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении товара из корзины: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.CloseConnection();
                return;
            }

            // Открываем подключение к базе данных warehouse
            string warehouseUpdateQuery = "UPDATE warehouse SET Quantity = Quantity + @Quantity " +
                "WHERE ProductName = @ProductName AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            MySqlCommand warehouseUpdateCommand = new MySqlCommand(warehouseUpdateQuery, database.GetConnection());
            warehouseUpdateCommand.Parameters.AddWithValue("@Quantity", currentQuantity);
            warehouseUpdateCommand.Parameters.AddWithValue("@ProductName", productName);
            warehouseUpdateCommand.Parameters.AddWithValue("@Size", sizeText);
            warehouseUpdateCommand.Parameters.AddWithValue("@Manufacturer", manuf);
            warehouseUpdateCommand.Parameters.AddWithValue("@Price", price);
            warehouseUpdateCommand.Parameters.AddWithValue("@Security", security);

            try
            {
                warehouseUpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Товар успешно возвращен на склад", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении количества товара на складе: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            database.CloseConnection();
        }

        private void ClearShoppingCartButton_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных shopping_cart
            database.OpenConnection();

            // Проверяем наличие строк в таблице shopping_cart
            string shoppingCartCheckQuery = "SELECT COUNT(*) FROM shopping_cart";
            MySqlCommand shoppingCartCheckCommand = new MySqlCommand(shoppingCartCheckQuery, database.GetConnection());

            int rowCount = Convert.ToInt32(shoppingCartCheckCommand.ExecuteScalar());

            if (rowCount == 0)
            {
                MessageBox.Show("Корзина пустая", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.CloseConnection();
                return;
            }

            // Получаем строки из таблицы "shopping_cart"
            string getRowsQuery = "SELECT Quantity, ProductName, Manufacture, Size, Price, Security FROM shopping_cart";
            MySqlCommand getRowsCommand = new MySqlCommand(getRowsQuery, database.GetConnection());

            // Сохраняем строки в список
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            using (MySqlDataReader reader = getRowsCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dictionary<string, object> row = new Dictionary<string, object>();
                    row.Add("Quantity", reader["Quantity"]);
                    row.Add("ProductName", reader["ProductName"]);
                    row.Add("Manufacture", reader["Manufacture"]);
                    row.Add("Size", reader["Size"]);
                    row.Add("Price", reader["Price"]);
                    row.Add("Security", reader["Security"]);
                    rows.Add(row);
                }
            }

            // Удаляем каждую строку из таблицы shopping_cart
            string deleteRowsQuery = "DELETE FROM shopping_cart";
            MySqlCommand deleteRowsCommand = new MySqlCommand(deleteRowsQuery, database.GetConnection());

            try
            {
                deleteRowsCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении товаров из корзины: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.CloseConnection();
                return;
            }

            string updateWarehouseQuery = "UPDATE warehouse " +
                "SET Quantity = Quantity + @Quantity " +
                "WHERE ProductName = @ProductName " +
                "AND Manufacture = @Manufacture " +
                "AND Size = @Size " +
                "AND Price = @Price " +
                "AND Security = @Security";

            MySqlCommand updateWarehouseCommand = new MySqlCommand(updateWarehouseQuery, database.GetConnection());

            // Используем сохраненные строки для обновления склада
            foreach (var row in rows)
            {
                // Получаем значение Quantity из строки
                int quantity = Convert.ToInt32(row["Quantity"]);

                // Используем значение Quantity для обновления склада
                updateWarehouseCommand.Parameters.Clear();
                updateWarehouseCommand.Parameters.AddWithValue("@Quantity", quantity);
                updateWarehouseCommand.Parameters.AddWithValue("@ProductName", row["ProductName"]);
                updateWarehouseCommand.Parameters.AddWithValue("@Manufacture", row["Manufacture"]);
                updateWarehouseCommand.Parameters.AddWithValue("@Size", row["Size"]);
                updateWarehouseCommand.Parameters.AddWithValue("@Price", row["Price"]);
                updateWarehouseCommand.Parameters.AddWithValue("@Security", row["Security"]);

                try
                {
                    updateWarehouseCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при восстановлении товаров на склад: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    database.CloseConnection();
                    return;
                }
            }

            MessageBox.Show("Корзина успешно очищена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            database.CloseConnection();
        }

        System.Windows.Forms.Label QuantityWareHouseProductsLabel;
        System.Windows.Forms.TextBox QuantityWareHouseProductsField;

        System.Windows.Forms.Label CostWareHouseLabel;
        System.Windows.Forms.TextBox CostWareHouseField;

        private void OptionsWareHouseButton_Click(object sender, EventArgs e)
        {
            // Проверяем, созданы ли элементы
            if (!isElementsCreated)
            {
                QuantityWareHouseProductsLabel = new System.Windows.Forms.Label();

                QuantityWareHouseProductsLabel.Name = "QuantityWareHouseProductsLabel";
                QuantityWareHouseProductsLabel.Text = "Количество:";
                QuantityWareHouseProductsLabel.BorderStyle = BorderStyle.None;
                QuantityWareHouseProductsLabel.ForeColor = Color.White;
                QuantityWareHouseProductsLabel.FlatStyle = FlatStyle.Flat;
                QuantityWareHouseProductsLabel.Cursor = Cursors.Hand;
                QuantityWareHouseProductsLabel.BackgroundImageLayout = ImageLayout.Tile;
                QuantityWareHouseProductsLabel.BackColor = Color.FromArgb(128, 57, 30);
                QuantityWareHouseProductsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                QuantityWareHouseProductsLabel.TextAlign = ContentAlignment.MiddleCenter;
                QuantityWareHouseProductsLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                QuantityWareHouseProductsLabel.Size = new Size(140, 37);
                QuantityWareHouseProductsLabel.Visible = true;
                QuantityWareHouseProductsLabel.Location = new Point(850, 18);

                // Добавление label на форму
                AvtorPanel.Controls.Add(QuantityWareHouseProductsLabel);

                QuantityWareHouseProductsField = new System.Windows.Forms.TextBox();
                        
                QuantityWareHouseProductsField.Name = "QuantityWareHouseProductsField";
                QuantityWareHouseProductsField.BorderStyle = BorderStyle.None;
                QuantityWareHouseProductsField.ForeColor = Color.Black;
                QuantityWareHouseProductsField.Cursor = Cursors.IBeam;
                QuantityWareHouseProductsField.BackgroundImageLayout = ImageLayout.Tile;
                QuantityWareHouseProductsField.BackColor = Color.White;
                QuantityWareHouseProductsField.Anchor = AnchorStyles.Top;
                QuantityWareHouseProductsField.TextAlign = HorizontalAlignment.Center;
                QuantityWareHouseProductsField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                QuantityWareHouseProductsField.Size = new Size(100, 57);
                QuantityWareHouseProductsField.Visible = true;
                QuantityWareHouseProductsField.Location = new Point(990, 24);

                CountQuantityWareHouse();

                // Добавление label на форму
                AvtorPanel.Controls.Add(QuantityWareHouseProductsField);

                CostWareHouseLabel = new System.Windows.Forms.Label();
                    
                CostWareHouseLabel.Name = "CostWareHouseLabel";
                CostWareHouseLabel.Text = "Cтоимость:";
                CostWareHouseLabel.BorderStyle = BorderStyle.None;
                CostWareHouseLabel.ForeColor = Color.White;
                CostWareHouseLabel.FlatStyle = FlatStyle.Flat;
                CostWareHouseLabel.Cursor = Cursors.Hand;
                CostWareHouseLabel.BackgroundImageLayout = ImageLayout.Tile;
                CostWareHouseLabel.BackColor = Color.FromArgb(128, 57, 30);
                CostWareHouseLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                CostWareHouseLabel.TextAlign = ContentAlignment.MiddleCenter;
                CostWareHouseLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                CostWareHouseLabel.Size = new Size(140, 37);
                CostWareHouseLabel.Visible = true;
                CostWareHouseLabel.Location = new Point(845, 58);

                // Добавление label на форму
                AvtorPanel.Controls.Add(CostWareHouseLabel);

                CostWareHouseField = new System.Windows.Forms.TextBox();
                   
                CostWareHouseField.Name = "CostWareHouseField";
                CostWareHouseField.BorderStyle = BorderStyle.None;
                CostWareHouseField.ForeColor = Color.Black;
                CostWareHouseField.Cursor = Cursors.IBeam;
                CostWareHouseField.BackgroundImageLayout = ImageLayout.Tile;
                CostWareHouseField.BackColor = Color.White;
                CostWareHouseField.Anchor = AnchorStyles.Top;
                CostWareHouseField.TextAlign = HorizontalAlignment.Center;
                CostWareHouseField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                CostWareHouseField.Size = new Size(100, 57);
                CostWareHouseField.Visible = true;
                CostWareHouseField.Location = new Point(990, 64);

                CountCostWareHouse();

                AvtorPanel.Controls.Add(CostWareHouseField);

                // Устанавливаем флаг, что элементы были созданы
                isElementsCreated = true;
            }
            else
            {
                // Если элементы уже созданы, делаем их невидимыми
                QuantityWareHouseProductsLabel.Visible = false;
                QuantityWareHouseProductsField.Visible = false;

                CostWareHouseLabel.Visible = false;
                CostWareHouseField.Visible = false;

                isElementsCreated = false;
            }
        }

        // Метод для подсчета количества продуктов в корзине
        private void CountQuantityWareHouse()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных shopping_cart
            database.OpenConnection();

            // Создание SQL-запроса для получения количества строк в таблице shopping_cart
            string query = "SELECT COUNT(*) FROM warehouse";

            // Создание и выполнение команды для получения количества строк
            MySqlCommand command = new MySqlCommand(query, database.GetConnection());
            int quantity = Convert.ToInt32(command.ExecuteScalar());

            // Запись значения количества в текстовое поле
            QuantityWareHouseProductsField.Text = quantity.ToString();

            // Установка свойства ReadOnly для текстового поля, чтобы значение было невозможно изменить
            QuantityWareHouseProductsField.ReadOnly = true;

            database.CloseConnection();
        }

        // Метод для подсчета общей стоимости продуктов в корзине
        private void CountCostWareHouse()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных shopping_cart
            database.OpenConnection();

            // Создание SQL-запроса для получения общей стоимости продуктов
            string query = "SELECT Quantity, Price FROM warehouse";

            // Создание и выполнение команды для получения количества строк
            MySqlCommand command = new MySqlCommand(query, database.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            // Переменная для хранения общей стоимости
            decimal totalCost = 0;

            // Обход всех строк результата запроса
            while (reader.Read())
            {
                // Получение значений столбцов Quantity и Price текущей строки
                int quantity = reader.GetInt32("Quantity");
                decimal price = reader.GetDecimal("Price");

                // Подсчет стоимости текущей строки
                decimal rowCost = quantity * price;

                // Суммирование стоимости текущей строки с общей стоимостью
                totalCost += rowCost;
            }

            // Закрытие ридера
            reader.Close();

            // Запись общей стоимости в текстовое поле
            CostWareHouseField.Text = totalCost.ToString();

            // Установка свойства ReadOnly для текстового поля, чтобы значение было невозможно изменить
            CostWareHouseField.ReadOnly = true;

            database.CloseConnection();
        }

        System.Windows.Forms.Label QuantityCartProductsLabel;
        System.Windows.Forms.TextBox QuantityCartProductsField;

        System.Windows.Forms.Label CostCartLabel;
        System.Windows.Forms.TextBox CostCartField;

        private void OptionsCartButton_Click(object sender, EventArgs e)
        {
            // Проверяем, созданы ли элементы
            if (!isElementsCreated)
            {
                QuantityCartProductsLabel = new System.Windows.Forms.Label();

                QuantityCartProductsLabel.Name = "QuantityCartProductsLabel";
                QuantityCartProductsLabel.Text = "Количество:";
                QuantityCartProductsLabel.BorderStyle = BorderStyle.None;
                QuantityCartProductsLabel.ForeColor = Color.White;
                QuantityCartProductsLabel.FlatStyle = FlatStyle.Flat;
                QuantityCartProductsLabel.Cursor = Cursors.Hand;
                QuantityCartProductsLabel.BackgroundImageLayout = ImageLayout.Tile;
                QuantityCartProductsLabel.BackColor = Color.FromArgb(128, 57, 30);
                QuantityCartProductsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                QuantityCartProductsLabel.TextAlign = ContentAlignment.MiddleCenter;
                QuantityCartProductsLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                QuantityCartProductsLabel.Size = new Size(140, 37);
                QuantityCartProductsLabel.Visible = true;
                QuantityCartProductsLabel.Location = new Point(850, 18);

                // Добавление label на форму
                AvtorPanel.Controls.Add(QuantityCartProductsLabel);

                QuantityCartProductsField = new System.Windows.Forms.TextBox();
                        
                QuantityCartProductsField.Name = "QuantityCartProductsField";
                QuantityCartProductsField.BorderStyle = BorderStyle.None;
                QuantityCartProductsField.ForeColor = Color.Black;
                QuantityCartProductsField.Cursor = Cursors.IBeam;
                QuantityCartProductsField.BackgroundImageLayout = ImageLayout.Tile;
                QuantityCartProductsField.BackColor = Color.White;
                QuantityCartProductsField.Anchor = AnchorStyles.Top;
                QuantityCartProductsField.TextAlign = HorizontalAlignment.Center;
                QuantityCartProductsField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                QuantityCartProductsField.Size = new Size(100, 57);
                QuantityCartProductsField.Visible = true;
                QuantityCartProductsField.Location = new Point(990, 24);

                CountQuantityCart();

                // Добавление label на форму
                AvtorPanel.Controls.Add(QuantityCartProductsField);

                CostCartLabel = new System.Windows.Forms.Label();

                CostCartLabel.Name = "CostCartLabel";
                CostCartLabel.Text = "Cтоимость:";
                CostCartLabel.BorderStyle = BorderStyle.None;
                CostCartLabel.ForeColor = Color.White;
                CostCartLabel.FlatStyle = FlatStyle.Flat;
                CostCartLabel.Cursor = Cursors.Hand;
                CostCartLabel.BackgroundImageLayout = ImageLayout.Tile;
                CostCartLabel.BackColor = Color.FromArgb(128, 57, 30);
                CostCartLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                CostCartLabel.TextAlign = ContentAlignment.MiddleCenter;
                CostCartLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                CostCartLabel.Size = new Size(140, 37);
                CostCartLabel.Visible = true;
                CostCartLabel.Location = new Point(845, 58);

                // Добавление label на форму
                AvtorPanel.Controls.Add(CostCartLabel);

                CostCartField = new System.Windows.Forms.TextBox();

                CostCartField.Name = "CostCartField";
                CostCartField.BorderStyle = BorderStyle.None;
                CostCartField.ForeColor = Color.Black;
                CostCartField.Cursor = Cursors.IBeam;
                CostCartField.BackgroundImageLayout = ImageLayout.Tile;
                CostCartField.BackColor = Color.White;
                CostCartField.Anchor = AnchorStyles.Top;
                CostCartField.TextAlign = HorizontalAlignment.Center;
                CostCartField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                CostCartField.Size = new Size(100, 57);
                CostCartField.Visible = true;
                CostCartField.Location = new Point(990, 64);

                CountCostCart();

                AvtorPanel.Controls.Add(CostCartField);

                // Устанавливаем флаг, что элементы были созданы
                isElementsCreated = true;
            }
            else
            {
                // Если элементы уже созданы, делаем их невидимыми
                QuantityCartProductsLabel.Visible = false;
                QuantityCartProductsField.Visible = false;

                CostCartLabel.Visible = false;
                CostCartField.Visible = false;

                isElementsCreated = false;
            }
        }

        // Метод для подсчета количества продуктов в корзине
        private void CountQuantityCart()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных shopping_cart
            database.OpenConnection();

            // Создание SQL-запроса для получения количества строк в таблице shopping_cart
            string query = "SELECT COUNT(*) FROM shopping_cart";

            // Создание и выполнение команды для получения количества строк
            MySqlCommand command = new MySqlCommand(query, database.GetConnection());
            int quantity = Convert.ToInt32(command.ExecuteScalar());

            // Запись значения количества в текстовое поле
            QuantityCartProductsField.Text = quantity.ToString();

            // Установка свойства ReadOnly для текстового поля, чтобы значение было невозможно изменить
            QuantityCartProductsField.ReadOnly = true;

            database.CloseConnection();
        }

        // Метод для подсчета общей стоимости продуктов в корзине
        private void CountCostCart()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных shopping_cart
            database.OpenConnection();

            // Создание SQL-запроса для получения общей стоимости продуктов
            string query = "SELECT Quantity, Price FROM shopping_cart";

            // Создание и выполнение команды для получения количества строк
            MySqlCommand command = new MySqlCommand(query, database.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            // Переменная для хранения общей стоимости
            decimal totalCost = 0;

            // Обход всех строк результата запроса
            while (reader.Read())
            {
                // Получение значений столбцов Quantity и Price текущей строки
                int quantity = reader.GetInt32("Quantity");
                decimal price = reader.GetDecimal("Price");

                // Подсчет стоимости текущей строки
                decimal rowCost = quantity * price;

                // Суммирование стоимости текущей строки с общей стоимостью
                totalCost += rowCost;
            }

            // Закрытие ридера
            reader.Close();

            // Запись общей стоимости в текстовое поле
            CostCartField.Text = totalCost.ToString();

            // Установка свойства ReadOnly для текстового поля, чтобы значение было невозможно изменить
            CostCartField.ReadOnly = true;

            database.CloseConnection();
        }

        System.Windows.Forms.Button PayButton;

        System.Windows.Forms.Label PayCartLabel;
        System.Windows.Forms.TextBox PayCartField;

        private void PayCartButton_Click(object sender, EventArgs e)
        {
            // Проверяем, созданы ли элементы
            if (!isElementsCreated)
            {
                PayButton = new System.Windows.Forms.Button();
                
                PayButton.Name = "PayButton";
                PayButton.Text = "Произвести оплату";
                PayButton.ForeColor = Color.White;
                PayButton.FlatStyle = FlatStyle.Flat;
                PayButton.Cursor = Cursors.Hand;
                PayButton.BackgroundImageLayout = ImageLayout.Tile;
                PayButton.BackColor = Color.FromArgb(3, 10, 103);
                PayButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                PayButton.TextAlign = ContentAlignment.MiddleCenter;
                PayButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
                PayButton.Size = new Size(156, 57);
                PayButton.Visible = true;
                PayButton.Location = new Point(920, 60);

                // Добавление обработчика события нажатия на кнопку сохранения товара
                PayButton.Click += PayButton_Click;

                // Добавление кнопки на форму
                AvtorPanel.Controls.Add(PayButton);

                PayCartLabel = new System.Windows.Forms.Label();
                
                PayCartLabel.Name = "PayCartLabel";
                PayCartLabel.Text = "Ваш баланс:";
                PayCartLabel.BorderStyle = BorderStyle.None;
                PayCartLabel.ForeColor = Color.White;
                PayCartLabel.FlatStyle = FlatStyle.Flat;
                PayCartLabel.Cursor = Cursors.Hand;
                PayCartLabel.BackgroundImageLayout = ImageLayout.Tile;
                PayCartLabel.BackColor = Color.FromArgb(128, 57, 30);
                PayCartLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                PayCartLabel.TextAlign = ContentAlignment.MiddleCenter;
                PayCartLabel.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PayCartLabel.Size = new Size(140, 37);
                PayCartLabel.Visible = true;
                PayCartLabel.Location = new Point(860, 18);

                // Добавление label на форму
                AvtorPanel.Controls.Add(PayCartLabel);

                PayCartField = new System.Windows.Forms.TextBox();
                
                PayCartField.Name = "PayCartField";
                PayCartField.BorderStyle = BorderStyle.None;
                PayCartField.ForeColor = Color.Black;
                PayCartField.Cursor = Cursors.IBeam;
                PayCartField.BackgroundImageLayout = ImageLayout.Tile;
                PayCartField.BackColor = Color.White;
                PayCartField.Anchor = AnchorStyles.Top;
                PayCartField.TextAlign = HorizontalAlignment.Center;
                PayCartField.Font = new Font("Times New Roman", 13.8f, FontStyle.Bold);
                PayCartField.Size = new Size(100, 57);
                PayCartField.Visible = true;
                PayCartField.Location = new Point(1000, 24);

                // Добавление textbox на форму
                AvtorPanel.Controls.Add(PayCartField);

                // Устанавливаем флаг, что элементы были созданы
                isElementsCreated = true;
            }
            else
            {
                PayButton.Visible = false;

                // Если элементы уже созданы, делаем их невидимыми
                PayCartLabel.Visible = false;
                PayCartField.Visible = false;

                isElementsCreated = false;
            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных shopping_cart
            database.OpenConnection();

            // Создание SQL-запроса для получения суммы покупок
            string query = "SELECT Quantity, Price FROM shopping_cart";

            // Создание и выполнение команды для получения данных
            MySqlCommand command = new MySqlCommand(query, database.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            // Переменные для хранения суммы покупок и суммы оплаты
            decimal totalCost = 0;
            decimal payment = 0;

            // Обход всех строк результата запроса
            while (reader.Read())
            {
                // Получение значений столбцов Quantity и Price текущей строки
                int quantity = reader.GetInt32("Quantity");
                decimal price = reader.GetDecimal("Price");

                // Подсчет стоимости текущей строки
                decimal rowCost = quantity * price;

                // Суммирование стоимости текущей строки с общей суммой покупок
                totalCost += rowCost;
            }

            // Закрываем ридер
            reader.Close();

            // Проверка наличия продуктов в корзине
            if (totalCost == 0)
            {
                MessageBox.Show("Корзина пустая");
            }
            else
            {
                // Получение значения оплаты из поля PayCartField и проверка формата
                if (!decimal.TryParse(PayCartField.Text, out payment))
                {
                    MessageBox.Show("Неверный формат баланса");
                }
                else
                {
                    if (totalCost > payment)
                    {
                        // Выводим сообщение "Недостаточно средств на балансе"
                        MessageBox.Show("На балансе недостаточно средств");
                    }
                    else
                    {
                        // Подсчет сдачи
                        decimal change = payment - totalCost;

                        // Выводим сообщение "Покупка успешно завершена" с информацией о сдаче
                        MessageBox.Show("Покупка успешно завершена. Сдача: " + change.ToString());
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }
    }
}
   