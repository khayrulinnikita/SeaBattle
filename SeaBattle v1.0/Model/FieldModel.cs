using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaBattle_v1._0.Model;
using SeaBattle_v1._0.View;

namespace SeaBattle_v1._0.View
{
    public class FieldModel 
    {


        static int[,] StateCellPlayer = new int[10, 10];
        static int[,] StateCellComputer = new int[10, 10];

        public int[,] getStateCellPlayer()
        {
            return StateCellPlayer;
        }

        public int[,] getStateCellComputer()
        {
            return StateCellComputer;
        }


        public void SetShip()
        {
            
            Random rand = new Random();

            SetShip4(rand, StateCellPlayer);

            SetShip3(rand, StateCellPlayer);
            SetShip3(rand, StateCellPlayer);

            SetShip2(rand, StateCellPlayer);
            SetShip2(rand, StateCellPlayer);
            SetShip2(rand, StateCellPlayer);

            SetShip1(rand, StateCellPlayer);
            SetShip1(rand, StateCellPlayer);
            SetShip1(rand, StateCellPlayer);
            SetShip1(rand, StateCellPlayer);



            SetShip4(rand, StateCellComputer);

            SetShip3(rand, StateCellComputer);
            SetShip3(rand, StateCellComputer);

            SetShip2(rand, StateCellComputer);
            SetShip2(rand, StateCellComputer);
            SetShip2(rand, StateCellComputer);

            SetShip1(rand, StateCellComputer);
            SetShip1(rand, StateCellComputer);
            SetShip1(rand, StateCellComputer);
            SetShip1(rand, StateCellComputer);
        }


        private void SetShip4(Random rand, int[,] StateCell)  //установка 4 палубного корабля
        {
            int posX, posY;
            int direction = rand.Next(2);

            
            switch (direction)
            {
                case 0:
                    posX = rand.Next(7);
                    posY = rand.Next(10);
                    
                        for (int i = 0; i < 4; i++)
                        {
                            StateCell[posX + i, posY] = 4;
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (posX + i + p >= 0 && posX + i + p <= 9 && posY + q >= 0 && posY + q <= 9)
                                    {
                                        if (StateCell[posX + i + p, posY + q] != 4)
                                            StateCell[posX + i + p, posY + q] = 9;
                                    }
                                }
                            }
                        }
                    
                    break;

                case 1:
                    posX = rand.Next(10);
                    posY = rand.Next(7);
                    
                        for (int i = 0; i < 4; i++)
                        {
                            StateCell[posX, posY + i] = 4;
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (posX + p >= 0 && posX + p <= 9 && posY + i + q >= 0 && posY + i + q <= 9)
                                    {
                                        if (StateCell[posX + p, posY + i + q] != 4)
                                            StateCell[posX + p, posY + i + q] = 9;
                                    }
                                }
                            }
                        }
                    
                    break;
            }
        }


        int k = 19;
        private void SetShip3(Random rand, int[,] StateCell)  // установка 3 палубного корабля
        {
            k += 1;
            int posX, posY;
            int direction = rand.Next(2);
            bool b = false;

            switch (direction)
            {
                case 0:
                    while (b == false)
                    {
                        posX = rand.Next(8);
                        posY = rand.Next(10);
                        if (StateCell[posX, posY] ==0 && StateCell[posX + 1, posY] == 0 && StateCell[posX + 2, posY] == 0)
                            b = true;

                        if (b == true)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                StateCell[posX + i, posY] = k;
                                for (int q = -1; q <= 1; q++)
                                {
                                    for (int p = -1; p <= 1; p++)
                                    {
                                        if (posX + i + p >= 0 && posX + i + p <= 9 && posY + q >= 0 && posY + q <= 9)
                                        {
                                            if (StateCell[posX + i + p, posY + q] != k)
                                                StateCell[posX + i + p, posY + q] = 9;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    break;

                case 1:
                    while (b == false)
                    {
                        posX = rand.Next(10);
                        posY = rand.Next(8);
                        if (StateCell[posX, posY] == 0 && StateCell[posX, posY + 1] == 0 && StateCell[posX, posY + 2] == 0)
                            b = true;

                        if (b == true)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                StateCell[posX, posY + i] = k;
                                for (int q = -1; q <= 1; q++)
                                {
                                    for (int p = -1; p <= 1; p++)
                                    {
                                        if (posX + p >= 0 && posX + p <= 9 && posY + i + q >= 0 && posY + i + q <= 9)
                                        {
                                            if (StateCell[posX + p, posY + i + q] != k)
                                                StateCell[posX + p, posY + i + q] = 9;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
        }


        int s = 9;
        private void SetShip2(Random rand, int[,] StateCell)  //установка 2 палубного корабля
        {
            s += 1;
            int posX, posY;
            int direction = rand.Next(2);
            bool b = false;

            switch (direction)
            {
                case 0:
                    while (b == false)
                    {
                        posX = rand.Next(9);
                        posY = rand.Next(10);
                        if (StateCell[posX, posY] == 0 && StateCell[posX + 1, posY] == 0)
                            b = true;
                        
                        if (b == true)
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                StateCell[posX + i, posY] = s;
                                for (int q = -1; q <= 1; q++)
                                {
                                    for (int p = -1; p <= 1; p++)
                                    {
                                        if (posX + i + p >= 0 && posX + i + p <= 9 && posY + q >= 0 && posY + q <= 9)
                                        {
                                            if (StateCell[posX + i + p, posY + q] != s)
                                                StateCell[posX + i + p, posY + q] = 9;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    break;

                case 1:
                    while (b == false)
                    {
                        posX = rand.Next(10);
                        posY = rand.Next(9);
                        if (StateCell[posX, posY] == 0 && StateCell[posX, posY + 1] == 0)
                            b = true;

                        if (b == true)
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                StateCell[posX, posY + i] = s;
                                for (int q = -1; q <= 1; q++)
                                {
                                    for (int p = -1; p <= 1; p++)
                                    {
                                        if (posX + p >= 0 && posX  + p <= 9 && posY + i + q >= 0 && posY + i + q <= 9)
                                        {
                                            if (StateCell[posX + p, posY + i + q] != s)
                                                StateCell[posX + p, posY + i + q] = 9;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void SetShip1(Random rand, int[,] StateCell) // установка 1 палубного корабля
        {
            int posX, posY;
            bool b = false;

            while (b == false)
            {
                posX = rand.Next(10);
                posY = rand.Next(10);
                if (StateCell[posX, posY] == 0)
                    b = true;

                if (b == true)
                {
                    StateCell[posX, posY] = 1;
                    for (int q = -1; q <= 1; q++)
                    {
                        for (int p = -1; p <= 1; p++)
                        {
                            if (posX + p >= 0 && posX + p <= 9 && posY + q >= 0 && posY + q <= 9)
                            {
                                if (StateCell[posX + p, posY + q] != 1)
                                    StateCell[posX + p, posY + q] = 9;
                            }
                        }
                    }
                }
            }
        }
    }
}