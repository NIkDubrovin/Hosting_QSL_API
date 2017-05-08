using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hosting_Dubr
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<Student> students;
        List<Table> tables;

        /*
         *                                  Вспомогательные методы
         *  ***************************************************************************                                
         *                                    GetAllStudents()
         *  Чистим  dataGridViewStudents
         *  В students записываем параметры, которые получили от QSL сервера
         *  Записываем это в dataGridViewStudents
         *  ****************************************************************************
         *                                    DeleteById()
         *  Проверка - если ничего не выбрано, то возвращаем один раз MessageBox             
         *  В string id записываем данные из ячеек, выбранные пользователем      
         *  Передаем id в StudentsDeleteByid()
         *  Которое возвратил WebClient и принял скрипт
         *  Пробегаемся по данным, полученным от QSL сервера, но уже без удаленной колонки таблицы        
         *  ***************************************************************************************
         *                                    ClearAddNewsStudentFields()
         *  Чистим некоторые элементы WindowForm      
         *  *********************************************************************************         
         *                                    AddNewsStudent()
         *  Если какой-то из элементов WindowForm пуст возвращаем messageBox                            
         *  Инициализируем новый элемент класса Students для хранения данных                                    
         *  Передаем в элементы нового объекта класса Students данные из элементов WindowForm                           
         *  Передаем этот объект(данные) в StudentsInsertNewsStudent(), которая затем отправляет их на сервер QSL  - WebClient возвращает url и при помощи скрипта.php
         *  Чистим место в таблице
         *  Пробегаемся по данным, полученным от QSL сервера, но уже с новой колонкой       
         *  ********************************************************************************************
         *  buttonGetAllStudents_Click()  --------------------------|
         *  buttonDeleteById_Click()                                 --------------  Передаем функции в buttons
         *  buttonAddStudent_Click()     ---------------------------|                 
         */
        #region Работа с API  

        private void GetAllStudents()
        {
            dataGridViewStudents.Rows.Clear();
             students = Hosting_QSL_API.StudentsSelectAll();

            foreach (Student student in students)
            {
                dataGridViewStudents.Rows.Add
                    (
                    student.Id, student.FirstName, student.LastName, student.Sex == 1 ? "Мужской" : "Женский", student.Age, student.Description
                    );
            }
        }
        private void DeleteById()
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите студента");
                return;
            }

            string id = dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString();

            Hosting_QSL_API.StudentsDeleteByid(id);
            GetAllStudents();
        }

        private void DeleteALL()
        {
            Hosting_QSL_API.StudentsDeleteAll();
            dataGridViewStudents.Rows.Clear();
            MessageBox.Show("Таблица очищена успешно");
        }

        private void DeleteTable()
        {
            string NameTable = comboBoxTable.SelectedItem.ToString();

            Hosting_QSL_API.StudentsDeleteTable(NameTable);
            MessageBox.Show("Таблица удалена успешно");
        }

        private void Get_Name_Tables()
        {
            comboBoxTable.Items.Clear();
            comboBoxTable.SelectedIndex = -1;
            
            tables = Hosting_QSL_API.StudentsShowTable();

            foreach (Table table in tables)
            {
                comboBoxTable.Items.Add(table.NameTable);
            }
        }

        private void ClearAddNewsStudentFields()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            comboBoxSex.SelectedIndex = -1;
            maskedTextBoxAge.Clear();
            textBoxDescription.Clear();
            textBoxId.Clear();
        }

        private void AddNewsStudent()
        {
            if (
            textBoxFirstName.Text == String.Empty ||
            textBoxLastName.Text == String.Empty ||
            comboBoxSex.SelectedIndex == -1 ||
            maskedTextBoxAge.Text == String.Empty ||
            textBoxDescription.Text == String.Empty)
            {
                MessageBox.Show("Заполнены не все поля");
                return;
            }
            Student student = new Student()
            {
                Id = 0,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Sex = comboBoxSex.SelectedIndex,
                Age = int.Parse(maskedTextBoxAge.Text),
                Description = textBoxDescription.Text
            };

            Hosting_QSL_API.StudentsInsertNewStudent(student);

            ClearAddNewsStudentFields();

            GetAllStudents();
        }

        private void FillAddNewsStudentFields()
        {           
            if (dataGridViewStudents.SelectedRows.Count == 0)  // Если ничего не выбрано, то ничего и не происходит
            {
                return;
            }

            DataGridViewRow selectStudent = dataGridViewStudents.SelectedRows[0];  // Выбранная строка

            textBoxId.Text = selectStudent.Cells[0].Value.ToString();
            textBoxFirstName.Text = selectStudent.Cells[1].Value.ToString();
            textBoxLastName.Text = selectStudent.Cells[2].Value.ToString();
            comboBoxSex.SelectedIndex = selectStudent.Cells[3].Value.ToString() == "Мужской" ? 1 : 2;
            maskedTextBoxAge.Text = selectStudent.Cells[4].Value.ToString();
            textBoxDescription.Text = selectStudent.Cells[5].Value.ToString();

        }

        private void UpdateStudent()
        {
            if (
            textBoxFirstName.Text == String.Empty ||
            textBoxLastName.Text == String.Empty ||
            comboBoxSex.SelectedIndex == -1 ||
            maskedTextBoxAge.Text == String.Empty ||
            textBoxDescription.Text == String.Empty)
            {
                MessageBox.Show("Заполнены не все поля");
                return;
            }

            Student student = new Student()
            {
                Id = int.Parse(textBoxId.Text),
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Sex = comboBoxSex.SelectedIndex,
                Age = int.Parse(maskedTextBoxAge.Text),
                Description = textBoxDescription.Text
            };

            Hosting_QSL_API.StudentsUpdateByid(student);

            ClearAddNewsStudentFields();

            GetAllStudents();
        }


        private void StudentsFind()
        {
            string searchText = textBoxFind.Text;       // Считываем с textBoxFind
            dataGridViewStudents.Rows.Clear();
           
            foreach (Student student in students)
            {
                if (student.Id == int.Parse(searchText) || student.FirstName.ToLower().Contains(searchText.ToLower()) == true || student.LastName.ToLower().Contains(searchText.ToLower()) == true || student.Sex == int.Parse(searchText) || student.Age == int.Parse(searchText) || student.Description.ToLower().Contains(searchText.ToLower())==true)
                {
                    dataGridViewStudents.Rows.Add
                   (
                   student.Id, student.FirstName, student.LastName, student.Sex == 1 ? "Мужской" : "Женский", student.Age, student.Description
                   );
                }         
            }
        }

        #endregion

        private void buttonGetAllStudents_Click(object sender, EventArgs e)
        {
            GetAllStudents();
        }

        private void buttonDeleteById_Click(object sender, EventArgs e)
        {
            DeleteById();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddNewsStudent();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteALL();
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {
            DeleteTable();
        }

        private void buttonClearAddNewStudentsFiiekds_Click(object sender, EventArgs e)
        {
            FillAddNewsStudentFields();

        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUpdateStudents_Click(object sender, EventArgs e)
        {
            UpdateStudent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            StudentsFind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Get_Name_Tables();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  new FormLoad().ShowDialog();
            // Close();
            Get_Name_Tables();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // if (MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { e.Cancel = true; }
        }

        
    }
}
