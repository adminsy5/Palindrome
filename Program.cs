//Palindrome Programme Vb.net
namespace Palindronme
{
    class program
    {
        public static void Main(string[] args)
        {
            int num, temp, revNum = 0, rem;
            Console.WriteLine("Enter the number :");

            num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while(num>0)
            {
                rem = num % 10;
                revNum = revNum * 10 + rem;
                num = num / 10;
            }

            if (revNum == temp)
            {

                Console.WriteLine("This is palindrome !");
            }

            else
            {
                Console.WriteLine("This is Not palindrome !");
            }
            Console.ReadLine();
        }
    }
}