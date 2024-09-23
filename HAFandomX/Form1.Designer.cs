namespace HAFandomX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            textBoxName = new TextBox();
            buttonAdd = new Button();
            labelMessage = new Label();
            buttonDelete = new Button();
            buttonEdit = new Button();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonOpenDB = new Button();
            buttonExecuteSql = new Button();
            buttonLoadData = new Button();
            textBoxSqlQuery = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(57, 52);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(905, 353);
            dataGridView.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(57, 411);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(248, 70);
            textBoxName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(57, 487);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(311, 411);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(50, 20);
            labelMessage.TabIndex = 3;
            labelMessage.Text = "label1";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(57, 522);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(126, 29);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(57, 557);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(126, 29);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(499, 411);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(239, 70);
            textBoxSearch.TabIndex = 6;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(499, 487);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(126, 29);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Искать";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonOpenDB
            // 
            buttonOpenDB.Location = new Point(804, 411);
            buttonOpenDB.Name = "buttonOpenDB";
            buttonOpenDB.Size = new Size(158, 29);
            buttonOpenDB.TabIndex = 8;
            buttonOpenDB.Text = "Выбрать БД";
            buttonOpenDB.UseVisualStyleBackColor = true;
            buttonOpenDB.Click += buttonOpenDB_Click;
            // 
            // buttonExecuteSql
            // 
            buttonExecuteSql.Location = new Point(804, 446);
            buttonExecuteSql.Name = "buttonExecuteSql";
            buttonExecuteSql.Size = new Size(158, 29);
            buttonExecuteSql.TabIndex = 9;
            buttonExecuteSql.Text = "Выполнить запрос";
            buttonExecuteSql.UseVisualStyleBackColor = true;
            buttonExecuteSql.Click += buttonExecuteSql_Click;
            // 
            // buttonLoadData
            // 
            buttonLoadData.Location = new Point(804, 481);
            buttonLoadData.Name = "buttonLoadData";
            buttonLoadData.Size = new Size(158, 29);
            buttonLoadData.TabIndex = 10;
            buttonLoadData.Text = "Загрузить БД";
            buttonLoadData.UseVisualStyleBackColor = true;
            buttonLoadData.Click += buttonLoadData_Click;
            // 
            // textBoxSqlQuery
            // 
            textBoxSqlQuery.Location = new Point(499, 523);
            textBoxSqlQuery.Multiline = true;
            textBoxSqlQuery.Name = "textBoxSqlQuery";
            textBoxSqlQuery.Size = new Size(239, 70);
            textBoxSqlQuery.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 605);
            Controls.Add(textBoxSqlQuery);
            Controls.Add(buttonLoadData);
            Controls.Add(buttonExecuteSql);
            Controls.Add(buttonOpenDB);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(labelMessage);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxName);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox textBoxName;
        private Button buttonAdd;
        private Label labelMessage;
        private Button buttonDelete;
        private Button buttonEdit;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonOpenDB;
        private Button buttonExecuteSql;
        private Button buttonLoadData;
        private TextBox textBoxSqlQuery;
    }
}
