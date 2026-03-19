using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library_Management_System
{
    internal class Member:book
    {
        public int id;
        public string name;
        public int phone;
        string[] borrowedBooks = new string[2];



    }
}
