using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
    public partial class Language
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool? IsDefault { get; set; }
    }
}
