using System;
using System.Collections.Generic;

namespace colorScaleGen
{
    internal class Program
    {
        const int Resolution = 12;
        private const int Steps = 12;

        private static int GetValue(int x, int y, Scale scale)
        {

            return y < Resolution / Steps * 1 ? CalculateStep(x, y, 1, scale) :
                y < Resolution / Steps * 2 ? 200+x :
                y < Resolution / Steps * 3 ? 300+x :
                y < Resolution / Steps * 4 ? 400+x :
                y < Resolution / Steps * 5 ? 500+x :
                y < Resolution / Steps * 6 ? 600+x :
                y < Resolution / Steps * 7 ? 700+x : 800+x;
        }

        private static int CalculateStep(int x, int y, int step, Scale scale)
        {

            foreach (var note in scale.Notes)
            {
                
            }
            
            
            throw new NotImplementedException();
        }


        //run program
        public static void Main(string[] args)
        {
            foreach (var value in GenerateScale(Scales.major))
            {
                Console.WriteLine(value);
            }
            
            int[] GenerateScale(Scale scale)
            {
                var data = new int[Resolution*Resolution];
                
                for (var y = 0; y < Resolution; y++)
                {
                    for (var x = 0; x < Resolution; x++)
                    {
                        data[(y*Resolution)+x] = GetValue(x, y, scale);
                    }
                }
                return data;
            }
        }
    }
}