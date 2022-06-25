// seminar 2
//Напишите программу, которая выводит слуучайное число из отрезка [10,99] 
//и показывает наибольшее

// void ShowNumber(){
//  int num = new Random().Next(10, 100);
//  int firstNum = num / 10;
//  int secondNum = num % 10;
//  Console.Write(num + " -> ");
//  if (firstNum > secondNum){
//      Console.WriteLine (firstNum);
//  }
//  else{
//      Console.WriteLine (secondNum);
//  }
// }
// ShowNumber ();

// Напишите программу, которая выводит слуучайное трехзначное число,
// и удаляет вторую цифру

//  int NumWS(int Number){
 
//     int NewNumber = 0;
//     NewNumber = Number / 100 * 10 + Number % 10;
//     return NewNumber;
//  }
// int Number = new Random().Next(100, 1000);
// int a = NumWS(Number);
// Console.WriteLine(a + " " + Number);

 //Задача решена !


// string Method4(int count, string text)
// {

// string result + String.Empty;
// For (int i = 0; i < count; i ++)

// { 
//     result = result + text;
// }
//  return result;
// }
// string res = Method4(10,"z")ж
// Console.WritLine(res);


//  таблица умножения

// for (int i = 2; i <= 10; i++)
// {
//    for (int j = 2; j <= 10; j++)
// {
//     Console.WriteLine($"{i} * {j} = {i * j}");
// }
//      Console.WriteLine();
     
// }

// string text = "- Я думаю, - сказал князь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгнроде,"
//             + "Вы так красноречивы. Вы дадите мне чаю?" ;

// string Replace(string text, char oldValue, char newValue)

// {
//  string result = String.Empty; 

// int length = text.length;

// for (int i = 0; i < length; i++) 

// {
//     if(text[i] == oldValue) result = result + $"{"newValue}";
//     else result = result + $"{"text[i]}";


// return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
//  }



 //НАПИСАТЬ ПРОГРАММУ , КОТОРАЯ БУДЕТ ПРИНИМАТЬ
 // НА ВХОД 2 ЧИСЛА И ВЫВОДИТЬ ЯВЛЯЕТСЯ ЛИ ВТОРОЕ ЧИСЛО 
 //КРАТНОЕ ПЕРВОМУ

// void MultiNum (int a, int b){
//     if (b%a == 0){
//         Console.WriteLine(b + "кратно" + a );
//     } else {
//         Console.WriteLine(b + " не кратно " + a + ", остаток " +b%a);
//     }
// }
// Console.WriteLine("Введите последовательно два числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// MultiNum (num1, num2);


// задача решена !


// которая ПРИНИМАЕТ НА ВХОД ЧИСЛО
//  И ПРОВЕРЯЕТ КРАТНО ЛИ ОНО 

// void NumDiv(int a){
//     if (a%7 == 0 && a%23 ==0){
// Console.WriteLine(a + " кратно 23 и 7 ");
//     }else{
//     Console.WriteLine(a + "  не кратно 23 и 7 ");
//     }
        
//     }
//   Console.WriteLine(" Введите число :" );

// NumDiv(Convert.ToInt32(Console.ReadLine()));

// задача решена !!!


//Домашнее задание 2 

// Задача 10: Напишите программу, которая принимает на ввод трехзначное число,
// и и на выходе показывает  вторую цифру этого числа (456 => 5)

//  int NumWS(int Number){
 
//     int NewNumber = 0;
//     NewNumber = Number / 10 % 10 ;
//     return NewNumber;
//  }
// int Number = new Random().Next(100, 1000);
// int a = NumWS(Number);
// Console.WriteLine(Number + " => " + a);

 //Задача решена !


//  Задача 13: НАПИШИТЕ ПРОГРАММУ КОТОРАЯ ВВОДИТ 
//  ТРЕТЬЮ ЦИФРУ ЗАДАННОГО ЧИСЛА ИЛИ СООБЩАЕТ, 
//  ЧТО ТРЕТЬЕЙ ЦИФРЫ НЕТ 
//  (32679 => 6 ; 
//  78 => ТРЕТЬЕЙ ЦИФЫРЫ НЕТ;
//   645 => 5)


//  Console.WriteLine("Введите число");
//  int nums= Convert.ToInt32(Console.ReadLine());
//   string numsText = Convert.ToString(nums);
//  if (numsText.Length  > 2)
//  {
//   Console.WriteLine("Третья цифра " + numsText[2]);
//   } 
//   else {

//   Console.WriteLine(nums + " => третьей цифры нет " );
//   }
 
//   Задача 3 решена !!!


// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//     Console.WriteLine("Введите число дня недели");
//     int DayW= Convert.ToInt32(Console.ReadLine());
//     if (DayW ==6 || DayW ==7){
//    Console.WriteLine( DayW +  "  => да " );
//     }
//    else  
//    Console.WriteLine(DayW + " => нет " );

//    решена Задача !!!