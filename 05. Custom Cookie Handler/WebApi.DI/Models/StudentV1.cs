﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.DI.Models
{
    public class StudentV1
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public double GPA { get; set; }
    }
}