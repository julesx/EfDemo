using EfDemo.Models.Items;

namespace EfDemo.View_Models.Items
{
    public class SchoolVm : BaseItemVm<School, SchoolVm>, IItemVm
    {
        public SchoolVm(School model) : base(model)
        {
        }
    }
}
