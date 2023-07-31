using ATM.Clients;

namespace ATM.Deposit;

public interface IDeposit
{
    void DepositReal(Client user);
    void DepositDolar(Client user);
}