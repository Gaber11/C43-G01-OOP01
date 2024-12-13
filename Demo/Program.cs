using common;

namespace Demo
{
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
            TypeA1 type1 = new TypeA1(); //Internal --> Access through project itself
            
            TypeB1 type2= new TypeB1(); //Public--> Access through all projects / solution
            type2.X = 10; //Not accessable it is private 
            type2.Y = 20; //Not accessable it is internal and through other project
            type2.Z = 50; //Accessable it is public and through solution 

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

            #region

            #endregion

            #region

            #endregion

        }
    }
}
