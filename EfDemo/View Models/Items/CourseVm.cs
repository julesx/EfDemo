using EfDemo.Models.Items;

namespace EfDemo.View_Models.Items
{
    public class CourseVm : BaseItemVm<Course, CourseVm>, IItemVm
    {
        public CourseVm(Course course) : base(course)
        {
            
        }

    }
}
