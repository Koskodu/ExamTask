# Итоговая проверочная работа

## Задача :
Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

## Описание решения:
Объявляем два массива одинаковой длины. <br/>
Создаем метод, с циклом равным длине массива, <br/>
внутри цикла проверка условия ( <=3 ), <br/>
если да элемент первого массива заносится в count элемент второго массива. <br/>
После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. <br/>
И так проверяем до конца.

![](BlockSchm.jpg)