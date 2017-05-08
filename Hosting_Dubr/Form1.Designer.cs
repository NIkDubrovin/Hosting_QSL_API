namespace Hosting_Dubr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetAllStudents = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteById = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxAge = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.buttonDeleteTable = new System.Windows.Forms.Button();
            this.buttonClearAddNewStudentsFiiekds = new System.Windows.Forms.Button();
            this.buttonUpdateStudents = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label12345 = new System.Windows.Forms.Label();
            this.label1234567 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetAllStudents
            // 
            this.buttonGetAllStudents.Location = new System.Drawing.Point(6, 237);
            this.buttonGetAllStudents.Name = "buttonGetAllStudents";
            this.buttonGetAllStudents.Size = new System.Drawing.Size(435, 39);
            this.buttonGetAllStudents.TabIndex = 0;
            this.buttonGetAllStudents.Text = "Получить данные";
            this.buttonGetAllStudents.UseVisualStyleBackColor = true;
            this.buttonGetAllStudents.Click += new System.EventHandler(this.buttonGetAllStudents_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewStudents.Location = new System.Drawing.Point(6, 33);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(643, 198);
            this.dataGridViewStudents.TabIndex = 1;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "First_Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Last_Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sex";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Age";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Description";
            this.Column6.Name = "Column6";
            // 
            // buttonDeleteById
            // 
            this.buttonDeleteById.Location = new System.Drawing.Point(460, 237);
            this.buttonDeleteById.Name = "buttonDeleteById";
            this.buttonDeleteById.Size = new System.Drawing.Size(184, 23);
            this.buttonDeleteById.TabIndex = 2;
            this.buttonDeleteById.Text = "Удалить Студента";
            this.buttonDeleteById.UseVisualStyleBackColor = true;
            this.buttonDeleteById.Click += new System.EventHandler(this.buttonDeleteById_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(28, 441);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(54, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LastTime";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(6, 466);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(125, 466);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 7;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxSex.Location = new System.Drawing.Point(246, 466);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sex";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(505, 467);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            // 
            // maskedTextBoxAge
            // 
            this.maskedTextBoxAge.Location = new System.Drawing.Point(386, 466);
            this.maskedTextBoxAge.Mask = "00000";
            this.maskedTextBoxAge.Name = "maskedTextBoxAge";
            this.maskedTextBoxAge.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxAge.TabIndex = 13;
            this.maskedTextBoxAge.ValidatingType = typeof(int);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(116, 503);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(384, 31);
            this.buttonAddStudent.TabIndex = 14;
            this.buttonAddStudent.Text = "Добавить Студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Location = new System.Drawing.Point(13, 283);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(109, 23);
            this.buttonDeleteAll.TabIndex = 15;
            this.buttonDeleteAll.Text = "Очистить таблицу";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(666, 33);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTable.TabIndex = 16;
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.Location = new System.Drawing.Point(666, 60);
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.Size = new System.Drawing.Size(121, 28);
            this.buttonDeleteTable.TabIndex = 17;
            this.buttonDeleteTable.Text = "Удалить Таблицу";
            this.buttonDeleteTable.UseVisualStyleBackColor = true;
            this.buttonDeleteTable.Click += new System.EventHandler(this.buttonDeleteTable_Click);
            // 
            // buttonClearAddNewStudentsFiiekds
            // 
            this.buttonClearAddNewStudentsFiiekds.Location = new System.Drawing.Point(6, 351);
            this.buttonClearAddNewStudentsFiiekds.Name = "buttonClearAddNewStudentsFiiekds";
            this.buttonClearAddNewStudentsFiiekds.Size = new System.Drawing.Size(196, 23);
            this.buttonClearAddNewStudentsFiiekds.TabIndex = 20;
            this.buttonClearAddNewStudentsFiiekds.Text = "Очистить Поля Ввода";
            this.buttonClearAddNewStudentsFiiekds.UseVisualStyleBackColor = true;
            this.buttonClearAddNewStudentsFiiekds.Click += new System.EventHandler(this.buttonClearAddNewStudentsFiiekds_Click);
            // 
            // buttonUpdateStudents
            // 
            this.buttonUpdateStudents.Location = new System.Drawing.Point(216, 351);
            this.buttonUpdateStudents.Name = "buttonUpdateStudents";
            this.buttonUpdateStudents.Size = new System.Drawing.Size(131, 23);
            this.buttonUpdateStudents.TabIndex = 21;
            this.buttonUpdateStudents.Text = "Обновить студента";
            this.buttonUpdateStudents.UseVisualStyleBackColor = true;
            this.buttonUpdateStudents.Click += new System.EventHandler(this.buttonUpdateStudents_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(617, 466);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(38, 20);
            this.textBoxId.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "id";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(813, 34);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(210, 20);
            this.textBoxFind.TabIndex = 24;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(877, 60);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(243, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Работа с таблицей";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label77.Location = new System.Drawing.Point(213, 412);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(228, 16);
            this.label77.TabIndex = 28;
            this.label77.Text = "Добавление нового студента";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label123.Location = new System.Drawing.Point(650, 9);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(150, 16);
            this.label123.TabIndex = 29;
            this.label123.Text = "Удаление Таблицы";
            // 
            // label12345
            // 
            this.label12345.AutoSize = true;
            this.label12345.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12345.Location = new System.Drawing.Point(874, 9);
            this.label12345.Name = "label12345";
            this.label12345.Size = new System.Drawing.Size(53, 16);
            this.label12345.TabIndex = 30;
            this.label12345.Text = "Поиск";
            // 
            // label1234567
            // 
            this.label1234567.AutoSize = true;
            this.label1234567.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1234567.Location = new System.Drawing.Point(88, 322);
            this.label1234567.Name = "label1234567";
            this.label1234567.Size = new System.Drawing.Size(210, 16);
            this.label1234567.TabIndex = 31;
            this.label1234567.Text = "Изменить инфо о студенте";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 538);
            this.Controls.Add(this.label1234567);
            this.Controls.Add(this.label12345);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonUpdateStudents);
            this.Controls.Add(this.buttonClearAddNewStudentsFiiekds);
            this.Controls.Add(this.buttonDeleteTable);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.maskedTextBoxAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.buttonDeleteById);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.buttonGetAllStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetAllStudents;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button buttonDeleteById;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAge;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Button buttonDeleteTable;
        private System.Windows.Forms.Button buttonClearAddNewStudentsFiiekds;
        private System.Windows.Forms.Button buttonUpdateStudents;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label12345;
        private System.Windows.Forms.Label label1234567;
    }
}

