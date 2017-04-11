using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle_v1._0.Model
{
    class SyntheticMind
    {
        public void Fire(int[,] StateCell)
        {


            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(StateCell[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
