# FinalWork

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] [“1234”, “1567”, “-2”, “computer science”] → [“-2”] [“Russia”, “Denmark”, “Kazan”] → []

Алгоритм решения
1. Перебрать значения исходного массива
2. Проверить на соответствие условиям, длина cтроки < 3
3. При соответствии условию, добавить строку в новый массив
4. Повторять проверку и добавление, пока не достигнем конца массива
5. Как результат вывести новый массив


Блок схема алгоритма


<img width="538" alt="Screenshot 2022-11-17 at 12 39 49" src="https://user-images.githubusercontent.com/116726365/202477725-5ab04063-5825-4691-aad1-7c291990a557.png">