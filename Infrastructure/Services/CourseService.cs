using Domain.Models;

namespace Infrastructure.Services;

public class CourseService
{
      public List<Course>? courses;
    public List<Course> GetCourses(){
        courses=new List<Course>();
        return courses;

    }
    public void AddTeacher( Course course){
courses.Add(course);
    }
    public void UpdateTeacher( Course course){
                 foreach (var  item in courses)
        {
            if(item.id==course.id){
                item.title=course.title;
                item.description=course.description;
                item.fee=course.fee;
                item.hasDiscount=course.hasDiscount;
            }
        }
    }
    public void Delete( int id ){
          var cour=new Course();
        foreach (var  cou in courses)
        {
            if(cour.id==id){
 courses.Remove(cour);
            }
        }
        
    }
}
