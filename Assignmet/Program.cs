namespace Assignmet
{
    internal class Program
    {
        #region Q1
        // enum WeekDays
        //{
        //    monday,
        //    tuesday,
        //    wednesday,
        //    thursday,
        //    friday,
        //    sutarday,
        //    sunday
        //}
        #endregion

        #region Q3)
        enum Season
        {
            Spring = 1,
            Summer = 2,
            Autumn = 3,
            Winter = 4
        }
        #endregion

        #region Q4)
        enum Premession
        {
            Read=1,
            write=2,
            Delete=4,
            Execute=8

        }


        #endregion
        static void Main(string[] args)
        {

            #region 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //Console.WriteLine("Week Days: ");

            //for (int i = 0; i <= (int)WeekDays.sunday; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}

            #endregion

            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] person = new Person[4];
            //person[0] = new Person("Gaber", 24);
            //person[1] = new Person("Ahmed", 22);
            //person[2] = new Person("Hassan", 23);
            //person[3] = new Person("Abdo", 19);


            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Name: {person[i].Name}, Age: {person[i].Age}");
            //}


            #endregion

            #region 3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter a season [Spring, Summer, Autumn, Winter]: ");
            //bool Result =Enum.TryParse<Season>(Console.ReadLine(),true,out  Season season);

            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("march,April , may");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("june ,july , august ");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("September ,October , November ");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("December ,jenuary , February ");
            //        break;

            //}




            #endregion

            #region 4.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            //Premession premession = new Premession();
        
            //Console.WriteLine("Adding Permissions: ");
            //premession = Premession.Read | Premession.Delete | Premession.Execute; // Add Read and Delete permission
            //Console.WriteLine("After Adding Read and Delete: " + premession);
            //Console.WriteLine("======================================================");
            //Console.WriteLine("Removing Permissions: ");
            //premession = premession ^ Premession.Delete; // Removing Delete permission
            //Console.WriteLine("After Removing Delete: " + premession);
            //Console.WriteLine("======================================================");
            //Console.WriteLine("Check: ");
           
            //bool YesWrite = (premession & Premession.write) == Premession.write;
            //Console.WriteLine("Has Write Permission: " + YesWrite);

            //bool YesRead = (premession & Premession.Read) == Premession.Read;
            //Console.WriteLine("Has Read Permission: " + YesRead);




            #endregion

            #region

            #endregion

            #region

            #endregion

            #region

            #endregion

        }
    }
}
