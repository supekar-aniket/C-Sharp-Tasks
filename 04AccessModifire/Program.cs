class BankAccount
{
    private string? accountNumber { get; set; }
    protected decimal balance { get; set; }
    public string? bankName { get; set; }
    internal string? branchCode { get; set; }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        if (string.IsNullOrWhiteSpace(accountNumber))
        {
            throw new ArgumentException("AccountNumber cannot be empty...!");
        }
        this.accountNumber = accountNumber;

        if (initialBalance <= 0)
        {
            throw new ArgumentException("Initial balance must be greater than 0...!");
        }
        this.balance = initialBalance;
    }

    public void ShowAccountNumber()
    {
        System.Console.WriteLine("Account Number : " + accountNumber);
    }

    public void ShowBankName()
    {
        System.Console.WriteLine("Bank Name : " + bankName);
    }

    public void ShowBalance()
    {
        System.Console.WriteLine("Total Balance : " + balance);
    }

    public void ShowBranchCode()
    {
        System.Console.WriteLine("Branch Code : " + branchCode);
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, decimal amount) : base(accountNumber, amount)
    {
    }

    public void ShowInheritedData()
    {
        System.Console.WriteLine("\n---- Inherited Data ----");
        // System.Console.WriteLine("Account Number : " + accountNumber);

        System.Console.WriteLine("Bank Name : " + bankName);
        System.Console.WriteLine("Total Balance : " + balance);
        System.Console.WriteLine("Branch Code : " + branchCode);

    }

    public void AddInterest(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Intrest amount must be greater than 0...!");
        }
        balance += amount;
    }
}

class Test
{
    public static void Main()
    {
        SavingsAccount s1 = new SavingsAccount("ACC001", 50000);
        s1.bankName = "State Bank Of India";
        s1.branchCode = "PUNE001";

        System.Console.WriteLine("\n---- Bank Account Details ----");
        s1.ShowAccountNumber();
        s1.ShowBankName();
        s1.ShowBranchCode();
        s1.ShowBalance();
        s1.ShowInheritedData();

        System.Console.WriteLine("\nAdding interest: 5000");
        s1.AddInterest(5000);

        s1.ShowBalance();


    }
}