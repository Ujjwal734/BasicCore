using BasicCore;
Console.WriteLine("Hello, Welcome to Basic-Core Programe...!");
Console.WriteLine("What you want to do...:- Choose Option ");
Console.WriteLine("1. FlipCoin \n2. Leapyear \n3. Table of power 2\n4. Exit");
int option = Convert.ToInt32(Console.ReadLine());
bool flag= true;
while(true)
switch (option)
{
    case 1:
            FlipCoin flipcoin = new FlipCoin();
            flipcoin.Flip();
            break;
    case 2:
            LeapYeer leapyear = new LeapYeer();
            Console.WriteLine("Enter a year :- ");
            int yeer = Convert.ToInt32(Console.ReadLine());
            leapyear.Year(yeer);
            break;
    case 3:
            Table table = new Table();
            table.Power();
            break;
    case 4:
            flag= false;
            break;
    default:
            Console.WriteLine("Choose correct option to Execute :-");
            break;
}