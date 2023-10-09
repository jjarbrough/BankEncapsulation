namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount jamesAcc = new BankAccount(500);
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("type 1 for check balance");
                Console.WriteLine("type 2 for deposit");
                Console.WriteLine("type 3 for withdrawal");
                Console.WriteLine("type 4 for finished");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    jamesAcc.GetBalance();
                }
                else if (option == 2)
                {
                    Console.WriteLine("how much would you like to deposit?");
                    int add = int.Parse(Console.ReadLine());
                    jamesAcc.Deposit(add);
                }
                else if (option == 3)
                {
                    Console.WriteLine("how much would you like to withdraw?");
                    int subtract = int.Parse(Console.ReadLine());
                    jamesAcc.Withdraw(subtract);
                }
                else if (option == 4)
                {
                    Console.WriteLine("bye");
                    finished = true;
                }
            }
        }
    }
}
