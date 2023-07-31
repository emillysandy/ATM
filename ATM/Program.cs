using ATM.Clients;
using ATM.Deposit;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterClient registerClient = new RegisterClient();
            registerClient.SetName();
            registerClient.SetCPF();
            registerClient.SetPassword();
        }
    }
}