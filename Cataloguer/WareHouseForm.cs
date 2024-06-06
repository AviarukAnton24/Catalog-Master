using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Cataloguer
{
    public partial class WareHouseForm : Form
    {
        public WareHouseForm()
        {
            InitializeComponent();

            SearchField.Text = "Найти товар";
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

            // Добавление обработчика события нажатия на кнопку очищения товара
            ClearButton.Click += ClearButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(ClearButton);

            System.Windows.Forms.Button OptionsWareHouseButton = new System.Windows.Forms.Button();

            OptionsWareHouseButton.Text = "OptionsWareHouseButtton";
            OptionsWareHouseButton.Text = "Параметры склада";
            OptionsWareHouseButton.ForeColor = Color.White;
            OptionsWareHouseButton.FlatStyle = FlatStyle.Flat;
            OptionsWareHouseButton.Cursor = Cursors.Hand;
            OptionsWareHouseButton.BackgroundImageLayout = ImageLayout.Tile;
            OptionsWareHouseButton.BackColor = Color.FromArgb(3, 10, 103);
            OptionsWareHouseButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            OptionsWareHouseButton.TextAlign = ContentAlignment.MiddleCenter;
            OptionsWareHouseButton.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            OptionsWareHouseButton.Size = new Size(156, 57);
            OptionsWareHouseButton.Visible = true;
            OptionsWareHouseButton.Location = new Point(465, 310);

            OptionsWareHouseButton.Click += OptionsWareHouseButton_Click;

            // Добавление кнопки на форму
            AvtorPanel.Controls.Add(OptionsWareHouseButton);

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
            if (SearchField.Text == "Найти товар")
            {
                SearchField.Text = "";
                SearchField.ForeColor = Color.Black;
            }
        }

        private void SearchText_Leave(object sender, EventArgs e)
        {
            if (SearchField.Text == "")
            {
                SearchField.Text = "Найти товар";
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
            string query = "SELECT * FROM warehouse WHERE BINARY ProductName LIKE @searchString";

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

                        // Получаем название товара из текущей строки
                        string name = reader["ProductName"].ToString();
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
            string query = "SELECT * FROM warehouse";

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
                        case "Названию":
                            SortByProductName();
                            break;
                        case "Количеству":
                            SortByQuantity();
                            break;
                        case "Размеру":
                            SortBySize();
                            break;
                        case "Производителю":
                            SortByManufacture();
                            break;
                        case "Цене":
                            SortByPrice();
                            break;
                        case "Сроку гарантии":
                            SortBySecurity();
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

        private void SortByProductName()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            string query = "SELECT * FROM warehouse ORDER BY ProductName ASC";
            ExecuteQueryAndUpdateDataGridView(query);

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void SortByQuantity()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            string query = "SELECT * FROM warehouse ORDER BY CAST(Quantity AS SIGNED) DESC";
            ExecuteQueryAndUpdateDataGridView(query);

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void SortBySize()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            string query = "SELECT * FROM warehouse ORDER BY CAST(Size AS SIGNED) DESC";
            ExecuteQueryAndUpdateDataGridView(query);

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void SortByManufacture()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            string query = "SELECT * FROM warehouse ORDER BY Manufacture ASC";
            ExecuteQueryAndUpdateDataGridView(query);

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void SortByPrice()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            string query = "SELECT * FROM warehouse ORDER BY CAST(Price AS SIGNED) DESC";
            ExecuteQueryAndUpdateDataGridView(query);

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void SortBySecurity()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            string query = "SELECT * FROM warehouse ORDER BY CAST(Security AS SIGNED) DESC";
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
                ProductNameLabel.Location = new Point(640, 18);

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
                ProductNameField.Location = new Point(750, 24);

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
                QuantityLabel.Location = new Point(640, 58);

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
                QuantityField.Location = new Point(770, 64);

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
                ManufactureLabel.Location = new Point(640, 98);

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
                ManufactureField.Location = new Point(810, 104);

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
                SizeLabel.Location = new Point(640, 138);

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
                SizeField.Location = new Point(740, 144);

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
                PriceLabel.Location = new Point(630, 178);

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
                PriceField.Location = new Point(730, 184);

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
                SecurityLabel.Location = new Point(620, 218);

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
                SecurityField.Location = new Point(820, 224);

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

            // Открываем подключение к базе данных
            database.OpenConnection();

            bool productFound = ProductExists(database.GetConnection(), productName, sizeText, manuf, price, security);

            if (productFound)
            {
                // Обновление существующей строки с добавлением значения Quantity
                UpdateProductQuantity(database.GetConnection(), productName, sizeText, manuf, quantity);
                MessageBox.Show("Товар успешно обновлен");
            }
            else
            {
                // Добавление нового товара в базу данных
                AddNewProduct(database.GetConnection(), productName, quantity, sizeText, manuf, price, security);
                MessageBox.Show("Товар успешно добавлен");
            }

            // Закрываем соединение с базой данных
            database.CloseConnection();

            // Обновите DataGridView без фильтрации, чтобы загрузить все данные из базы данных
            RefreshDataGridView();
        }

        private bool ProductExists(MySqlConnection connection, string productName, string size, string manuf, decimal price, int security)
        {
            string query = "SELECT * FROM warehouse WHERE ProductName = @productName AND Size = @size AND Manufacture = @manuf AND Price = @price AND Security = @security";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@size", size);
                command.Parameters.AddWithValue("@manuf", manuf);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@security", security);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        private void UpdateProductQuantity(MySqlConnection connection, string productName, string size, string manuf, int quantity)
        {
            string query = "UPDATE warehouse SET Quantity = Quantity + @quantity WHERE ProductName = @productName AND Size = @size AND Manufacture = @manuf";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@size", size);
                command.Parameters.AddWithValue("@manuf", manuf);

                command.ExecuteNonQuery();
            }
        }

        private void AddNewProduct(MySqlConnection connection, string productName, int quantity, string size, string manuf, decimal price, int security)
        {
            string query = "INSERT INTO warehouse (ProductName, Quantity, Size, Manufacture, Price, Security) VALUES (@productName, @quantity, @size, @manuf, @price, @security)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@size", size);
                command.Parameters.AddWithValue("@manuf", manuf);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@security", security);

                command.ExecuteNonQuery();
            }
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
                ProductNameLabel.Location = new Point(640, 18);

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
                ProductNameField.Location = new Point(750, 24);

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
                QuantityLabel.Location = new Point(640, 58);

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
                QuantityField.Location = new Point(770, 64);

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
                ManufactureLabel.Location = new Point(640, 98);

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
                ManufactureField.Location = new Point(810, 104);

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
                SizeLabel.Location = new Point(640, 138);

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
                SizeField.Location = new Point(740, 144);

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
                PriceLabel.Location = new Point(630, 178);

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
                PriceField.Location = new Point(730, 184);

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
                SecurityLabel.Location = new Point(620, 218);

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
                SecurityField.Location = new Point(820, 224);

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

            // Открываем подключение к базе данных
            database.OpenConnection();

            bool productFound = ProductExists(database.GetConnection(), productName, sizeText, manuf, price, security);

            if (productFound)
            {
                // Обновление существующей строки с добавлением значения Quantity
                if (CheckProductQuantity(database.GetConnection(), productName, quantity, sizeText, manuf, price, security))
                {
                    UpdateQuantityProduct(database.GetConnection(), productName, sizeText, manuf, quantity);
                    MessageBox.Show("Часть товара успешно удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            else
            {
                MessageBox.Show("Товар не найден");
            }

            // Закрываем соединение с базой данных
            database.CloseConnection();

            // Обновите DataGridView без фильтрации, чтобы загрузить все данные из базы данных
            RefreshDataGridView();
        }

        private bool CheckProductQuantity(MySqlConnection connection, string productName, int quantity, string size, string manuf, decimal price, int security)
        {
            // Проверка, что считанное количество меньше количества в базе данных
            string query = "SELECT Quantity FROM warehouse WHERE ProductName = @ProductName " +
                "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Size", size);
                command.Parameters.AddWithValue("@Manufacturer", manuf);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Security", security);

                int quantityInDB = Convert.ToInt32(command.ExecuteScalar());

                if (quantity > quantityInDB)
                {
                    MessageBox.Show("Количество товара должно быть меньше существующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
        }

        private void UpdateQuantityProduct(MySqlConnection connection, string productName, string size, string manuf, int quantity)
        {
            string query = "UPDATE warehouse SET Quantity = Quantity - @quantity WHERE ProductName = @productName AND Size = @size AND Manufacture = @manuf";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@size", size);
                command.Parameters.AddWithValue("@manuf", manuf);

                command.ExecuteNonQuery();
            }
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
                ProductNameLabel.Location = new Point(640, 18);

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
                ProductNameField.Location = new Point(750, 24);

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
                ManufactureLabel.Location = new Point(640, 58);

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
                ManufactureField.Location = new Point(810, 64);

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
                SizeLabel.Location = new Point(640, 98);

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
                SizeField.Location = new Point(740, 104);

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
                PriceLabel.Location = new Point(630, 138);

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
                PriceField.Location = new Point(730, 144);

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
                SecurityLabel.Location = new Point(620, 178);

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
                SecurityField.Location = new Point(820, 184);

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

            // Открываем подключение к базе данных
            database.OpenConnection();

            bool productFound = ProductExists(database.GetConnection(), productName, sizeText, manuf, price, security);

            if (productFound)
            {
                // Удаление существующей строки товара
                DeleteProduct(database.GetConnection(), productName, sizeText, manuf, price, security);
            }
            else
            {
                MessageBox.Show("Товар не найден");
            }

            // Закрываем соединение с базой данных
            database.CloseConnection();

            // Обновите DataGridView без фильтрации, чтобы загрузить все данные из базы данных
            RefreshDataGridView();
        }

        private void DeleteProduct(MySqlConnection connection, string productName, string size, string manuf, decimal price, int security)
        {
            string query = "DELETE FROM warehouse WHERE ProductName = @ProductName " +
                "AND Size = @Size AND Manufacture = @Manufacturer AND Price = @Price AND Security = @Security";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Size", size);
                command.Parameters.AddWithValue("@Manufacturer", manuf);
                command.Parameters.AddWithValue("@Price", price.ToString());
                command.Parameters.AddWithValue("@Security", security.ToString());

                command.ExecuteNonQuery();

                MessageBox.Show("Товар успешно удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                QuantityWareHouseProductsLabel.Location = new Point(650, 18);

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
                QuantityWareHouseProductsField.Location = new Point(790, 24);

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
                CostWareHouseLabel.Location = new Point(645, 58);

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
                CostWareHouseField.Location = new Point(790, 64);

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
    }
}
