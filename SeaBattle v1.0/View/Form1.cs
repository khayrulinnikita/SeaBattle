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

namespace SeaBattle_v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            FieldModel field = new FieldModel();
            field.SetShip();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
