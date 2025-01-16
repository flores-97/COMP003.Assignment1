/*Author:Victor Flores
 *Course: COMP003A
 *Faculty: Jonathon Cruz
 *Purpose: ASsigment 1
 */
namespace COMP003.Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string username = Console.ReadLine();
            Console.WriteLine("Hello " + username + ". My name is Victor");
           
            Console.WriteLine("Here are ten things about me:" +
                "\n\t1. I like to watch Star Wars." +
                "\n\t2. I enjoy building Lego Star Wars and have built over 15." +
                "\n\t3. I have traveled to three countries already." +
                "\n\t4. I have two dogs, one maltipoo and one shit tzu." +
                "\n\t5. My wife and I will be celebrating our two year anniversary at the beginning of March. " +
                "\n\t6. I have been playing soccer for over 12 years. " +
                "\n\t7. My favorite soccer team is Manchester United. " +
                "\n\t8. My favorite soccer cleat is the Nike Tiempo and the Nike Total 90." +
                "\n\t9. I have been in the US Navy for 9 years. " +
                "\n\t10. My contract will end in two years.");
        }
    }
}
