using EfDemo.Models.Items;

namespace EfDemo.View_Models.Items
{
    public class TeacherVm : BaseItemVm<Teacher, TeacherVm>, IItemVm
    {
        public TeacherVm(Teacher model) : base(model)
        {
        }
    }
}
