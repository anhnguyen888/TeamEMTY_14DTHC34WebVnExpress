﻿using _14DTHC34Web.Models;
using System.Collections.Generic;

namespace _14DTHC34Web.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public byte Category { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}