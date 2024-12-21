using PracticalWork15;

var classes = new[]
{
    new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"} },
    new Classroom { Students = {"Anna", "Viktor", "Vladimir"} },
    new Classroom { Students = {"Bulat", "Alex", "Galina"} }
};
var allStudents = GetAllStudents(classes);

Console.WriteLine(string.Join(" ", allStudents));
return;

static string[] GetAllStudents(Classroom[] classes)
{
    return classes.SelectMany(classroom => classroom.Students).ToArray();
}