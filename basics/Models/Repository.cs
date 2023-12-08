namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses=new();

        static Repository(){
            _courses=new List<Course>()
            {
                new Course() { Id = 1, 
                Title="ASP.NET Core Course", 
                Description="ASP.NET Core Course Description", 
                Image="1.jpg",
                Tags = new string[] {"aspnet", "web development"},
                isActive=true,
                isHome=true
                },
                new Course() { Id = 2, 
                Title="PHP Course", 
                Description="PHP Course Description", 
                Image="2.jpg",
                Tags = new string[] {"php", "web development"},
                isActive=true,
                isHome=true
                },
                new Course() { Id = 3, 
                Title="Django Course", 
                Description="Django Course Description", 
                Image="3.jpg",
                isActive=true,
                isHome=false
                },
                new Course() { Id = 4, 
                Title="JavaScript Course", 
                Description="JavaScript Course Description", 
                Image="4.jpg",
                isActive=true,
                isHome=true
                }
            };
        }

        public static List<Course> Courses{
            get { return _courses;}
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c=>c.Id == id);
        }
    }
}