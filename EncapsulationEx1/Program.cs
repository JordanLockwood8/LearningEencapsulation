using EncapsulationEx1;

var bankAcct1 = new BankAccount();
Console.WriteLine("Welcome to Your bank. What would you like to do?");
Console.WriteLine("withdraw, deposit, or checkbalance");
var input =Console.ReadLine();

if (input == "withdraw")
{
    bankAcct1.Withdraw();
    bankAcct1.GetBalance();
}
else if(input == "deposit")
{
    bankAcct1.Deposit();
    bankAcct1.GetBalance();
}
else if( input == "checkbalance")
{
    bankAcct1.GetBalance();
}
else
{
    Console.WriteLine(" Improper input");
}
