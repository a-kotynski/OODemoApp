using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  https://www.youtube.com/watch?v=4sxyDXt1igs
 *  Inheritance is when you have a base class and a class that inherits from that base class
 *  Inheritance is not code-sharing
 *  for code-sharing use seperate library or separate class and referene it in two different locations
    
 *  Requires "Is-a" relationship
 *  Need to share common logic
 *  Sharing just properties or method signatures is not enough
 *  Inheritance can put you in a corner
 *  You need to ask the question: What is the point?
 *  
 *  
 *  Interfaces are good if over time new business cases emerge (like motorboat, sailboat, etc.)
 *  It's a good practice to study the context of a business before coding everything 
 *  
 *  Is this correct?:
 *  polymorphic behaviour   = parent over the child  => attributes passed to the parent
 *  inheritance             = child over the parent => attributes passed to the child
 *  abstraction             = filtering out the calls/attributes
 *  interface               = patterns with definition towards attributes like that of a quilt
 *  
 *  
 */

// Rental agency in Miami, FL

namespace BetterOODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRental> rentals = new List<IRental>();

            rentals.Add(new Truck() { CurrentRenter = "Truck Renter" });
            rentals.Add(new Sailboat(){ CurrentRenter = "Sailboat Renter"});
            rentals.Add(new Car() { CurrentRenter = "Car Renter" });

            foreach (var r in rentals)
            {
                if (r is Truck t)
                {
                     
                }
            }
        }
    }
}