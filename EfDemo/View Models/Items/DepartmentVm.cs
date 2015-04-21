using EfDemo.Models.Items;

namespace EfDemo.View_Models.Items
{
    public class DepartmentVm : BaseItemVm<Department, DepartmentVm>, IItemVm
    {
        public DepartmentVm(Department model) : base(model)
        {

        }
    }
}
