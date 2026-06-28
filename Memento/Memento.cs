public class Memento
{
    // Хранит точную копию состояния. Это "коробка" с данными.
    // Никакой логики здесь нет, только данные (для сохранения и восстановления).
    public string Name { get; set; }
    public string Surname { get; set; }
    public string MiddleName { get; set; }
}