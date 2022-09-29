
/*void zadacha25(); 
  Используя определение степени числа, 
    напишите цикл, который принимает на вход два натуральных числа 
     (A и B) и возводит число A в степень B.
     3, 5 -> 243 (3⁵)
     2, 4 -> 16 */
{

int power(int baseNum, int deg)
{
    int result = 1;

    for (int i = 0; i < deg; i++)
        result *= baseNum;

    return result;
}


int number = 0;
int degree = 0;

Console.Write("Input A: ");
number = Convert.ToInt32(Console.ReadLine());

while (true)
{
    Console.Write("Input B: ");
    degree = Convert.ToInt32(Console.ReadLine());
    if (degree > 0)
        break;
    else
        Console.WriteLine("The degree must be more then 0");
}


Console.WriteLine(power(number, degree));


}

   
  
  
 /*void zadacha27();
  

    /*Напишите программу, которая принимает на вход число и выдаёт
    сумму цифр в числе 452-> 11, 82-> 10, 9012-> 12 */
{
    int SumNumber(string number, int counter)
    {

        int numberN = Convert.ToInt32(number);
        int result = 0;

        for (int i = 0; i < counter; i++)
        {
            result = result + numberN % 10;
            numberN = numberN / 10;
        }
        return result;
    }
    Console.Write("Введите число: ");
    string numberN = Console.ReadLine() ?? "0";

    int sumNumber = SumNumber(numberN, numberN.Length);
    Console.WriteLine("Сумма цифр в числе: " + sumNumber);

}



//void zadacha29();
/*Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19] 
6, 1, -33 -> [1, 6, -33]*/


void printArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    Console.WriteLine(" ]");
}


int[] fillArray()
{
    Random rnd = new Random();
    int[] array = new int[rnd.Next(10, 15)];

    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }

    return array;
}

int[] Sorter(int[] arrayIn)
{
    int len = arrayIn.Length;
    for (int i = 0; i < len; i++)
        for (int j = i; j < len; j++)
            if (arrayIn[j] < arrayIn[i])
            {
                int tmp = arrayIn[j];
                arrayIn[j] = arrayIn[i];
                arrayIn[i] = tmp;
            }
    return arrayIn;
}

int[] someArr = fillArray();
printArray(someArr);
Console.WriteLine();
printArray(Sorter(someArr));


//zadacha25();
//zadacha27();
//zadacha29();
