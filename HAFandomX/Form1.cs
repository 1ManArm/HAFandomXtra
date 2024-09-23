using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

namespace HAFandomX
{
    public partial class Form1 : Form
    {
        private string dbName = "test02";
        public Form1()
        {
            InitializeComponent();
            CreateDatabase();
            LoadData();
        }
        private void CreateDatabase()
        {
            using (var conn = new SQLiteConnection($"Data Source={dbName};"))
            {
                conn.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Category (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Time TEXT NOT NULL
                    );";
                using (var cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void LoadData()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbName};"))
            {
                string selectQuery = "SELECT * FROM Category;";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView.DataSource = table;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                labelMessage.Text = "Имя не должно быть пустым!";
                return;
            }

            AddData(name);
            LoadData();
            labelMessage.Text = "Имя добавлено!";
            textBoxName.Clear();
        }
        private void AddData(string name)
        {
            string currentTime = DateTime.Now.ToString("yyyyMMdd-HH:mm", CultureInfo.InvariantCulture);
            string insertQuery = $"INSERT INTO Category (Name, Time) VALUES ('{name}', '{currentTime}');";

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbName};"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView.Rows[selectedIndex].Cells[0].Value);
                DeleteData(id);
                LoadData();
                labelMessage.Text = "Запись удалена!";
            }
            else
            {
                labelMessage.Text = "Выберите запись для удаления!";
            }
        }
        private void DeleteData(int id)
        {
            string deleteQuery = $"DELETE FROM Category WHERE Id = {id};";

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbName};"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView.Rows[selectedIndex].Cells[0].Value);
                string newName = textBoxName.Text.Trim();

                if (string.IsNullOrEmpty(newName))
                {
                    labelMessage.Text = "Имя не должно быть пустым!";
                    return;
                }

                EditData(id, newName);
                LoadData();
                labelMessage.Text = "Запись обновлена!";
                textBoxName.Clear();
            }
            else
            {
                labelMessage.Text = "Выберите запись для редактирования!";
            }
        }
        private void EditData(int id, string newName)
        {
            string updateQuery = $"UPDATE Category SET Name = '{newName}' WHERE Id = {id};";

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbName};"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();
            SearchData(searchTerm);
        }
        private void SearchData(string searchTerm)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbName};"))
            {
                string selectQuery = $"SELECT * FROM Category WHERE Name LIKE '%{searchTerm}%';";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView.DataSource = table;
                }
            }
        }

        private void buttonOpenDB_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQLite Database|*.db;*.sqlite|All files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dbName = openFileDialog.FileName;
                    labelMessage.Text = "База данных выбрана: " + dbName;
                }
            }
        }

        private void buttonExecuteSql_Click(object sender, EventArgs e)
        {
            string sqlQuery = textBoxSqlQuery.Text.Trim();

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbName};"))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                        labelMessage.Text = "Запрос выполнен успешно.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка выполнения запроса: " + ex.Message);
                }
            }
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbName};"))
            {
                string selectQuery = "SELECT * FROM Category;";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView.DataSource = table;
                }
            }
        }
    }
}
