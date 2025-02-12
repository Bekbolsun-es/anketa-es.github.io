using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;5

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    // Студенты с дополнительной информацией
    private static List<Student> students = new List<Student>
    {
        new Student { Id = 1, Name = "Кочконбаев Бекболсун", Age = 22, Group = "Пиэ(б)-2-21", Address = "123 Elm Street", Married = "Не женат", Height = 175, ExcellentStudent = true },
        new Student { Id = 2, Name = "Эшманбетова Акылай", Age = 20, Group = "Пиэ(б)-2-21", Address = "456 Oak Avenue", Married = "Не замужем", Height = 165, ExcellentStudent = false },
        new Student { Id = 3, Name = "Ташболотова Индира", Age = 20, Group = "Пиэ(б)-2-21", Address = "789 Pine Lane", Married = "Не замужем", Height = 160, ExcellentStudent = true },
        new Student { Id = 4, Name = "Советбеков Элмирбек", Age = 20, Group = "Пиэ(б)-2-21", Address = "321 Maple Road", Married = "Не женат", Height = 178, ExcellentStudent = false },
        new Student { Id = 5, Name = "Кулмаматов Бексултан", Age = 20, Group = "Пиэ(б)-2-21", Address = "654 Birch Street", Married = "Не женат", Height = 182, ExcellentStudent = true },
        new Student { Id = 6, Name = "Зиябидинов Азизбек", Age = 20, Group = "Пиэ(б)-2-21", Address = "987 Cedar Avenue", Married = "Не женат", Height = 180, ExcellentStudent = false }
    };

    // Получить всех студентов
    [HttpGet]
    public ActionResult<IEnumerable<Student>> GetStudents()
    {
        return Ok(students);
    }

    // Получить студента по ID
    [HttpGet("{id}")]
    public ActionResult<Student> GetStudent(int id)
    {
        var student = students.Find(s => s.Id == id);
        if (student == null)
            return NotFound();

        return Ok(student);
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }
    public string Address { get; set; }
    public string Married { get; set; }  // Женат/Не женат
    public int Height { get; set; }      // Рост
    public bool ExcellentStudent { get; set; } // Учится отлично/нет
}
