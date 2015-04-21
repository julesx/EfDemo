using EfDemo.Classes;
using EfDemo.View_Models.Items;

namespace EfDemo.View_Models.Tabs
{
    public class TeachersVm : BaseTabVm<TeacherVm>
    {
        public TeachersVm()
        {
            using (var dbContext = new MyDbContext())
            {
                foreach (var teacher in dbContext.Teachers)
                    Items.Add(new TeacherVm(teacher));
            }
        }
    }
}
