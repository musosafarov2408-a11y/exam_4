public  interface  IStudent
{
    void AddStudent(Student student);
    void DisplayStudents();
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
    void SearchByName(string fullName);
    void SearchByGroup(string group);
}