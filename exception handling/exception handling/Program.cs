using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int[] ar = { 4, 2, 8, 4, 2, 6 };
				int[] br = { 2, 2, 4, 0, 2 };
				for (int i = 0; i < ar.Length; i++)
				{
					try
					{
						Console.WriteLine("{0}", ar[i] / br[i]);
					}
					catch (DivideByZeroException a)
					{
						Console.WriteLine("Деление на ноль !!!");
					}
					//неправильный индекс
					catch (IndexOutOfRangeException b)
					{
						Console.WriteLine("Выход за пределы");
					}
				}
				ar[50] = 67;
			}
			// аналог catch(...)
			catch
			{
				Console.WriteLine("Неизвестная Ошибка");
			}
			Console.Read();

		}
	}
}
    

