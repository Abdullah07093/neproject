using Domain.Models;

namespace Infrastructure.Services;

public class TeacherService
{
    public List<Teacher>? teachers;
    public List<Teacher> GetTeacher(){
        teachers=new List<Teacher>();
        return teachers;

    }
    public void AddTeacher( Teacher teacher){
teachers.Add(teacher);

    }
    public void UpdateTeacher( Teacher teacher){
         foreach (var  item in teachers)
        {
            if(item.id==teacher.id){
                item.lastName=teacher.lastName;
                item.firstName=teacher.firstName;
                item.experienceAmount=teacher.experienceAmount;
                item.position=teacher.position;
            }
        }
    }
    public void Delete( int id ){
        var teach=new Teacher();
        foreach (var  teac in teachers)
        {
            if(teac.id==id){
 teachers.Remove(teach);
            }
        }
        
    }
}
