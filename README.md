## ***GeekBrains*** 
https://gb.ru <br></p>

### ***Студент: Караулов Борис*** 
https://t.me/lyshu <br></p> b.karaulov@ya.ru <br></p> https://github.com/bakaraulov<br></p>https://github.com/bakaraulov/gb_fcw_mb_Introduction-to-Programming


________________________

# Итоговая контрольная работа по основному блоку.
## Курс: Введение в программирование
<br></p>

*Данная работа необходима для проверки знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно*

*Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо*
<br></p>

1. Создать репозиторий на GitHub

2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)

3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)

4. Написать программу, решающую поставленную задачу

5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

* ### Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.<br></p><br></p>

### Примеры:<br></p>
**[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] <br></p>
[“1234”, “1567”, “-2”, “computer science”] → [“-2”] <br></p>
[“Russia”, “Denmark”, “Kazan”] → []**<br></p><br></p>

* ### Блок схема выполнена в двух исполнениях. *.jpg* (картинка) и *.vsdx* (Microsoft Visio)<br></p>

![Блок схема основного метода](https://github.com/bakaraulov/gb_fcw_mb_Introduction-to-Programming/blob/main/diagram.jpg)

* ### **ConditionArray** - основной метод на вход принимает первоначальный массив. Создает и возвращает второй массив. Через цикл For обходит первый массив и если длинна элемента первого массива  <=3, Записывает его в новый элемент результирующего массива<br></p>

* ### Дополнительные методы:<br></p>
1) **PromptNumber** - числовой ввод
2) **PromptString** - текстовый ввод
3) **CreateArray** - ручной ввод массива
4) **PrintArray** - вывод (печать) массива

### **Основной массив можно ввечти как с помошью выбора примеров, так с помошью ручного заполнения массива, так и с помошью написания текстовой строки.<br></p>**
## ***Вся информация должна вводиться латинским алфавитом!***
