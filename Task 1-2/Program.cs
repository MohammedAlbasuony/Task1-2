namespace Task_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student name :  ");
            string StdName = Console.ReadLine();

            Console.Write("Enter Student ID :  ");
            int StdID = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Student Department :  ");
            string StdDept = Console.ReadLine();
            
            Console.Write("Enter Student Age :  ");
            int StdAge = int.Parse(Console.ReadLine());
            
            Console.Write($"Your name is : {StdName} \n  Your Age is : {StdAge} \n  Your ID is : {StdID}  \n Your Department is : {StdDept} ");
        }
    }
}
