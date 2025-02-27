namespace ClassLibrary
{
    public class Helper
    {
        static public long Add(long val1, long val2)
        {
            return val1 + val2;
        }
        static public int[] Init(int[] array = null)
        {
            Random random = new Random();
            int arraySize = array?.Length > 0 ? array.Length : random.Next(10, 50);
            if (array == null || array.Length == 0)
            {
                array = new int[arraySize];
            }
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(1, 51);
            }
            return array;
        }
        static public void Print(int[] array)
        {
            if (array == null || array.Length == 0){
                throw new ArgumentException("Массив не может быть null или пустым.");
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static public int Min(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Массив не может быть null или пустым.");
            }
            return array.Min();
        }

        static public int[] Sort(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Массив не может быть null или пустым.");
            }
            Array.Sort(array);
            return array;
        }
    }
}

