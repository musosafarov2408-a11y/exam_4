//1
//Inheritance in nasl dodan va polymarfithm in misli ki mo yagon method ro vertial kunem va dar digar classho bo override pur kunem boz palimargizm ba xud abstractni class dorad
//mo dar virtual metavonem yagon chiz doxil kunem baroi misol ovardan yo inki doxil nakunem ammo dar abstruct mo boyad yagon chi doxil nakunem va classhoe ki az in meros megirad boyad hatman inro purkunad
//2
//classi static in classi meboshad ki bo on object soxta nameshavad faqat nomi onro va method fariyod mekuni va onhoro mesnji yo kor mekuni
//3
//Generic lass in classe meboshad ki dar xud chand namudi classro megirad misol Generic<T> dar injo T yane Tipe meboshad va on ba xud chand namudi class qabul mekunad
//4
//struct yo strucyura in vaqte ki mo az berun dar daruni qavshoi class doxil mekunem az classi abichi inxel farq mekunad ki mo bo no class polyaro fariyod mekunem ammo dar struct boshad dar daruni qavs fariyod mekunem


//===============================================================================================================================================================================================================================




//5
Console.WriteLine("------ Task 5 ------");
MyQueue<int> number = new MyQueue<int>();
number.Enqueue(10);
number.Enqueue(20);
number.Enqueue(30);
number.Enqueue(40);
number.Enqueue(50);
number.Dequeue();
try
{
    Console.WriteLine($"Aval: {number.Peek()}");
    Console.WriteLine($"Count: {number.Count()}");
}
catch(Exception e)
{
    Console.WriteLine("Eorror!");
}





//6
Console.WriteLine("------ Task 6 ------");
Student student = new Student()
{
    Id = 1,
    FullName = "Muso",
    Age = 16,
    Group = "C#"
};
Student student1 = new Student()
{
    Id = 2,
    FullName = "Abdullo",
    Age = 16,
    Group = "C++"
};
Student student3 = new Student()
{
    Id = 3,
    FullName = "Muhammmad",
    Age = 16,
    Group = "C#"
};
StudentService studentService = new StudentService();
studentService.AddStudent(student1);
studentService.AddStudent(student3);
studentService.AddStudent(student);
studentService.DisplayStudents();
studentService.DeleteStudent(1);