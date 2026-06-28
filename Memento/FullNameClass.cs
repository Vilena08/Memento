using System;

public class FullNameClass
{
    // Текущее состояние объекта. Его мы будем сохранять и восстанавливать.
    public string Name { get; set; }
    public string Surname { get; set; }
    public string MiddleName { get; set; }

    // Конструктор — задает начальное состояние.
    public FullNameClass(string name, string surname, string middle)
    {
        Name = name;
        Surname = surname;
        MiddleName = middle;
    }

    // Вывод текущего состояния на экран (для демонстрации).
    public void Print()
    {
        Console.WriteLine($"Name={Name} Surname={Surname} Middle={MiddleName}");
    }

    // === Ключевой метод 1: СОЗДАНИЕ снимка ===
    public Memento GetMemento()
    {
        // Возвращаем новый объект Memento, наполненный текущими данными.
        // Это "слепок" состояния в момент вызова.
        return new Memento
        {
            Name = Name,
            Surname = Surname,
            MiddleName = MiddleName
        };
    }

    // === Ключевой метод 2: ВОССТАНОВЛЕНИЕ из снимка ===
    public void SetMemento(Memento memento)
    {
        // Перезаписываем текущие поля значениями из сохраненного снимка.
        Name = memento.Name;
        Surname = memento.Surname;
        MiddleName = memento.MiddleName;
    }
}