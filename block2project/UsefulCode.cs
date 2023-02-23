/* This is a class that can be distributed and added to by contributors who decide to.
 * This class is protected by a MIT License. 
 * Author: Riley Kraabel
 */
namespace block2project
{
    /// <summary>
    ///     This class contains many useful methods for the users and developers.
    /// </summary>
    internal class UsefulCode
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Riley's code is so useful and important " + i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("This counts numbers 10-1. Important number: " + i);
            }
        }
    }
}