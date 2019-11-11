using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using Core;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
