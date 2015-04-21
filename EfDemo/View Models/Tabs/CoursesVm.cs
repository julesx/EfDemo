using EfDemo.Classes;
using EfDemo.View_Models.Items;

namespace EfDemo.View_Models.Tabs
{
    public class CoursesVm : BaseTabVm<CourseVm>
    {
        public CoursesVm()
        {
            using (var dbContext = new MyDbContext())
            {
                foreach (var course in dbContext.Courses)
                    Items.Add(new CourseVm(course));
            }
        }
    }
}
