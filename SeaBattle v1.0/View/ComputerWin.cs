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
    public partial class ComputerWin : Form
    {
        public ComputerWin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FieldModel field = FieldModel.getInstance();
            field.SetShip();
            Form2 Form2 = new Form2();
            Form2.WindowState = FormWindowState.Maximized;
            Form2.Show();
        }

        private void ComputerWin_Load(object sender, EventArgs e)
        {

        }
    }
}
