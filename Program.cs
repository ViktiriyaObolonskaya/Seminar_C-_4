

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число:");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень:");
// int B = int.Parse(Console.ReadLine()!);
// Console.Write($"Число {A} в степини {B} -> {GetNum(A, B)}");


// //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число:");
// int C = int.Parse(Console.ReadLine()!);
// string M = C.ToString();
// Console.Write($"Колличество цифр в числе {M} -> {GetSum(M)}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 

// int[] myArray = GetArrey(8,0,10);
// Console.WriteLine($"[{String.Join(",", myArray)}]");



//------------методы----------------

int GetNum (int a, int b){
   int result = 1;
   for(int i = 1; i <= b; i++){
    result = result * a;
   } 
   return result;
}


int GetSum(string num){
    int a = num.Length;
    return a;
    int sum = 0; 
    for(int i = 0; i < a; i++){
        sum += Convert.ToInt32(Convert.ToString(num[i]));;
    }
    return sum;
}


int[] GetArrey(int size,int min, int max){
    int[] myArrey = new int[size];
    for (int i = 0; i < size; i++){
       myArrey[i] = new Random().Next(min, max); 
    }
    return myArrey;
}