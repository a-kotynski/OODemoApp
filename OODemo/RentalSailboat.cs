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
    public class RentalSailboat : RentalVehicle
    {
        public override void StartEngine()
        {
            throw new Exception("I do not have an engine to start"); //what is throw??
        }
        public override void StopEngine()
        {
            throw new Exception("I do not have an engine to stop");
        }
    }
}