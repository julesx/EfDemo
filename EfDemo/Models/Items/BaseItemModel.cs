﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDemo.Models.Items
{
    public class BaseItemModel<TModel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
