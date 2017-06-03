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

        int number13 = 2;
        int number14 = 2;
        int number15 = 2;
        int number22 = 3;
        int number23 = 3;
        int number4 = 4;

        PictureBox[,] pole1 = new PictureBox[10, 10];
        int[,] StateCell = new int[10, 10];

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
            if (StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 1 || StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 13 || StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 14 || StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 15 || StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 22 || StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 23 || StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 4)
                ((PBInh)obj).Image = Properties.Resources.kill;
            else
            {
                ((PBInh)obj).Image = Properties.Resources.miss;
            }
            if (StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 1)
                Check1(((PBInh)obj).i, ((PBInh)obj).j);

            if (StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 22)
                Check22(((PBInh)obj).i, ((PBInh)obj).j);

            if (StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 23)
                Check23(((PBInh)obj).i, ((PBInh)obj).j);

            if (StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 13)
                Check13(((PBInh)obj).i, ((PBInh)obj).j);

            if (StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 14)
                Check14(((PBInh)obj).i, ((PBInh)obj).j);

            if (StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 15)
                Check15(((PBInh)obj).i, ((PBInh)obj).j);

            if (StateCell[((PBInh)obj).i, ((PBInh)obj).j] == 4)
                Check4(((PBInh)obj).i, ((PBInh)obj).j);

            

        }

        private void Check1(int i, int j)
        {
            if (StateCell[i, j] == 1)
            {
                for (int q = -1; q <= 1; q++)
                {
                    for (int p = -1; p <= 1; p++)
                    {
                        if (i + p >= 0 && i + p <= 9 && j + q >= 0 && j + q <= 9)
                        {
                            if (StateCell[i + p, j + q] != 1)
                                pole1[i + p, j + q].Image = Properties.Resources.miss;
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
                        if (StateCell[k, m] == 22)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCell[k + p, m + q] != 22)
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
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
                        if (StateCell[k, m] == 23)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCell[k + p, m + q] != 23)
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
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
                        if (StateCell[k, m] == 13)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCell[k + p, m + q] != 13)
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
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
                        if (StateCell[k, m] == 14)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCell[k + p, m + q] != 14)
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
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
                        if (StateCell[k, m] == 15)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCell[k + p, m + q] != 15)
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
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
                        if (StateCell[k, m] == 4)
                        {
                            for (int q = -1; q <= 1; q++)
                            {
                                for (int p = -1; p <= 1; p++)
                                {
                                    if (k + p >= 0 && k + p <= 9 && m + q >= 0 && m + q <= 9)
                                    {
                                        if (StateCell[k + p, m + q] != 4)
                                            pole1[k + p, m + q].Image = Properties.Resources.miss;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            
            int[,] arr = script.getStateCellPlayer();
            int[,] arr1 = script.getStateCellComputer();

            MouseEventHandler handler = new MouseEventHandler(fire);

            for (int i = 0; i < 10; i++)
            {
               
                for (int j = 0; j < 10; j++)
                {   
                    StateCell[i,j] = arr1[i,j];
                    PBInh pole = new PBInh();
                    pole.Location = new Point(90, 90);
                    pole.Size = new Size(35, 35);
                    pole.Location = new Point(pole.Location.X + 35 * i, pole.Location.Y + 35 * j);
                    if (arr[i, j] == 1 || arr[i, j] == 20 || arr[i, j] == 21 || arr[i, j] == 10 || arr[i, j] == 11 || arr[i, j] == 12 || arr[i, j] == 4)
                        pole.Image = Properties.Resources.ship;
                    else
                        pole.Image = Properties.Resources.pole;
                    pole.SizeMode = PictureBoxSizeMode.StretchImage;
                    pole1[i, j] = pole;
                    Controls.Add(pole1[i, j]);

                }
            }


            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    PBInh pole = new PBInh();
                    pole.Location = new Point(500, 90);
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
    }


    class PBInh : PictureBox
    {
        public int i;
        public int j;
      //  public int state;
    }


}
