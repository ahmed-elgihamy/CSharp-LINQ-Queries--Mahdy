﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Mahdy
{
    internal class Dept
    {
       public int Id { get; set; }
        public string Name { get; set; }

        public Dept(int id ,string name)
        { 
         Id = id;
         Name = name;
        }   
    }
}
