namespace EncapsulationExample.Model
{
    public class Person
    {
        // Приватные поля
        private string name;
        private int age;

        // Публичное свойство для доступа к имени
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Имя не может быть пустым.");
                name = value;
            }
        }

        // Публичное свойство для доступа к возрасту
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentOutOfRangeException("Возраст должен быть в пределах от 0 до 120.");
                age = value;
            }
        }

        // Метод для отображения информации о человеке
        public string GetInfo()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }
    }
}
