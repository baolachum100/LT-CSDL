﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UngDungDocBao.Models
{
    public class Category
    {
        public string Name { get; set; }

        public string RssLink { get; set; }

        public List<Article> Articles { get; set; } 

        public Category()
        {
            Articles = new List<Article>();
        }
    }
}
