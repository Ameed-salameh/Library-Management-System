using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{

    enum TransactionType
    {
        Borrow,
        Return
    }


    internal class Transaction
    {
        public int Id;
        public string BookTitle;
        public string MemberName;
        public DateTime Date;
        public TransactionType Type;


        public Transaction(int id, string bookTitle, string memberName, TransactionType type)
        {
            Id = id;
            BookTitle = bookTitle;
            MemberName = memberName;
            Type = type;
            Date = DateTime.Now; 
        }



    }
}
