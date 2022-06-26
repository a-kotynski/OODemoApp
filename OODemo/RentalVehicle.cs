/*  https://www.youtube.com/watch?v=4sxyDXt1igs
 *  Inheritance is when you have a base class and a class that inherits from that base class
 *  Inheritance is not code-sharing
 *  for code-sharing use seperate library or separate class and referene it in two different locations
    
 *  Is-a relationship
 *  Need to share common logic
 *  Sharing just properties or method signatures is not enough
 *  Inheritance can put you in a corner
 *  You need to ask the question: What is the point?
 *  
 */

// Rental agency in Miami, FL

namespace BetterOODemo
{
    public class RentalVehicle
    {
        public int RentalID { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
        public int NumberOfPassengers { get; set; }
        

        public virtual void StartEngine()
        {
            Console.WriteLine("Turn key to ignition setting");
            Console.WriteLine("Turn key to on");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Turn key to off");
        }
    }
}