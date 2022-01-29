using BasicCore;
Console.WriteLine("Hello, Welcome to Basic-Core Programe...!");
Console.WriteLine("1. FlipCoin ");
bool flag= true;
while(true)
{
    int optionToExecute = Convert.ToInt32(Console.ReadLine());
    switch (optionToExecute)
    {
        case 1:
            FlipCoin flipcoin = new FlipCoin();
            flipcoin.Flip();
            break;
        default:
            Console.WriteLine("Choose correct option to Execute :-");
            break;
    }
}