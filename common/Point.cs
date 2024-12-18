using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
 
    public struct Point
    {
        //what can i write inside struct?
        //Attribute
        //Property
        //function [constructor , getter-setter , method]
        //Events            
         public int X;
        public int Y;
        //user defined constructor , Parameterized constructor
        //Constructor overloading
        public Point()
        {
            X = default;
            Y = default;
            //Allowed access modifier inside struct :
            //private : [default access modifier].
            //public
            //Internal     

        }
        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public Point(int Num1)
        {
            X = Y=Num1;
        }
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }
    }

}
