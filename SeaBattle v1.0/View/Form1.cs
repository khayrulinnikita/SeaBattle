using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeaBattle_v1._0.Model;
using SeaBattle_v1._0.View;

namespace SeaBattle_v1._0
{
    public partial class Form1 : Form
    {
       
            
        
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FieldModel field = FieldModel.getInstance();
            field.SetShip();
            Form2 Form2 = new Form2();
            Form2.WindowState = FormWindowState.Maximized;
            Form2.Show();

        }
    }
}
