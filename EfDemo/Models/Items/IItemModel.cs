using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDemo.Models.Items
{
    public interface IItemModel
    {
        int Id { get; set; }
        string Name { get; set; }

    }
}
