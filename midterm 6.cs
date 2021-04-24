using System;

namespace midterm_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            int widthOfstair = int.Parse(Console.ReadLine());
            int heightOfstair = int.Parse(Console.ReadLine());
            int stepOfstair = int.Parse(Console.ReadLine());

            for(int i = 1; i<= heightOfstair*stepOfstair; i++)
            {
                for(int j = 1; j <= widthOfstair; j++)
                {
                    for(int k =1; k <= stepOfstair; k++)
                    {
                        if (j == i)
                        {
                            Console.Write(letter);
                        }
                    }
                    
                }
                Console.WriteLine("");
            }
            //ยอมแพ้ทำไม่ทัน
        }
    }
}
