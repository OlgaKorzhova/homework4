/// Цикл, принимает на вход 2 числа A и B, и возводит A в степень B

int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());


int result = numA;
for (int i = 2; i <= numB; i++)
{
   result *=  numA;
}

Console.WriteLine ($"{numA} ^ {numB} = {result}");



    

