namespace ATM.Clients;

public class RegisterClient : IRegisterClient
{
    private Client client = new Client();
    
    public string SetName()
    {
        Console.WriteLine("Digite seu Nome:                          ");
        string name = Console.ReadLine();
        client.Name = name;
        return name;
    }

    public string SetCPF()
    {
        Console.WriteLine("=============================== ");
        Console.WriteLine(" Digite o CPF:                  ");
        string cpf = Console.ReadLine();
        client.CPF = cpf;
        return cpf;
    }

    public string SetPassword()
    {
        Console.WriteLine("=============================== ");
        Console.WriteLine(" Digite a senha:                  ");
        string password = Console.ReadLine();
        client.Password = password;
        return password;
    }
}