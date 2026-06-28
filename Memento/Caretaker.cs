public class Caretaker
{
    // Приватное поле для хранения самого последнего снимка (Memento).
    private Memento _memento;

    // Метод для ЗАПИСИ текущего состояния в хранилище.
    public void SaveState(FullNameClass originator)
    {
        _memento = originator.GetMemento(); // Запрашиваем снимок у объекта и сохраняем.
    }

    // Метод для ВОССТАНОВЛЕНИЯ состояния из хранилища.
    public void RestoreState(FullNameClass originator)
    {
        // Если есть сохраненный снимок, передаем его объекту для восстановления.
        if (_memento != null)
        {
            originator.SetMemento(_memento);
        }
    }
}