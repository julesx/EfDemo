using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDemo.View_Models.Items
{
    public interface IItemVm
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
