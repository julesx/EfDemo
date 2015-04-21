using EfDemo.Classes;
using EfDemo.View_Models.Items;

namespace EfDemo.View_Models.Tabs
{
    public class DistrictsVm : BaseTabVm<DistrictVm>
    {
        public DistrictsVm()
        {
            using (var dbContext = new MyDbContext())
            {
                foreach (var district in dbContext.Districts)
                    Items.Add(new DistrictVm(district));
            }
        }
    }
}
