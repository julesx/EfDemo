using EfDemo.Classes;
using EfDemo.View_Models.Items;

namespace EfDemo.View_Models.Tabs
{
    public class SchoolsVm : BaseTabVm<SchoolVm>
    {
        public SchoolsVm()
        {
            using (var dbContext = new MyDbContext())
            {
                foreach (var school in dbContext.Schools)
                    Items.Add(new SchoolVm(school));
            }
        }
    }
}
