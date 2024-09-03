using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Rastgele sayı üretmek için Random nesnesi oluşturuyoruz.
        Random random = new Random();
         

        // rastgele 10 adetrakalmlı bir liste olulştaralıkm
        List<int> numbers = new List<int>();

        for (int i = 0; i < 0 ; i++) {

            numbers.Add(random.Next(-50, 51));
        }

        Console.WriteLine("Rastgele Sayılar: " + string.Join(", ", numbers));

        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Çift Sayılar: " + string.Join(", ", evenNumbers));

        // Tek olan sayılar
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Tek Sayılar: " + string.Join(", ", oddNumbers));

        // Negatif sayılar
        var negativeNumbers = numbers.Where(n => n < 0);
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negativeNumbers));

        // Pozitif sayılar (0'dan büyük sayılar)
        var positiveNumbers = numbers.Where(n => n > 0);
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", positiveNumbers));

        // 15'ten büyük ve 22'den küçük sayılar
        var betweenNumbers = numbers.Where(n => n > 15 && n < 22);
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar: " + string.Join(", ", betweenNumbers));

        // Listedeki her bir sayının karesi
        var squaredNumbers = numbers.Select(n => n * n);
        Console.WriteLine("Her Bir Sayının Karesi: " + string.Join(", ", squaredNumbers));
    }
}











    


