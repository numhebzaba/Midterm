using System;

namespace Midterm_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();

            bool loopfilmBackWidth = true;
            while (loopfilmBackWidth)
            {
                float filmBackWidth = float.Parse(Console.ReadLine());
                if (filmBackWidth > 0)
                {
                    double fLength, fov; //ถ้าใช้ floats จะใช้ method ไม่ได้
                    loopfilmBackWidth = false;

                    if (mode == "fLength") 
                    {
                        bool loopfLength = true;
                        while (loopfLength)
                        {
                            fLength = float.Parse(Console.ReadLine());
                            if (fLength > 0)
                            {
                                fov = 2 * Math.Atan(filmBackWidth / (2 * fLength));
                                loopfLength = false;
                                Console.WriteLine("fLegnth = ", fLength, ",fove=", fov);
                            }
                            else
                            {
                                Console.WriteLine("Invalid fLengnth. Please input again.");
                            }
                        }
                    }
                    else if (mode == "fov")
                    {
                        bool loopfov = true;
                        while (loopfov)
                        {
                            fov = float.Parse(Console.ReadLine());
                            if (fov > 0.1 && fov < 6.28)
                            {
                                fLength = filmBackWidth / (2 * Math.Tan(fov / 2));
                                loopfov = false;
                                Console.WriteLine("fLegnth = ",fLength,",fove=",fov);
                            }
                            else
                            {
                                Console.WriteLine("Invalid fov. Please input again.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid filmBackWidth Please input again");
                }
            }
        }
    }
}
