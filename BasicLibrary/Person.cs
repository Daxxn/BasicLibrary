﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        override
        public string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
