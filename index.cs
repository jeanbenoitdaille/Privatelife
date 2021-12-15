    using System;
     
    namespace Coding.Exercise
    {
        public class Door 
        {
            public void Open(){
                Console.WriteLine("The door is open.");
            }
        }
     
        public class Exercise
        {
                public static void Main()
                {
                    var door = new Door();
                    door.Open();
                }
        }
    }