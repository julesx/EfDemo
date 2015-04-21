using EfDemo.Classes;
using EfDemo.View_Models.Items;

namespace EfDemo.View_Models.Tabs
{
    public class DepartmentsVm : BaseTabVm<DepartmentVm>
    {
        public DepartmentsVm()
        {
            using (var dbContext = new MyDbContext())
            {
                foreach (var department in dbContext.Departments)
                    Items.Add(new DepartmentVm(department));
            }
        }
    }
}
