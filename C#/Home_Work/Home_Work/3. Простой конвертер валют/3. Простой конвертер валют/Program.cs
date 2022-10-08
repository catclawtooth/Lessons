Console.WriteLine("Сколько доллоров вы хотите перевести в РУБли?");
string str = Console.ReadLine();
//int a = Convert.ToInt32(str);\
int a = int.Parse(str);
int b = 60;
int res = a * b;
Console.WriteLine("Ваши доллары равны " + res + " рублей");
