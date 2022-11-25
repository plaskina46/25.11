/*var dateString = "25-11-2022";

var date = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
Console.WriteLine(date);*/
class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Сейчас будем вводить....");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(x+10);
        Console.ReadLine();
        */
        /*string s = Console.ReadLine();
          if (int.TryParse(s, out int i))
              Console.WriteLine("Число, увеличенное на 5: {0}", i + 5);
          else
              Console.WriteLine("Введенная строка не являлась числом.");*/

        {
            /*onsole.WriteLine("Введите число: ");
             int n = Convert.ToInt32(Console.ReadLine());

             int result;
             if (n > 123)
                 result = (n - 123) * 3;
             else
                 result = 123 - n;
             Console.WriteLine(result);*/



        }
        /*
        int[] a = new int[5] { 4, 5, 5, 2, 6 };
        int[] b = new int[5] { 7, 3, 7, -1, 2 };
        Array.Sort(a); //По возрастанию
        foreach (int i in a)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();

        Array.Sort(b, SortDescending); //По убыванию
        foreach (int i in b)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        int[] c = ConcatArrays(a, b); //объединили массивы
        foreach (int i in c)
        {
            Console.Write($"{i} ");
        }
    }

    static int SortDescending(int x, int y)
    {
        if (x < y)

            return 1;

        if (x == y)

            return 0;

        return -1;
    }

    static int[] ConcatArrays(int[] a, int[] b)
    {
        int[] c = new int[a.Length + b.Length]; //длина нового массива равна сумме длин исходных массивов
        for (int i = 0; i < a.Length; i++) //переносим числа из массива A в массив C
            c[i] = a[i];
        for (int i = a.Length; i < a.Length + b.Length; i++) //переносим числа из массива B в массив C, начиная с индекса a.Length
            c[i] = b[i - a.Length]; //не забываем, что у массива B индекс очередного элемента на a.Length меньше, чем у C!
        return c;*/
    }
}


          
    

