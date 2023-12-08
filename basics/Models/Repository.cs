namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses=new();

        static Repository(){
            _courses=new List<Course>()
            {
                new Course() { Id = 1, Title="ASP.NET Core Course", Description="ASP.NET Core Course Description", Image="1.jpg"},
                new Course() { Id = 2, Title="PHP Course", Description="PHP Course Description", Image="2.jpg"},
                new Course() { Id = 3, Title="Django Course", Description="Django Course Description", Image="3.jpg"},
                new Course() { Id = 4, Title="JavaScript Course", Description="JavaScript Course Description", Image="4.jpg"}
            };
        }

        public static List<Course> Courses{
            get { return _courses;}
        }
    }
}