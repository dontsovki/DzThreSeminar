//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. число, буквосочетание, слово или текст, одинаково читающееся в обоих направлениях

Console.Clear();
Console.Write("введите любое пятизначное число ");
string str = Console.ReadLine();
   
char[] a=str.ToCharArray();
int len = a.Length;

void five()
{
if (len != 5)
   {
      Console.WriteLine($"Вы ввели число {str} оно не является пятизначным");
      return;
   }
else if (a[0]!=a[4])
   Console.WriteLine($"Вы ввели число {str} оно не является палиндромом");
else if (a[1]!=a[3])
   Console.WriteLine($"Вы ввели число {str} оно не является палиндромом");
else
Console.WriteLine($"Вы ввели число {str} оно является палиндромом");
}
   
five();


//void palindrom()
//{
//if (a[0]!=a[4])
//   Console.WriteLine($"Вы ввели число {str} оно не является палиндромом");
//else if (a[1]!=a[3])
//   Console.WriteLine($"Вы ввели число {str} оно не является палиндромом");
//else
//Console.WriteLine($"Вы ввели число {str} оно является палиндромом");
//}
//palindrom();

