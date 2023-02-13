
namespace Task
{
    internal class FindDelPrint
    {
        // формируем массив из строк, длина которых меньше либо равна 3 символам
        internal static string[] Find(string[] startArr)
        {
            string[] endArr = new string[startArr.GetLength(0)];

            int j = 0;
            for (int i = 0; i < startArr.GetLength(0); i++)
            {

                if (startArr[i].Length < 4)
                {
                    foreach (var item in startArr[i])
                    {
                        endArr[j] += Convert.ToString(item);
                    }
                    j++;
                }

            }
            return endArr;
        }

        // удаляем из массива пустые строки + печать
        internal static void DelEmpty(string[] arr)
        {
            string[] words = { "String.Empty" };
            string[] massiv = arr;
            massiv = massiv.Except(words).ToArray();

            Console.Write("[");
            int count = massiv.Length;
            int index = 0;
            while (index < count)
            {
                Console.Write(massiv[index]);
                index++;
                if (index < count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }

        // печать массива
        internal static void Print(string[] arr)
        {
            Console.Write("[");
            int count = arr.Length;
            int index = 0;
            while (index < count)
            {
                Console.Write(arr[index]);
                index++;
                if (index < count)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }
    }
}