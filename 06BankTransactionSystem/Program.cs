class BankAccount
{
    public string? AccountHolderName { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountHolderName, decimal initialBalance)
    {
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException($"Initial amount should be greater than 0...!");
        }
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException($"Withdrawal amount should be greater than 0...!");
        }

        if (amount > Balance)
        {
            throw new ArgumentException("Transfer failed : Insufficient balance");
        }

        Balance -= amount;
    }

    public void DisplayDetails()
    {
        System.Console.WriteLine($"\nAccount Holder Name : {AccountHolderName}");
        System.Console.WriteLine($"Total Balance : {Balance}");
    }

}

abstract class Transaction
{
    protected BankAccount Account;
    public decimal Amount { get; set; }

    public Transaction(BankAccount account, decimal amount)
    {
        Account = account;
        Amount = amount;
    }

    public abstract void Proccess();

}

class DepositTransaction : Transaction
{
    public DepositTransaction(BankAccount account, decimal amount) : base(account, amount)
    {
    }

    public override void Proccess()
    {
        Account.Deposit(Amount);
        System.Console.WriteLine("Deposit successfull...!");
    }
}

class WithdrawTransaction : Transaction
{
    public WithdrawTransaction(BankAccount account, decimal amount) : base(account, amount)
    {
    }

    public override void Proccess()
    {
        Account.Withdraw(Amount);
        System.Console.WriteLine("Withdrawal successfull...!");
    }
}

class TransferTransaction : Transaction
{
    private BankAccount receiverAccount;

    public TransferTransaction(BankAccount senderAccount, BankAccount recreceiverAccount, decimal amount) : base(senderAccount, amount)
    {
        this.receiverAccount = recreceiverAccount;
    }

    public override void Proccess()
    {
        Account.Withdraw(Amount);
        receiverAccount.Deposit(Amount);

        System.Console.WriteLine("Transfer successfull...!");
    }

}

class Test
{
    public static void Main()
    {
        BankAccount aniketAccount = new BankAccount("Aniket", 50000);
        BankAccount vedantAccount = new BankAccount("Vedant", 30000);
        BankAccount akashAccount = new BankAccount("Akash", 80000);

        Console.WriteLine("=== Initial Account Details ===");

        aniketAccount.DisplayDetails();
        vedantAccount.DisplayDetails();
        akashAccount.DisplayDetails();

        List<Transaction> transactions = new List<Transaction>()
    {
        new DepositTransaction(aniketAccount, 1500),

        new WithdrawTransaction(vedantAccount, 5000),

        // new  WithdrawTransaction(aniketAccount,60000),  // Transfer failed : Insufficient balance

        // new TransferTransaction(
        //     aniketAccount,
        //     akashAccount,
        //     60000
        // ),       // Transfer failed : Insufficient balance

        new TransferTransaction(
            aniketAccount,
            akashAccount,
            10000
        ),

        new TransferTransaction(
            akashAccount,
            vedantAccount,
            20000
        )
    };

        Console.WriteLine("\n=== Processing Transactions ===");

        foreach (Transaction transaction in transactions)
        {
            transaction.Proccess();
        }

        Console.WriteLine("\n=== Final Account Details ===");

        aniketAccount.DisplayDetails();
        vedantAccount.DisplayDetails();
        akashAccount.DisplayDetails();
    }

}