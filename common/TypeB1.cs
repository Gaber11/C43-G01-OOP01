using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class TypeB1
    {
        private int X; //Accessible its scope
        internal int Y; // Accessible in the project
        public int Z; //Accessible through solution 
        
        TypeA1 obj= new TypeA1();
        TypeB1 typeB = new TypeB1();
        
        

           void Print()
        {
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(Z);


        }

    }
    
}
