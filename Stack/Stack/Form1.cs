using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Stack : Form
    {
        public Stack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 2;
            if(x == 2 )
            {
                MessageBox.Show("anan");
            }
            if(x == 4)
            {
                MessageBox.Show("baban");
            }
            else
            {
                MessageBox.Show("gf");
            }
           
        }
    }
}
