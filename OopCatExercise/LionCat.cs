using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise 
{
    public class LionCat : Cat
    { 
        public LionCat() {
            AverageHeight = 1100;
        }   
    
        public override string Eat()
        {
            return "Roar!!!!";
        }

       
    }
}
