# Итоговая контрольная работа по основному блоку
Выполнил ученик 1 курса университета GeekBrains: __*Зяблов Вячеслав*__.
##### Условие:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
##### Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
#### Решение:
1.  Объявляем 3 массива. Первый для приема данных от пользователя, второй для копирования данных из первого массива до окончания:: ввода, третий для получения результата.
2.  Объявляем переменные: счетчика количества элементов в массиве со значением 0,  перменную вводимого количества элементов от пользователя, переменную строки.
3.  Выделяем память под второй массив.
4.  Создаем метку для возврата на точку, где просим пользователя ввести количество элементов массива.
5.  Если пользователь набрал отрицательное число, то описываем его ошибку и возвращаем на метку возврата для повтора ввода.
6.  Создаем метку2 для возврата на точку, где просим пользователя ввести строки элементов массива.
7.  В цикле while(пока счетчик не равен введеному пользователем количеству элементов) добавляем строки от пользователя (если они не пустые) в первый массив и присваиваем его элементы второму массиву.
8.  Если строка пустая, то описываем ошибку и возвращаем на метку возврата для повтора ввода.
9.  Выводим готовый массив для последующей конкатинации.
10. Объявляем счетчик для строк- элементов второго массива длина которых менше или равна трем символам.
11. В цикле for обходим второй массив, находим и подсчитываем количество этих элементов.
12. Объявляем переменную счетчик для присвоения элементов третьему массиву.
13. Объявляем третий массив с таким  количеством элементов второго массива длина которых менше или равна трем символам.
14. В цикле for обходим второй массив и присваиваем нужные элементы элементам третьего массива.
15. Выводим результат в консоль.
##### Блок-схема:
![dzExamination_01](https://github.com/VyacheslavChik22/Examination_01/assets/99678206/5f5046fb-c24d-4fb4-9e12-aceee055ca08)
#### Skreen
#![kontr](https://github.com/VyacheslavChik22/Examination_01/assets/99678206/9f1ba7b6-6577-4582-87ed-85c9a731904a)

