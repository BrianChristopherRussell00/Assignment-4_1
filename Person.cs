﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MobilePhone { get; set; }

        public string WorkPhone { get; set; }

        public string Address { get; set; }


        public string FullName
        
        {
            get { return LastName + FirstName; }
        
            
            
        }

    }
}