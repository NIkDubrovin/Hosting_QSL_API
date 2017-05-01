<?php
               /* Передаем Данные хоста в $link при помощи mysqli_connect (стандарт PHP 7) - соединяемся c сервером SQL
               *  Конвертируем  в utf8
               *  Создаем ассоциативные массивы - главный элемент скрипта
               */
$link = mysqli_connect("localhost","DB Host","Key", "DB Name");    // Данные хоста
mysqli_query($link, 'utf8');     // convert to utf8

$command = $_GET['command'];   // создаем ассоциативный массив с элементом command
$parameters = $_GET['parameters']; // создаем ассоциативный массив с элементом parameters

               /*              Если приняли массив с command
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
               
switch($command)   
{
case 'students.select.all':
$query_result = mysqli_query($link,"SELECT * FROM `students`");
$data = array();
while($currentRow = mysqli_fetch_array($query_result,MYSQLI_ASSOC))
{
$data[] = $currentRow;
}
echo json_encode($data);
break;

case 'students.delete.byid':
mysqli_query($link,"DELETE FROM `students` WHERE `id`='{$parameters}'");
break;

case 'students.insert.newstudent':
$right_parameters = str_replace('\\','',$parameters);
$student= json_decode($right_parameters ,true);

$first_name = $student['first_name'];
$last_name= $student['last_name'];
$sex= $student['sex'];
$age= $student['age'];
$description= $student['description'];

mysqli_query($link, "INSERT INTO `students` (`first_name`,`last_name`,`sex`,`age`,`description`) VALUES ('{$first_name }','{$last_name}','{$sex}','{$age}','{$description}')");

break;
}
?>