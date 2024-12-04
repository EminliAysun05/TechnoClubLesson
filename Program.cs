namespace LessonTechoClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //continue
            //for (int i = 1; i <= 5; i++)//1245
            //{
            //    if (i == 3)
            //    {
            //       // Console.WriteLine("3 rəqəmi keçilir.");
            //        continue; // 3-ü atla, növbəti iterasiyaya davam et.
            //    }

            //    Console.WriteLine($"Cari reqem: {i}");
            //}
            //break
            //while (true)
            //{
            //    Console.Write("Davam etmək üçün bir rəqəm daxil edin ('0' daxil etsəniz dayandırılacaq): ");
            //    int input = int.Parse(Console.ReadLine());

            //    if (input == 0)
            //    {
            //        Console.WriteLine("Dövrədən çıxıldı!");
            //        break; // Dövrə tamamilə dayandırılır.
            //    }

            //    Console.WriteLine($"Daxil etdiyiniz rəqəm: {input}");
            //}

            //STRING METHODLARI

            ////1. Stringin uzunluğunu (simvol sayını) qaytarır.
            //string text = "Hello, World!";
            //Console.WriteLine($"Uzunluq: {text.Length}"); // Çıxış: Uzunluq: 13

            ////2. ToUpper və ToLower
            //// Mətnin bütün hərflərini böyük və ya kiçik edir.

            //string text1 = "Hello, World!";
            //Console.WriteLine(text.ToUpper()); // Çıxış: HELLO, WORLD!
            //Console.WriteLine(text.ToLower()); // Çıxış: hello, world!

            ////3. Trim, TrimStart, TrimEnd
            ////Boşluqları və ya göstərilən simvolları silir.
            ////Trim: Mətnin əvvəlindən və sonundan boşluqları silir.
            ////TrimStart: Yalnız əvvəlindən silir.
            ////TrimEnd: Yalnız sonundan silir.
            //string text2 = "/  Hello, World!   /";
            //Console.WriteLine(text2);
            //Console.WriteLine(text.Trim());       // Çıxış: "Hello, World!"
            //Console.WriteLine(text.TrimStart());  // Çıxış: "Hello, World!   "
            //Console.WriteLine(text.TrimEnd());    // Çıxış: "   Hello, World!"

            ////4. Substring
            //// Mətnin müəyyən bir hissəsini qaytarır.
            //string text3 = "Hello, World!";
            //Console.WriteLine(text.Substring(7));    // Çıxış: "World!"
            //Console.WriteLine(text.Substring(0, 5)); // Çıxış: "Hello"

            ////5. Contains
            ////Mətnin müəyyən bir hissəsini saxlayıb - saxlamadığını yoxlayır.
            //string text4 = "Hello, World!";
            //Console.WriteLine(text.Contains("World"));  // Çıxış: True
            //Console.WriteLine(text.Contains("Universe")); // Çıxış: False

            ////6. Replace
            //// Mətnin bir hissəsini başqa bir hissə ilə əvəz edir.
            //string text5 = "Hello, World!";
            //Console.WriteLine(text.Replace("World", "Universe")); // Çıxış: "Hello, Universe!"


            ////7. Split
            ////Mətnin hissələrə bölünməsi üçün istifadə olunur və nəticəni massiv şəklində qaytarır.
            //string text6 = "apple,banana,cherry";
            //string[] fruits = text6.Split(",");
            //foreach (var fruit in fruits)
            //    Console.WriteLine(fruit);
            
            //// Console.WriteLine($"{text6}-{fruits}");
            //// Çıxış:
            //// apple
            //// banana
            //// cherry
            //string authors = "Mahesh Chand, Henry He, Chris Love, Raj Beniwal, Praveen Kumar";
            //// Split authors separated by a comma followed by space
            //string[] authorsList = authors.Split(", ");
            //foreach (string author in authorsList)
            //    Console.WriteLine(author);


            ////8. StartsWith və EndsWith
            //// Mətnin müəyyən bir simvolla başlayıb - başlamadığını və ya bitib - bitmədiyini yoxlayır.
            //string text7 = "Hello, World!";
            //Console.WriteLine(text.StartsWith("Hello,")); // Çıxış: True
            //Console.WriteLine(text.EndsWith("ld!"));       // Çıxış: True


            ////9. Concat
            ////Bir neçə stringi birləşdirir.
            //string part1 = "Hello";
            //string part2 = "World";
            //string result = string.Concat(part1, ", ", part2, "!");
            //Console.WriteLine(result); // Çıxış: "Hello, World!"
            //Console.WriteLine(part1 + " " + part2);



            //usd - 1.71
            //eur - 1.84
            ////arrays
            //string[] CurrencyCodes = { "USD", "EUR", "AUD", "ARS", "BYN", "BRL", "AED" };
            //decimal[] CurrencyRates = { 1.7000M, 1.8455M, 1.1325M, 0.0019M, 0.5195M, 0.3314M, 0.4628M };

            //Console.WriteLine("Show recent currency rates are: ");
            //int i = 0;
            //while (i < CurrencyCodes.Length)
            //{
            //    Console.WriteLine($"{CurrencyCodes[i]}: {CurrencyRates[i]}");
            //    i++;
            //}

            string brandName;
            
            while (true)
            {
                Console.WriteLine("Brand's name: ");
                brandName = Console.ReadLine();
                if (brandName.Length >= 3 && brandName.Length <= 15)
                    break;
                else
                    Console.WriteLine("Size dugun daxil edilmeyib");

            }
        }
    }
}
