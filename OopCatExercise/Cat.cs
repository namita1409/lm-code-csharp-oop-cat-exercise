using System;
namespace OopCatExercise
{
    public abstract class Cat : ICat
    {

        public Cat() {
            
        }
        private string setting;
        private int averageHeight;
        private bool isAsleep;

        public string Setting
        {
            get { return setting; }
            set { setting = value; }
        }
        
        public int AverageHeight {
            get { return averageHeight; }
            set { averageHeight = value; } 
        }
        
        public bool IsAsleep
        {
            get { return isAsleep; }
            set { isAsleep = value; }
        }

        public abstract string Eat();
        public bool Sleep(bool sleepOrAwake)
   {
       IsAsleep = sleepOrAwake;
       return IsAsleep;


   }
  

}
    }
