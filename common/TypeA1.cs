using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    
    internal class TypeA1
    {
        public TypeA1()
        {
         TypeB1 obj = new TypeB1();
         obj.Y = 1; //Accessable because it is internal
            obj.X = 10; //Not accessable because it is private 
            obj.Z = 20; //Accessable because it is public
        }



     

    }
}
