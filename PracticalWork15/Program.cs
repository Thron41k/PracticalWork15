using PracticalWork15;


// Создаем массив классов с именами студентов в каждом классе.
var classes = new[]
{
    new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"} },
    new Classroom { Students = {"Anna", "Viktor", "Vladimir"} },
    new Classroom { Students = {"Bulat", "Alex", "Galina"} }
};

// Получаем массив всех студентов из всех классов.
var allStudents = GetAllStudents(classes);

// Выводим имена всех студентов через пробел.
Console.WriteLine(string.Join(" ", allStudents));
return;

// Метод для получения списка всех студентов из массива классов.
static string[] GetAllStudents(Classroom[] classes)
{
    // Используем SelectMany для объединения списков студентов из каждого класса в один массив.
    return classes.SelectMany(classroom => classroom.Students)
        .ToArray();
}