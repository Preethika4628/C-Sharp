using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncfusionLibrary
{
    public class Operation
    {
        static List<UserDetails> userList = new List<UserDetails>();
        static List<BookDetails> bookList = new List<BookDetails>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static UserDetails currentUserLogin;
        public static void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("Ravichandran", Gender.Male, DepartmentType.ECE, 9938388333, "ravi@gmail.com", 100);
            userList.Add(user1);
            UserDetails user2 = new UserDetails("Priyadharshini", Gender.Female, DepartmentType.CSE, 9944444455, "priya@gmail.com", 150);
            userList.Add(user2);

            BookDetails book1 = new BookDetails("C#", "Author1", 3);
            bookList.Add(book1);
            BookDetails book2 = new BookDetails("HTML", "Author2", 5);
            bookList.Add(book2);
            BookDetails book3 = new BookDetails("CSS", "Author1", 3);
            bookList.Add(book3);
            BookDetails book4 = new BookDetails("JS", "Author1", 3);
            bookList.Add(book4);
            BookDetails book5 = new BookDetails("TS", "Author2", 2);
            bookList.Add(book5);

            BorrowDetails borrow1 = new BorrowDetails("SF3001", "BID1001", new DateTime(2023, 09, 10), 2, Status.Borrowed, 0);
            borrowList.Add(borrow1);
            BorrowDetails borrow2 = new BorrowDetails("SF3001", "BID1003", new DateTime(2023, 09, 12), 1, Status.Borrowed, 0);
            borrowList.Add(borrow2);
            BorrowDetails borrow3 = new BorrowDetails("SF3001", "BID1004", new DateTime(2023, 09, 14), 1, Status.Returned, 16);
            borrowList.Add(borrow3);
            BorrowDetails borrow4 = new BorrowDetails("SF3002", "BID1002", new DateTime(2024, 04, 5), 1, Status.Borrowed, 0);
            borrowList.Add(borrow4);
            BorrowDetails borrow5 = new BorrowDetails("SF3002", "BID1005", new DateTime(2023, 09, 09), 1, Status.Returned, 20);
            borrowList.Add(borrow5);

            Console.WriteLine("User Details:-");
            foreach (UserDetails user in userList)
            {
                Console.WriteLine($"{user.UserID,-10}  |  {user.UserName,-10}  |  {user.Gender,-8}  |  {user.Department,-5}  |  {user.MobileNumber,-10}  |  {user.MailID,-15}  |  {user.WalletBalance,-8}");
            }
            Console.WriteLine("Book Details:-");
            foreach (BookDetails book in bookList)
            {
                Console.WriteLine($"{book.BookID,-10}  |  {book.BookName,-5}  |  {book.AuthorName,-8}  |  {book.BookCount,-5}");
            }
            Console.WriteLine("Borrower Details:-");
            foreach (BorrowDetails borrow in borrowList)
            {
                Console.WriteLine($"{borrow.BorrowerID,-10}  |  {borrow.UserID,-10}  |  {borrow.BookID,-10}  |  {borrow.BorrowedDate.ToString("dd/MM/yyyy"),-10}  |  {borrow.BorrowerBookCount,-3}  |  {borrow.Status,-10}  |  {borrow.PaidFineAmount,-8}");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose: 1.User Registration  2.User Login  3.Exit  : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Registration();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        Console.WriteLine("Exitting the application");
                        flag = false;
                        break;
                    default:
                        flag = false;
                        break;
                }
            } while (flag);
        }
        public static void Registration()
        {
            Console.WriteLine("Registration Form: ");
            Console.Write("Enter you name: ");
            string userName = Console.ReadLine();
            Console.Write("Choose your gender: 1.Male  2.Female  3.Transgender : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());
            Console.Write("Choose your department: 1.ECE  2.EEE  3.CSE  : ");
            DepartmentType department = Enum.Parse<DepartmentType>(Console.ReadLine());
            Console.Write("Enter your mobile number: ");
            long mobileNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter your mailID: ");
            string emailID = Console.ReadLine();
            Console.Write("Enter your Wallet Balance: ");
            double walletBalance = double.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(userName, gender, department, mobileNumber, emailID, walletBalance);
            userList.Add(user);
            Console.WriteLine($"Registration done Successfully. Your UserID is {user.UserID}");
        }
        public static void Login()
        {
            bool flag = true;
            Console.Write("Enter your User ID: ");
            string userID = Console.ReadLine().ToUpper();
            foreach (UserDetails user in userList)
            {
                if (userID == user.UserID)
                {
                    Console.WriteLine("Logged in Successfully");
                    currentUserLogin = user;
                    flag = false;
                    SubMenu();
                }
            }
            if (flag)
            {
                Console.WriteLine("Mentioned UserID is not found");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.Borrow Book  2.Show Borrow History  3.Return Books  4.Wallet Recharge  5.Exit  : ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            BorrowBook();
                            break;
                        }
                    case 2:
                        {
                            ShowBorrowedHistory();
                            break;
                        }
                    case 3:
                        {
                            ReturnBooks();
                            break;
                        }
                    case 4:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Exitting the Login");
                            flag = false;
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void BorrowBook()
        {
            //Show the list of Books available by printing BookID, BookName, AuthorName, BookCount.
            Console.WriteLine("Book Details:-");
            foreach (BookDetails book in bookList)
            {
                Console.WriteLine($"{book.BookID,-10}  |  {book.BookName,-5}  |  {book.AuthorName,-8}  |  {book.BookCount,-5}");
            }
            //Then Ask the user to pick one book by Asking “Enter Book ID to borrow”.
            Console.Write("Enter the bookID: ");
            string bookID = Console.ReadLine().ToUpper();
            bool flag = true;
            int totalCount = 0;
            foreach (BorrowDetails borrow in borrowList)
            {
                if (currentUserLogin.UserID == borrow.UserID && borrow.Status == Status.Borrowed)
                {
                    totalCount = totalCount + borrow.BorrowerBookCount;
                }
            }
            foreach (BookDetails book in bookList)
            {
                //Check whether “BookID” is available or not.
                if (bookID == book.BookID)
                {
                    flag = false;
                    // ask the user to “Enter the count of the book”.
                    Console.Write("Enter the number of book you want: ");
                    int count = int.Parse(Console.ReadLine());
                    //Check the book count availability of the book selected.
                    if (count <= book.BookCount)
                    {
                        //If the book is available to borrow, 
                        // need to check whether the user already have any borrowed book. Because user can have a maximum of only 3 borrowed books at a time. 
                        if (totalCount + count <= 3)
                        {
                            //Else allocate the book to the user and set status of the Booking Details as "Borrowed” and set the “BorrowedDate” as today’s date and “PaidFineAmount” as 0. 
                            // Create the Borrow Details object then store it and show “Book Borrowed successfully”.
                            BorrowDetails borrow1 = new BorrowDetails(currentUserLogin.UserID, book.BookID, DateTime.Today, count, Status.Borrowed, 0);
                            borrowList.Add(borrow1);
                            Console.WriteLine("Book borrowed successfully. Your ID " + borrow1.BorrowerID);
                            book.BookCount = book.BookCount - count;
                        }
                        else
                        {
                            Console.WriteLine("You can have maximum of 3 borrowed books. You have already borrowed 3 books");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Books are not available for the selected count");
                        //  And print the next available date of book by getting that book’s “BorrowedDate” from the borrowed history information and adding with 15 days  the borrowed date of that book. 
                        //  Show “The book will be available on {borrowed date + 15 days}”. 
                        foreach (BorrowDetails borrow in borrowList)
                        {
                            // If user having 3 borrowed books already then show “You have borrowed 3 books already”.
                            // If the user’s already borrowed book count and requested book count exceeds 3 count, then show “You can have maximum of 3 borrowed books. Your already borrowed books count is {BorrowBookCount} and requested count is {Current Requested Count}, which exceeds 3 ”.
                            if (book.BookID == borrow.BookID)
                            {
                                Console.WriteLine($"The book avaiable on next date on {borrow.BorrowedDate.AddDays(15).ToString("dd/MM/yyyy")}");
                                break;
                            }
                        }
                    }
                }
            }
            if (flag)
            {
                //If not available display “ Invalid Book ID, Please enter valid ID”, 
                Console.WriteLine("Book ID not found");
            }
        }
        public static void ShowBorrowedHistory()
        {
            bool flag = true;
            Console.WriteLine("Borrower Details:-");
            foreach (BorrowDetails borrow in borrowList)
            {
                if (currentUserLogin.UserID == borrow.UserID)
                {
                    Console.WriteLine($"{borrow.BorrowerID,-10}  |  {borrow.UserID,-10}  |  {borrow.BookID,-10}  |  {borrow.BorrowedDate.ToString("dd/MM/yyyy"),-10}  |  {borrow.BorrowerBookCount,-3}  |  {borrow.Status,-10}  |  {borrow.PaidFineAmount,-8}");
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine("No Borrow history found");
            }
        }
        public static void ReturnBooks()
        {
            Console.WriteLine("Borrower Details:-");
            foreach (BorrowDetails borrow in borrowList)
            {
                if (currentUserLogin.UserID == borrow.UserID && borrow.Status == Status.Borrowed)
                {
                    Console.WriteLine($"{borrow.BorrowerID,-10}  |  {borrow.UserID,-10}  |  {borrow.BookID,-10}  |  {borrow.BorrowedDate.ToString("dd/MM/yyyy"),-10}  |  {borrow.BorrowerBookCount,-3}  |  {borrow.Status,-10}  |  {borrow.BorrowedDate.AddDays(15).ToString("dd/MM/yyyy"),-8}");
                }
            }
            Console.WriteLine("Enter the borrowerId you want to cancel: ");
            string borrowID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (BorrowDetails borrow in borrowList)
            {
                // Show the borrowed book details of current user whose status is “borrowed” also Print the return date of each book (Return date will be 15 days after borrowing a book).
                if (borrow.BorrowerID == borrowID && borrow.Status == Status.Borrowed)
                {
                    flag = false;
                    DateTime ActualReturn = borrow.BorrowedDate.AddDays(15);
                    if (ActualReturn < DateTime.Today)
                    {
                        // If the return date is elapsed more than 15 days then calculate and show the fine amount (Rs. 1 / Day) for each book.
                        TimeSpan days = DateTime.Today - ActualReturn;
                        int fine = days.Days;
                        int numOfBook = borrow.BorrowerBookCount;
                        fine *= numOfBook;
                        // Ask him to select the BorrowedID to return book and validate that ID. 
                        if (fine > 0)
                        {
                            // If return date is elapsed, 
                            // a.	then check whether the user have sufficient balance for the fine amount, 
                            if (currentUserLogin.WalletBalance >= fine)
                            {
                                // b. if he has sufficient balance then deduct the fine amount from his Wallet balance and change the Status in Booking History to “Returned” and 
                                // update the fine amount to the “PaidFineAmount” calculated and show “Book returned successfully”. 
                                // Also, update the “BookCount”.
                                // Else, change the Status in Booking History to “Returned” and show Book returned successfully. Also, update the “BookCount”.
                                currentUserLogin.WalletBalance -= fine;
                                borrow.Status = Status.Returned;
                                borrow.PaidFineAmount = fine;
                                foreach (BookDetails book in bookList)
                                {
                                    if (book.BookID == borrow.BookID)
                                    {
                                        book.BookCount += numOfBook;
                                    }
                                }
                                Console.WriteLine("Book returned Successfully");
                            }
                            else
                            {
                                // c.	else show “Insufficient balance. Please rechange and proceed”. 
                                Console.WriteLine("Insufficient Balance. Please recharge");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Borrow ID");
                        }
                    }
                    else if (ActualReturn > DateTime.Today)
                    {
                        Console.WriteLine($"Your due date is {ActualReturn.ToString("dd/MM/yyyy")}");
                    }
                    else
                    {
                        int fine = 0;
                        int numOfBook = borrow.BorrowerBookCount;
                        borrow.Status = Status.Returned;
                        borrow.PaidFineAmount = fine;
                        foreach (BookDetails book in bookList)
                        {
                            if (book.BookID == borrow.BookID)
                            {
                                book.BookCount += numOfBook;
                            }
                        }
                        Console.WriteLine("Book returned Successfully");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("There is no book that is needed to be returned");
            }
        }
        public static void WalletRecharge()
        {
            // Ask the customer whether he wish to recharge the wallet.
            Console.Write("Do you want to recharge? yes/no : ");
            string choice = Console.ReadLine().ToLower();
            if (choice == "yes")
            {
                // If “Yes” then ask for the amount to be recharged
                Console.Write("Enter the amount that is needed to be recharged: "); //500
                double amount = double.Parse(Console.ReadLine()); //1000
                if (amount > 0)
                {
                    // double TotatlRAmount = currentLoginCustomer.Recharge(amount); //1500
                    // update the amount in the wallet and display the updated wallet balance.
                    currentUserLogin.Recharge(amount);
                    // Console.WriteLine($"Total amount in the Wallet: {Recharge}");
                }
                else
                {
                    Console.WriteLine("Enter the amount in Positive above 0");
                    WalletRecharge();
                }
            }
            else
            {
                SubMenu();
            }

        }
    }
}