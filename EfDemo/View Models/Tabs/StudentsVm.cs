using EfDemo.Classes;
using EfDemo.View_Models.Items;

namespace EfDemo.View_Models.Tabs
{
    public class StudentsVm : BaseTabVm<StudentVm>
    {
        public StudentsVm()
        {
            using (var dbContext = new MyDbContext())
            {
                foreach (var student in dbContext.Students)
                    Items.Add(new StudentVm(student));
            }
        }
    }
}
