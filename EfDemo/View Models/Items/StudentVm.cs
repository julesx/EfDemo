using EfDemo.Models.Items;

namespace EfDemo.View_Models.Items
{
    public class StudentVm : BaseItemVm<Student, StudentVm>, IItemVm
    {
        public StudentVm(Student model) : base(model)
        {
        }
    }
}
