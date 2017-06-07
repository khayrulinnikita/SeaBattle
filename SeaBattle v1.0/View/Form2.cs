using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle_v1._0.View
{
    public partial class Form2 : Form
    {
        static FieldModel script = FieldModel.getInstance();

        bool[,] StateFire = new bool[10, 10];
        bool[,] StateFireComputer = new bool[10, 10];

        int number10 = 2;
        int number11 = 2;
        int number12 = 2;
        int number13 = 2;
        int number14 = 2;
        int number15 = 2;
        int number20 = 3;
        int number21 = 3;
        int number22 = 3;
        int number23 = 3;
        int number4 = 4;
        int number4Player = 4;

        Random rand = new Random();

        int RipComputer, RipPlayer;


        PictureBox[,] pole1 = new PictureBox[10, 10];
        PictureBox[,] polePlayer = new PictureBox[10, 10];
        int[,] StateCellComputer = new int[10, 10];
        int[,] StateCellPlayer = new int[10, 10];

        public Form2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        void fire(object obj, MouseEventArgs ant)
        {
            if (StateFire[((PBInh)obj).i, ((PBInh)obj).j] == false) 
            {
                StateFire[((PBInh)obj).i, ((PBInh)obj).j] = true;
                if (StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 1 || StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 13 || StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 14 || StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 15 || StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 22 || StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 23 || StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 4)
                {
                    ((PBInh)obj).Image = Properties.Resources.kill;
                    RipComputer += 1;

                    if (StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 1)
                        Check1(((PBInh)obj).i, ((PBInh)obj).j);

                    if (StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 22)
                        Check22(((PBInh)obj).i, ((PBInh)obj).j);

                    if (StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 23)
                        Check23(((PBInh)obj).i, ((PBInh)obj).j);

                    if (StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 13)
                        Check13(((PBInh)obj).i, ((PBInh)obj).j);

                    if (StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 14)
                        Check14(((PBInh)obj).i, ((PBInh)obj).j);

                    if (StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 15)
                        Check15(((PBInh)obj).i, ((PBInh)obj).j);

                    if (StateCellComputer[((PBInh)obj).i, ((PBInh)obj).j] == 4)
                        Check4(((PBInh)obj).i, ((PBInh)obj).j);

                    CheckWinPlayer(RipComputer);
                }
                    
                else
                {
                    ((PBInh)obj).Image = Properties.Resources.miss;
                    ComputerFire();
                }
                
            }
        }

        private void Check1(int i, int j)
        { 
            for (int q = -1; q <= 1; q++)
            {
                for (int p = -1; p <= 1; p++)
                {
                    if (i + p >= 0 && i + p <= 9 && j + q >= 0 && j + q <= 9)
                    {
                        if (StateCellComputer[i + p, j + q] != 1)
                        {
                            pole1[i + p, j + q].Image = Properties.Resources.miss;
                            StateFire[i + p, j + q] = true;
                        }
                    }
                }
            }
        }

        private void Check1Player(int i, int j)
        {
            for (int q = -1; q <= 1; q++)
            {
                for (int p = -1; p <= 1; p++)
                {
                    if (i + p >= 0 && i + p <= 9 && j + q >= 0 && j + q <= 9)
                    {
                        if (StateCellPlayer[i + p, j + q] != 1)
                        {
                            polePlayer[i + p, j + q].Image = Properties.Resources.miss;
                            StateFireComputer[i + p, j + q] = true;
                        }
                    }
                }
            }
        }

        private void Check20(int i, int j)
        {
            number20 -= 1;
            if (number20 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellPlayer[k, m] == 20)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellPlayer[k + p, m + q] != 20)
                                        {
                                            polePlayer[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFireComputer[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check21(int i, int j)
        {
            number21 -= 1;
            if (number21 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellPlayer[k, m] == 21)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellPlayer[k + p, m + q] != 21)
                                        {
                                            polePlayer[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFireComputer[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check22(int i, int j)
        {
            number22 -= 1;
            if (number22 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellComputer[k, m] == 22)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellComputer[k + p, m + q] != 22)
                                        {
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFire[k + p, m + q] = true;
                                        } 
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check23(int i, int j)
        {
            number23 -= 1;
            if (number23 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellComputer[k, m] == 23)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellComputer[k + p, m + q] != 23)
                                        {
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFire[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check10(int i, int j)
        {
            number10 -= 1;
            if (number10 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellPlayer[k, m] == 10)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellPlayer[k + p, m + q] != 10)
                                        {
                                            polePlayer[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFireComputer[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check11(int i, int j)
        {
            number11 -= 1;
            if (number11 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellPlayer[k, m] == 11)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellPlayer[k + p, m + q] != 11)
                                        {
                                            polePlayer[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFireComputer[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check12(int i, int j)
        {
            number12 -= 1;
            if (number12 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellPlayer[k, m] == 12)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellPlayer[k + p, m + q] != 12)
                                        {
                                            polePlayer[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFireComputer[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check13(int i, int j)
        {
            number13 -= 1;
            if (number13 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellComputer[k, m] == 13)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellComputer[k + p, m + q] != 13)
                                        {
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFire[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check14(int i, int j)
        {
            number14 -= 1;
            if (number14 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellComputer[k, m] == 14)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellComputer[k + p, m + q] != 14)
                                        {
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFire[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check15(int i, int j)
        {
            number15 -= 1;
            if (number15 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellComputer[k, m] == 15)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellComputer[k + p, m + q] != 15)
                                        {
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFire[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check4(int i, int j)
        {
            number4-=1;
            if (number4 == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellComputer[k, m] == 4)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellComputer[k + p, m + q] != 4)
                                        {
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFire[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Check4Player(int i, int j)
        {
            number4Player -= 1;
            if (number4Player == 0)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        if (StateCellPlayer[k, m] == 4)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCellPlayer[k + p, m + q] != 4)
                                        {
                                            polePlayer[k + p, m + q].Image = Properties.Resources.miss;
                                            StateFireComputer[k + p, m + q] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void CheckWinComputer(int k)
        {
            if (k == 20)
            {
                this.Close();
                ComputerWin form = new ComputerWin();
                form.ShowDialog();
            }
        }

        private void CheckWinPlayer(int k)
        {
            if (k == 20)
            {
                this.Close();
                PlayerWin form = new PlayerWin();
                form.ShowDialog();
            }
        }

        private void ComputerFire()
        {
            
            int i = rand.Next(10);
            int j = rand.Next(10);
            if (StateFireComputer[i, j] == false)
            {
                StateFireComputer[i, j] = true;
                if (StateCellPlayer[i, j] == 1 || StateCellPlayer[i, j] == 20 || StateCellPlayer[i, j] == 21 || StateCellPlayer[i, j] == 10 || StateCellPlayer[i, j] == 11 || StateCellPlayer[i, j] == 12 || StateCellPlayer[i, j] == 4)
                {
                    polePlayer[i, j].Image = Properties.Resources.kill;
                    RipPlayer += 1;
                    CheckWinComputer(RipPlayer);
                    ComputerFire();
                }
                else
                    polePlayer[i, j].Image = Properties.Resources.miss;
                if (StateCellPlayer[i, j] == 1)
                    Check1Player(i, j);

                if (StateCellPlayer[i, j] == 20)
                    Check20(i, j);

                if (StateCellPlayer[i, j] == 21)
                    Check21(i, j);

                if (StateCellPlayer[i, j] == 10)
                    Check10(i, j);

                if (StateCellPlayer[i, j] == 11)
                    Check11(i, j);

                if (StateCellPlayer[i, j] == 12)
                    Check12(i, j);

                if (StateCellPlayer[i, j] == 4)
                    Check4Player(i, j);
            }
            else
            {
                ComputerFire();
            }
            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {

            RipPlayer = 0;
            RipComputer = 0;

            int[,] arr = script.getStateCellPlayer();
            int[,] arr1 = script.getStateCellComputer();

            MouseEventHandler handler = new MouseEventHandler(fire);

            for (int i = 0; i < 10; i++)
            {
               
                for (int j = 0; j < 10; j++)
                {   
                    StateCellComputer[i,j] = arr1[i,j];
                    StateCellPlayer[i, j] = arr[i, j];
                    PBInh pole = new PBInh();
                    pole.Location = new Point(90, 90);
                    pole.Size = new Size(35, 35);
                    pole.Location = new Point(pole.Location.X + 35 * i, pole.Location.Y + 35 * j);
                    if (arr[i, j] == 1 || arr[i, j] == 20 || arr[i, j] == 21 || arr[i, j] == 10 || arr[i, j] == 11 || arr[i, j] == 12 || arr[i, j] == 4)
                        pole.Image = Properties.Resources.ship;
                    else
                        pole.Image = Properties.Resources.pole;
                    pole.SizeMode = PictureBoxSizeMode.StretchImage;
                    polePlayer[i, j] = pole;
                    Controls.Add(polePlayer[i, j]);

                }
            }


            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    PBInh pole = new PBInh();
                    pole.Location = new Point(550, 90);
                    pole.Size = new Size(35, 35);
                    pole.Location = new Point(pole.Location.X + 35 * i, pole.Location.Y + 35 * j);
                    pole.Image = Properties.Resources.pole;
                    pole.SizeMode = PictureBoxSizeMode.StretchImage;
                    pole1[i, j] = pole;
                    Controls.Add(pole1[i, j]);

                    pole.i = i;
                    pole.j = j;
                    pole.MouseClick += handler;
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FieldModel field = FieldModel.getInstance();
            field.SetShip();
            Form2 Form2 = new Form2();
            Form2.WindowState = FormWindowState.Maximized;
            Form2.Show();
        }
    }


    class PBInh : PictureBox
    {
        public int i;
        public int j;
    }


}
