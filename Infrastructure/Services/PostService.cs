using Domain.Models;

namespace Infrastructure.Services;

public class PostService
{
       public List<Post>? posts;
    public List<Post> GetCourses(){
        posts=new List<Post>();
        return posts;

    }
    public void AddPost( Post post){
posts.Add(post);
    }
    public void UpdatePost( Post post){
                  foreach (var  item in posts)
        {
            if(item.id==post.id){
                item.title=post.title;
                item.description=post.description;
                item.voteAmount=post.voteAmount;
                item.createdAt=post.createdAt;
            }
        }
    }
    public void Delete( int id ){
          var posti=new Post();
        foreach (var  pos in posts)
        {
            if(posti.id==id){
 posts.Remove(posti);
            }
        }
        
    }
}
