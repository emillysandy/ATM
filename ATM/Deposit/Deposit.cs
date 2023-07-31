using ATM.Clients;

namespace ATM.Deposit;

public class Deposit
{
    public void DepositReal(Client client)
    {
        Console.WriteLine("\n Valor a ser depositado:                         ");
        double amount = double.Parse(Console.ReadLine());
        Console.WriteLine("Aguarde, estamos realizando o depósito.");
        client.TotalAmount += amount;
            
        Thread.Sleep(1500);
        Console.WriteLine($"\nR${amount} foi depositado.");
    }

    public void DepositDolar(Client client)
    {
        Console.WriteLine("\n Valor a ser depositado:                         ");
        double amount = double.Parse(Console.ReadLine());
        var valorDolar = (amount * 4.8);
        Console.WriteLine("Aguarde, estamos realizando o depósito.");
        client.TotalAmount += valorDolar;
            
        Thread.Sleep(1500);
        Console.WriteLine($"\nR${valorDolar} foi depositado.");
    }
}