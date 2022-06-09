using CallbackInterface;

Bank bank = new Bank("My Bank", 3000);
bank.AddSink(new BankSink());
Random random = new Random();
while (bank.Savings >= 100)
{
    bank.WithdrawMoney(random.NextDouble() * 100);
}