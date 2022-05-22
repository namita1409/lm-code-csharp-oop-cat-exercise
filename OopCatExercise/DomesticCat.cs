using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public DomesticCat() {

            IsAsleep = false;
            Setting = "domestic";
            AverageHeight = 23;
        }
        public void GoToSleep() {
            Sleep(true);        }

        public void WakeUp() {
            Sleep(false);        }

        public override string Eat()
        {
            Random randomNo = new Random();
            int randomDomesticCat = randomNo.Next(0,10);
            if (randomDomesticCat < 5)
                return "It will do I suppose";
            else
                return "Purrrrrrr";
        }

       
    }
}
