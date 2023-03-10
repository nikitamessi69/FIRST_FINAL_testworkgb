# **Итоги блока. Выбор специализации. Тестировщик.**
## **Для полноценного выполнения проверочной работы необходимо:**
- Создать репозиторий на GitHub.
- Нарисовать блок-схему алгоритма.
- Снабдить репозиторий оформленным текстовым описанием решения.
- Написать программу, решающую поставленную задачу. 
- Использовать контроль версий в работе над этим небольшим проектом.

### ***Задача:***
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
+ Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
['1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

### [Блок-схема алгоритма решения](https://github.com/nikitamessi69/FIRST_FINAL_testworkgb/blob/master/Diagramm.png)
#### **Алгоритм решения в три метода:**
1. ***FindArray*** - по условию задания, с помощью переменной __count__, перебираем и находим в массиве количество строк с длинной меньшей или равной 3 символам.
2. ***FillArray*** - наполняем массив, сформировав строки с длинной по условию задачи. Чтобы правильно заполнить массив декрементируем __count__.
3. ***PrintArray*** - формируем, выделяем цветом и возвращаем результат на консоль. 

##### [Скриншот подтверждения коммитов в ветке __master__](https://github.com/nikitamessi69/FIRST_FINAL_testworkgb/blob/master/Commits.png)
