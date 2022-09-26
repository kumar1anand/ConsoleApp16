namespace ConsoleApp13
{

    internal class Program
    {
        public class people
        {
            bool take_a_book;
            bool give_attendance;
            bool take_attendance;
            bool attend_class;
            bool take_class;
            bool allot_a_book;
        }
        public class Student : people
        {
            public void Can_do(bool take_a_book, bool give_attendance, bool attend_class)
            {
                Console.WriteLine("Student can take a book: " + take_a_book);
                Console.WriteLine("Student can give attendance: " + give_attendance);
                Console.WriteLine("Student can attend class: " + attend_class);
            }
        }

        public class Teacher : people
        {
            public void Can_do(bool take_class, bool give_attendance, bool take_attendance, bool take_book)
            {
                Console.WriteLine("Teacher can take class: " + take_class);
                Console.WriteLine("Teacher can give attendance: " + give_attendance);
                Console.WriteLine("Teacher can take attendance: " + take_attendance);
                Console.WriteLine("Teacher can take book: " + take_book);
            }

        }

        public class Librarian : people
        {
            public void Can_do(bool allot_a_book, bool give_attendance)
            {
                Console.WriteLine("librarian can attlt a book: " + allot_a_book);
                Console.WriteLine("librarian can give attendance: " + give_attendance);
            }
        }
        static void Main(string[] args)
        {


            Student s = new Student();
            s.Can_do(true, true, true);

            Teacher t = new Teacher();
            t.Can_do(true, false, true, false);

            Librarian l = new Librarian();
            l.Can_do(true, false);
        }
    }
}