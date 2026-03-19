using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class TeacherMember:Member
    {


        public TeacherMember(int id, string name, string phone) : base(id, name, phone)
        {

        }
        public override int GetMaxBorrowLimit()
        {
            return 5;
        }


    }
}
