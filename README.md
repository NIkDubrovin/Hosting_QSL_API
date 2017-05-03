 # Hosting_QSL_API
                                              # How it works
![alt text](https://cloud.githubusercontent.com/assets/24619416/25585736/bf75c698-2ea4-11e7-9114-5a2c56b4629e.png)
**********************************************************************************************************************
                                             # Russian language
   Проект является реализацией связи между SQL-сервером(БД) и клиентом, взаимодействующим с БД при помощи API.
   API реализовано при помощи скрипта.php - главное взаимодействие с QSL-сервером и VS-программы на C#
   
Подключаемся к своему хостингу.
При нажатие на buttons активируются методы, которые взаимодействуют с ExecutedCommand().
ExecutedCommand() - универсальный метод для построения запросов к скрипту -> QSL серверу, который преобразует данные 
в url-строку и возвращает её.
 При помощи link он возвращает значения - command && parameters на хост, которые принимаются скриптом.php и отправляются в виде запросов 
к БД, и загружает url-строку(command && parameters) для взаимодействия методов с ними, которые затем(command && parameters) хранятся в 
объекте класса Students.
Так же тут используется библиотека Newtonsoft.Json для парсинга Json в utf, так как Json возвращает скрипт.php.
***********************************************************************************************************************************
                                       # Краткое описание методов.
 ![alt text](https://cloud.githubusercontent.com/assets/24619416/25585534/c52b1c4c-2ea3-11e7-9a11-c59d3177e2c8.png)                                      
                                              
        /*                       ExecutedCommand()
         *  Универсальный метод для построения запросов к серверу 
          *  В string url конвертируем и передаем link(хост),command(API),parameters(id,..)
         *  Возвращаем при помощи WebClient загруженную url-строку
         */      
      
        /*                    StudentsSelectAll()
        *  Получаем команду от сервера QSL (скрипт.php)- выбор всех элементов таблицы QSL
        *  Запрос - students.select.all
        *  Преобразуем полученные данные в url 
        *  Преобразуем элементы url из Json в читаемый вид - unicode j8-ci && etc
        *  Получили параметры для добавления в таблицу
        */



      /*                       StudentsDeleteByid()
      *  command - удалить элемент по id 
      *  Праметры - id, которые получили из dataGrid.  Cм. DeleteById()
      *  Запрос - students.delete.byid
      *  Преобразуем это в url при помощи ExecutedCommand()
      */
        

     /*                    StudentsInsertNewStudent()
      *  Получаем команду от сервера QSL (скрипт.php) - изменить ячейку
      *  Запрос - students.insert.newstudent
      *  Передаем изменяемые параметры(student)(Полученные от AddNewStudent()) - конвертируем в Json объект класса Student
      *  Преобразуем в url при помощи ExecutedCommand
      *  Для того чтобы в дальнейшем отправить это (с помощью скрипта.php) на серевер QSL
      */
      
  ![alt text](https://cloud.githubusercontent.com/assets/24619416/25585757/d4d5583c-2ea4-11e7-83e6-444251092f92.png)
     
                                    Вспомогательные методы
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
                                                 # PHP-script   
   ![alt text](https://cloud.githubusercontent.com/assets/24619416/25585954/baa903a4-2ea5-11e7-92e6-955741ec8a68.png)     
    /* Передаем Данные хоста в $link при помощи mysqli_connect (стандарт PHP 7) - соединяемся c сервером SQL
      *  Конвертируем  в utf8
      *  Создаем ассоциативные массивы - главный элемент скрипта
      */


                                      Если приняли массив с command
               *******************************************************************************
   *  если command = students.select.all, то соединяемся с сервером SQL - БД(База Данных) и отправляем запрос на выделение всех элементов БД students
               *  Записываем все элементы в $query_result 
               *  Создаем массив $data
     *  Пока в $query_result передаются элементы БД students, это все записывается в $currentRow, а затем в массив $data[]
     *  Выводится с помощью json_encode 
   ********************************************************************************************
     *   если command = students.delete.byid, то удаляется элемент с id, который приняли от VS-программы - от ExecutedCommand
   ******************************************************************************************************************
     *   если command = students.insert.newstudent, то с помощью json_decode и str_replace парсим то, что возвратил ExecutedCommand в виде $parameters - C#
     *   Добавляем новую ячейку в БД
     */

