Console.WriteLine("Введите пятизначное число: ");
string num = Convert.ToString(Console.ReadLine());

char[] n = num.ToCharArray();

if (n.Length == 5)
{
    if ( n [0] == n [4] && n [1] == n [3] )
    {
        Console.WriteLine("Число является палиндромом! =)");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом :(");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным ;)");
}