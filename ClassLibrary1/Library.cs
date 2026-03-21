
using System.Net;

namespace ClassLibrary1
{
    public class Library
    {
        public Book[] Books = new Book[100];
        public Member[] Members = new Member[50];
        public Transaction[] Transactions = new Transaction[200];

        public static int TotalBorrowedBooks = 0;

        int bookIndex = 0;
        int memberIndex = 0;
        int transactionIndex = 0;


        public Library(int maxBooks, int maxMembers, int maxTransactions)
        {
            Books = new Book[maxBooks];
            Members = new Member[maxMembers];
            Transactions = new Transaction[maxTransactions];
        }




        public void AddBook(Book book)
        {
            Books[bookIndex++] = book;
            Console.WriteLine("Book added successfully.");
        }




        public void AddMember(Member member)
        {
            Members[memberIndex++] = member;
            Console.WriteLine("Member added successfully.");
        }



        public void BorrowBook(int memberId, int bookId)
        {
            Member member = FindMember(memberId);
            Book book = FindBook(bookId);

            if (member == null || book == null) { Console.WriteLine("Invalid Member or Book!"); return; }

            member.BorrowBook(book);
            TotalBorrowedBooks++;

            Transactions[transactionIndex++] = new Transaction(transactionIndex, book.Title, member.Name, TransactionType.Borrow);
        }




        public void ReturnBook(int memberId, int bookId, int daysLate)
        {
            Member member = FindMember(memberId);
            Book book = FindBook(bookId);

            if (member == null || book == null) { Console.WriteLine("Invalid Member or Book!"); return; }

            member.ReturnBook(book);
            TotalBorrowedBooks--;

            double fine = member.CalculateFine(daysLate);
            if (fine > 0) Console.WriteLine($"{member.Name} has a fine: {fine}");

            Transactions[transactionIndex++] = new Transaction(transactionIndex, book.Title, member.Name, TransactionType.Return);
        }

        public void PrintTransactions()

        {
            Console.WriteLine("=== Transactions ===");
            for (int i = 0; i < transactionIndex; i++)
                Transactions[i].Display();
        }

        private Book FindBook(int id)
        {
            for (int i = 0; i < bookIndex; i++)
                if (Books[i].Id == id) return Books[i];
            return null;
        }

        private Member FindMember(int id)
        {
            for (int i = 0; i < memberIndex; i++)
                if (Members[i].Id == id) return Members[i];
            return null;
        }









    }
}
