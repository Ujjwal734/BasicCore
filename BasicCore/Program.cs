using BasicCore;
Console.WriteLine("Hello, Welcome to Basic-Core Programe...!");
Console.WriteLine("What you want to do...:- Choose Option ");
Console.WriteLine("1. FlipCoin \n2. Leapyear \n3. Table of power 2\n4. Harmonic Number\n5. Prime Factor\n6. Quotient Remainder\n7. Exit");
int option = Convert.ToInt32(Console.ReadLine());
bool flag= true;
while (true)
{
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
            Harmonic harmonic = new Harmonic();
            harmonic.HarmonicNum();
            break;
        case 5:
            Factor factor = new Factor();
            Console.WriteLine("Enter a number :- ");
            int num = Convert.ToInt32(Console.ReadLine());
            factor.PrimFact(num);
            break;
        case 6:
            Division division = new Division();
            division.QutRem();
            break;
        case 7:
            flag = false;
            break;
        default:
            Console.WriteLine("Choose correct option to Execute :-");
            break;
    }
}