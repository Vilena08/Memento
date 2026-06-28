using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Создаем объект с начальным состоянием ("Иван Иванов Иванович")
        FullNameClass user = new FullNameClass("Ivan", "Ivanov", "Ivanovich");
        Caretaker caretaker = new Caretaker();

        // 2. Выводим состояние и СОХРАНЯЕМ его в Хранитель.
        user.Print();
        caretaker.SaveState(user);

        // 3. Изменяем состояние объекта на новое ("Петр Петров Петрович")
        user = new FullNameClass("Petr", "Petrov", "Petrovich");
        user.Print();

        // 4. ВОССТАНОВЛЯЕМ состояние из Хранителя (обратно к "Ивану")
        caretaker.RestoreState(user);
        user.Print();

        Console.ReadKey();
    }
}
//В паттерне Memento объект FullNameClass (Originator) умеет создавать снимок своего состояния через GetMemento() и восстанавливать его через SetMemento(). Класс Caretaker (Хранитель) отвечает за хранение этого снимка и не вмешивается в его содержимое. В Main я создал объект user как "Иван...", сохранил его, заменил на "Петр...", а затем восстановил. Вывод в консоль показывает, что состояние действительно вернулось к исходному.