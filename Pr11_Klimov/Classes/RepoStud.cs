using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Pr11_Klimov.Classes
{
    public class RepoStud
    {
        public  static List<Student> Allstudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Аликин", "Лев", "Алексеевич"));
            students.Add(new Student("Бартова", "Елизавета", "Юрьевна"));
            students.Add(new Student("Белослудцева", "Яна", "Сергеевна"));
            students.Add(new Student("Богданов", "Вадим", "Александрович"));
            students.Add(new Student("Братчиков", "Максим", "Игоревич"));
            students.Add(new Student("Гафмиуллин", "Марсель", "Ренатович"));
            students.Add(new Student("Гафмиуллин", "Эльдар", "Ренатович"));
            students.Add(new Student("Гончарова", "Анастасия", "Вячеславовна"));
            students.Add(new Student("Закурин", "Данил", "Вячеславович"));
            students.Add(new Student("Казаков", "Михаил", "Сергеевич"));
            students.Add(new Student("Климов", "Степан", "Андреевич"));
            students.Add(new Student("Князев", "Арсений", "Александрович"));
            students.Add(new Student("Коневский", "Богдан", "Олегович"));
            students.Add(new Student("Котылко", "Анастасия", "Сергеевна"));
            students.Add(new Student("Крюков", "Матвей", "Андреевич"));
            students.Add(new Student("Мацкевич", "Владислав", "Денисович"));
            students.Add(new Student("Мыльников", "Михаил", "Вадимович"));
            students.Add(new Student("Осенников", "Евгений", "Александрович"));
            students.Add(new Student("Пешин", "Григорий", "Евгеньевич"));
            students.Add(new Student("Сабитов", "Назир", "Назипович"));
            students.Add(new Student("Смертина", "Екатерина", "Дмитриевна"));
            students.Add(new Student("Ходжиев", "Дамир", "Саиджонович"));
            students.Add(new Student("Цой", "Кирилл", "Сергеевич"));
            students.Add(new Student("Шаповалов", "Дмитрий", "Алексеевич"));
            students.Add(new Student("Шашин", "Алексей", "Вячеславович"));
            students.Add(new Student("Ширинкин", "Иван", "Сергеевич"));
            return students;
        }
    }
}
