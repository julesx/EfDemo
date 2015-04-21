using EfDemo.Models.Items;

namespace EfDemo.View_Models.Items
{
    public class DistrictVm : BaseItemVm<District, DistrictVm>, IItemVm
    {
        public DistrictVm(District model) : base(model)
        {
        }
    }
}
