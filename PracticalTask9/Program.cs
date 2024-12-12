using System;
using System.IO;
using System.Text;


class Program 
{

    static void ReadFileFileStream() {
        FileStream fileIn = new FileStream("D:/c-harp/PracticalTask9/text.txt", FileMode.Open, FileAccess.Read); 

        FileStream fileOut = new FileStream("D:/c-harp/PracticalTask9/newText.txt", FileMode.Create, FileAccess.Write);
    
        int i;

        while ((i = fileIn.ReadByte()) != -1)
        {
            fileOut.WriteByte((byte)i);
        }

        fileIn.Close();
        fileOut.Close();

    }

    static void CreateNewFileWithFileStreamWithUsing(){
        using (FileStream fileIn = new FileStream("D:/c-harp/PracticalTask9/text.txt", FileMode.Open, FileAccess.Read))
        {
            using (FileStream fileOut = new FileStream("D:/c-harp/PracticalTask9/newText.txt", FileMode.Create, FileAccess.Write))
            {
                int i;

                while ((i = fileIn.ReadByte()) != -1)
                {
                    fileOut.WriteByte((byte)i);
                }

            }
        }
    }

    static void CreateWithStreamReader() {
         using(StreamReader fileIn = new StreamReader("D:/c-harp/PracticalTask9/text.txt", Encoding.GetEncoding("utf-8")))
        {
            using (StreamWriter fileOut =  new StreamWriter("D:/c-harp/PracticalTask9/newText.txt", false)){
                string line;

                while((line = fileIn.ReadLine()) != null) {
                    fileOut.WriteLine(line);
                }
            }
        }
    }


    static void Task1(){
        Console.Write("Введите искомый символ: ");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int count = 0;

        using( FileStream fileIn = new FileStream("D:/c-harp/PracticalTask9/text.txt", FileMode.Open, FileAccess.Read)){
            int i;
            while ((i = fileIn.ReadByte()) != -1) {
                if (i == letter) {
                    count++;
                }
            }
        }
        Console.WriteLine("буква '{0}' встречается {1}", letter, count);
    }

    static void Task2() {
        //7

        Console.Write("Введите искомый символ: ");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine();

        using(StreamReader fileIn = new StreamReader("D:/c-harp/PracticalTask9/text.txt", Encoding.GetEncoding("utf-8")))
        {
            string line;
            while((line = fileIn.ReadLine()) != null) {
               if (line[0] == letter){
                Console.WriteLine(line);
               }    
            }
        }
    }

    static void Task3() {
        //1

        using (FileStream fileIn = new FileStream("D:/c-harp/PracticalTask9/f.txt", FileMode.Open, FileAccess.Read))
        {
            using (BinaryReader reader = new BinaryReader(fileIn)){
            using (FileStream fileG = new FileStream("D:/c-harp/PracticalTask9/g.txt", FileMode.Create, FileAccess.Write))
            using (FileStream fileH = new FileStream("D:/c-harp/PracticalTask9/h.txt", FileMode.Create, FileAccess.Write) )
                {
                    using (BinaryWriter writeG = new BinaryWriter(fileG))
                    using (BinaryWriter writeH = new BinaryWriter(fileH))
                    {
                        int i;

                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            int number = reader.ReadInt32();
                            if (number % 2 == 0) {
                                writeG.Write(number);
                            } else
                            {
                                writeH.Write(number);
                            }
                        }
                    }
                  
                }
            }
        }
    }

    static void Main ()
    {
    //    Task1();
    // Task2();
    Task3();
    }
}