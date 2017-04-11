using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle_v1._0.Model
{
    class FieldModel : SyntheticMind
    {
        

        int[,] StateCell = new int[10, 10];

        public void SetShip()
        {
            
            Random rand = new Random();

            SetShip4(rand);

            SetShip3(rand);
            SetShip3(rand);

            SetShip2(rand);
            SetShip2(rand);
            SetShip2(rand);

            SetShip1(rand);
            SetShip1(rand);
            SetShip1(rand);
            SetShip1(rand);

            Fire(StateCell);
            
            
                
            
        }

        

        private void SetShip4(Random rand)  //установка 4 палубного корабля
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

        private void SetShip3(Random rand)  // установка 3 палубного корабля
        {
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
                                StateCell[posX + i, posY] = 3;
                                for (int q = -1; q <= 1; q++)
                                {
                                    for (int p = -1; p <= 1; p++)
                                    {
                                        if (posX + i + p >= 0 && posX + i + p <= 9 && posY + q >= 0 && posY + q <= 9)
                                        {
                                            if (StateCell[posX + i + p, posY + q] != 3)
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
                                StateCell[posX, posY + i] = 3;
                                for (int q = -1; q <= 1; q++)
                                {
                                    for (int p = -1; p <= 1; p++)
                                    {
                                        if (posX + p >= 0 && posX + p <= 9 && posY + i + q >= 0 && posY + i + q <= 9)
                                        {
                                            if (StateCell[posX + p, posY + i + q] != 3)
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

        private void SetShip2(Random rand)  //установка 2 палубного корабля
        {
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
                                StateCell[posX + i, posY] = 2;
                                for (int q = -1; q <= 1; q++)
                                {
                                    for (int p = -1; p <= 1; p++)
                                    {
                                        if (posX + i + p >= 0 && posX + i + p <= 9 && posY + q >= 0 && posY + q <= 9)
                                        {
                                            if (StateCell[posX + i + p, posY + q] != 2)
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
                                StateCell[posX, posY + i] = 2;
                                for (int q = -1; q <= 1; q++)
                                {
                                    for (int p = -1; p <= 1; p++)
                                    {
                                        if (posX + p >= 0 && posX  + p <= 9 && posY + i + q >= 0 && posY + i + q <= 9)
                                        {
                                            if (StateCell[posX + p, posY + i + q] != 2)
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

        private void SetShip1(Random rand) // установка 1 палубного корабля
        {
            int posX, posY;
            int direction = rand.Next(2);
            bool b = false;

            switch (direction)
            {
                case 0:
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

                    break;

                case 1:
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
                    break;
            }
        }

    }
}