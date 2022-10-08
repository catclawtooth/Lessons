Console.WriteLine("Input 1 ");
string str1 = Console.ReadLine();
int a = int.Parse(str1);

Console.WriteLine("Input 2 ");
string str2 = Console.ReadLine();
int b = Convert.ToInt32(str2);

Console.WriteLine("Input 3 ");
string str3 = Console.ReadLine();
int c = Convert.ToInt32(str3);

int res1 = a + b + c;
int res2 = a * b * c;
Console.WriteLine("& = " + res1);
Console.WriteLine("* = " + res2);