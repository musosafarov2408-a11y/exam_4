
public class StudentService : IStudent
{
    public List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        try
        {
            students.Add(student);
            Console.WriteLine("Student added");
        }
        catch (Exception e)
        {
            Console.WriteLine("eror");
        }
    }

    public void DisplayStudents()
    {
        try
        {
            foreach (var item in students)
            {
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"Name: {item.FullName}");
                Console.WriteLine($"Age: {item.Age}");
                Console.WriteLine($"Group: {item.Group}");
                Console.WriteLine("--------------------");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("eror");
        }
    }

    public void UpdateStudent(Student student)
    {
        try
        {
            foreach (var item in students)
            {
                if (item.Id == student.Id)
                {
                    item.FullName = student.FullName;
                    item.Age = student.Age;
                    item.Group = student.Group;
                    Console.WriteLine("Studen updated");
                    break;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("eror");
        }
    }

    public void DeleteStudent(int id)
    {
        try
        {
            foreach (var item in students)
            {
                students.RemoveAll(x=>x.Id == id);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("eror");
        }
    }

    public void SearchByName(string fullName)
    {
        try
        {
            foreach (var item in students)
            {
                if (item.FullName == fullName)
                {
                    Console.WriteLine(item);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("eror");
        }
    }

    public void SearchByGroup(string group)
    {
        try
        {
            foreach (var item in students)
            {
                if (item.Group == group)
                {
                    Console.WriteLine(item);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("eror");
        }
    }
}