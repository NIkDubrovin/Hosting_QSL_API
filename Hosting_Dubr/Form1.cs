﻿using System;
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
        #region Работа с API
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
        private void GetAllStudents()
        {
            dataGridViewStudents.Rows.Clear();
            List<Student> students = Hosting_QSL_API.StudentsSelectAll();

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

        private void ClearAddNewsStudentFields()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            comboBoxSex.SelectedIndex = -1;
            maskedTextBoxAge.Clear();
            textBoxDescription.Clear();
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
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

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
    }
}