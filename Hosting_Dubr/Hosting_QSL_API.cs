using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;  // Подключаем Newtonsoft.Json
using System.Net;

namespace Hosting_Dubr
{
    class Hosting_QSL_API
    {
        private static string link = "http://nikdresden.000webhostapp.com/";
     //   private static string link = "http://raymna208.000webhostapp.com/";
        

        /*                       ExecutedCommand()
         *  Универсальный метод для построения запросов к серверу 
         *  В string url конвертируем и передаем link(хост),command(API),parameters(id,..)
         *  Возвращаем при помощи WebClient загруженную url-строку
         *  Т.е. Загружает запрошенный ресурс в виде String. Ресурс для загрузки, указанный как Uri.
         */

        #region ExecutedCommand
        private static string ExecutedCommand(string command, string parameters = null)
        {
            WebClient cilent = new WebClient();
            string url = String.Format("{0}?command={1}&parameters={2}", link, command, parameters);
            return cilent.DownloadString(url);  // Выполняет её и возвращает, то ,что получили в результате её выполнения
        }
        #endregion

        /*                                       StudentsSelectAll()
        *  Получаем команду от сервера QSL (скрипт.php)- выбор всех элементов таблицы QSL
        *  Запрос - students.select.all
        *  Преобразуем полученные данные в url 
        *  Преобразуем элементы url из Json в читаемый вид - unicode j8-ci && etc
        *  Получили параметры для добавления в таблицу
        */

        #region students.select.all
        public static List<Student> StudentsSelectAll()
        {
            string command = "students.select.all";
            string result = ExecutedCommand(command);   // получаем students.select.all в ExecutedCommand - преобразуем  в url

            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(result);     // Преобразуем в Лист (состоящий из объектов класса Student - параметров) - result, используя Newtonsoft.Json

            return students;
        }
        #endregion

        /*                                    StudentsDeleteByid()
         *  command - удалить элемент по id 
         *  Праметры - id, которые получили из dataGrid.  Cм. DeleteById()
         *  Запрос - students.delete.byid
         *  Преобразуем это в url при помощи ExecutedCommand()
         */

        #region students.delete.byid
        public static void StudentsDeleteByid(string id)
        {
            string command = "students.delete.byid";
            string parameters = id;

            ExecutedCommand(command, parameters);
        }
        #endregion

        /*                    StudentsInsertNewStudent()

      *  Получаем команду от сервера QSL (скрипт.php) - изменить ячейку
      *  Запрос - students.insert.newstudent
      *  Передаем изменяемые параметры(student)(Полученные от AddNewStudent()) - конвертируем в Json объект класса Student
      *  Преобразуем в url при помощи ExecutedCommand
      *  Для того чтобы в дальнейшем отправить это (с помощью скрипта.php) на серевер QSL
      */

        #region students.insert.newstudent
        public static void StudentsInsertNewStudent(Student student)
        {
            string command = "students.insert.newstudent";
            string parameters = JsonConvert.SerializeObject(student);

            ExecutedCommand(command, parameters);
        }
        #endregion

        /*                    StudentsDeleteAll()
         *  Отправляем на хостинг(скрипт.php) команду - students.delete.all            
         *  Скрипт отправляет на MyQSL-сервер запрос на очищение данных таблицы  students               
         *  Очищение таблицы                    
         */

        #region students.delete.all
        public static void StudentsDeleteAll()
        {
            string command = "students.delete.all";
            ExecutedCommand(command);
        }
        #endregion

        #region students.show.table
        public static List<Table> StudentsShowTable()
        {
            string command = "students.show.table";
            string result = ExecutedCommand(command);

            List<Table> List_Tables = JsonConvert.DeserializeObject<List<Table>>(result);

            return List_Tables;
        }
        #endregion

        #region students.delete.table
        public static void StudentsDeleteTable(string NameTable)
        {
            string command = "students.delete.table";
            string parameters = NameTable;

            ExecutedCommand(command, parameters);          
        }
        #endregion

        #region students.update.byid
        public static void StudentsUpdateByid(Student student)
        {
            string command = "students.update.byid";
            string parameters = JsonConvert.SerializeObject(student);

            ExecutedCommand(command, parameters);
        }
        #endregion

    }
}
