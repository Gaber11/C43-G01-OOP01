using common;

namespace Demo
{
    class Employee
    {
        public int Id;
        public string Name;
        public double Salary;
        public Gender gender;
        public Role role;
        public Grade grade;
    }
    enum Role
    {
        Admin,
        Editor,
        Viewer
    }
    enum Gender
    {
        Male,
        Female
    }
    enum Grade
    {
        A,
        B,
        C,
        D,
        E,
        F
    }
    enum Branches
    {
        Alex =1,
        Cairo = 2,
        AlDokki =3,
            Suadi=4
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Class Library

            #endregion

            #region 2-Access modifiers
            //what we can write inside class or struct?
            //Attributes.
            //Proberties.
            //Function --> [Constructor - getter setter - Methods]
            //Events
            //TypeA1 type1 = new TypeA1(); //Internal --> Access through project itself

            //TypeB1 type2= new TypeB1(); //Public--> Access through all projects / solution
            //type2.X = 10; //Not accessable it is private 
            //type2.Y = 20; //Not accessable it is internal and through other project
            //type2.Z = 50; //Accessable it is public and through solution 

            //Alowed access modifier in class:
            //private
            //protected private
            //protected
            //Internal
            //protected internal
            //public

            //Alowed access modifier in struct:
            //private
            //internal
            //public
            //not protected //bot have inhertence.


            #endregion

            #region 3 -Enums Part 1
            Employee emp = new Employee();
            emp.Name = "Gaber";
            emp.Id = 10;
            emp.Salary = 1000;
            emp.gender = Gender.Male;
            emp.role = Role.Admin;
            emp.grade = Grade.A;

            //Console.WriteLine(Gender.Male);

            //if (Grade == Grade.A)
            //{ 
            //Console.WriteLine("Excellant");

            //}
            //   else Console.WriteLine("Bad");
            //Role role = (Role)1;
            //role = (Role)10;
            //Console.WriteLine(role); 
            //Console.WriteLine("please, Enter the grade");
            //Grade grade =(Grade) Enum.Parse(typeof(Grade),Console.ReadLine());
            //Console.WriteLine(grade); 
            //bool flag = Enum.TryParse(typeof(Grade), Console.ReadLine(), out object? X);
            //Console.WriteLine(X);
            //Console.WriteLine(flag);

            //Console.WriteLine("Blease Enter the branch: ");
            //Branches branch = (Branches)Enum.Parse(typeof(Branches),Console.ReadLine());
            //Console.WriteLine(branch);
            //bool Result= Enum.TryParse(typeof(Branches),Console.ReadLine(),out object? X);
            //Console.WriteLine(Result);
            //Console.WriteLine(X);

            #endregion

            #region 4 - Enums Part 2
            //Console.WriteLine("Enter the Gender");
            //Gender gender;
            //gender=(Gender)Enum.Parse(typeof(Gender),Console.ReadLine());

            // bool Result = Enum.TryParse(typeof(Gender), Console.ReadLine(), out object? gender);
            //Console.WriteLine(Result);
            //Console.WriteLine(gender);

           // bool Result = Enum.TryParse<Gender>(Console.ReadLine(), true, out Gender gender);
            //Console.WriteLine(Result);
          //  Console.WriteLine(gender);

           // Gender g1 = new Gender();
           // Console.WriteLine(g1);   //default value (0)


            #endregion

            #region

            #endregion

            #region

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

