namespace Infrastructure.Services;

using Domain.Models;
public class StudentService
{ 
   public List <Student> students;
    public List<Student> GetStudents(){

        students=new List<Student>();

        return students;
    }
    public void AddStudent(Student student){
        students.Add(student);


    }
    public void UpdateStudent(Student student){
 foreach (var  item in students)
        {
            if(item.id==student.id){
                item.lastName=student.lastName;
                item.firstName=student.firstName;
                item.birthDate=student.birthDate;
                item.address=student.address;
            }
        }
    }
    public void Delete(int id){
        var std=new Student();
        foreach (var  item in students)
        {
            if(item.id==id){
 students.Remove(std);
            }
        }
       

    }

}
