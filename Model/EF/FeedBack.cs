﻿using System;
using System.Collections.Generic;

namespace OnlineShop.Models
{
    public partial class FeedBack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public string Address { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Status { get; set; }
    }
}