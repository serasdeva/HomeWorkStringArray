# ___Практическое задание___ #
## Итоги блока. Выбор специализации ## <br>
___Описание решения программы на языке C#___

**Задача** 
```
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
```
В данном варианте исполнения, я на старте объявил массив  с именем __list__ и заполнил его.
~~~ 
 string[] list = new String[] { "hello", "2", "world", ":-)" };
~~~
Так же обьявил пусой массив.
~~~ 
string[] list2 = new String[] { }; 
~~~
Далее объявил переменную len и присвоил ей ноль. *Данная переменная предназначена для индекссации элементов массива* **list2**.
```
 int len = 0; 
 ```
 Далее идет блок кода перебора массива и выполнения условия поиска элемента масcива где длина менее 3 символов либо равна 3 символам, а так же пришлось использовать метод увеличения длины массива **list2** `Array.Resize`
```
int listLength = list.Length;
    for (int i = 0; i < listLength; i++)
    {
        if (list[i].Length <= 3)
        {
            Array.Resize(ref list2, list2.Length + 1);
            len = list2.Length;
            list2[len - 1] = list[i];
        }
    }
```

Ну и завершающий блок кода используется для вывода элементов массива **list2** в консоль.
```
int list2Length = list2.Length;
    for (int j = 0; j < list2Length; j++)
    {
        Console.WriteLine("   [{0}] : {1}", j, list2[j]);
    }
```




