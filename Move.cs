using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truck
{
    public partial class Move : Form
    {
        static decimal max_value;

        public void MaxIndex_Set(int value)
        {
            max_value = value;
            //Move_numericUpDown.Maximum = value;
            //Move_numericUpDown.Minimum = 0;
        }







        public Move()
        {
            InitializeComponent();
        }

        private void Move_button_Click(object sender, EventArgs e)
        {
            if(Move_numericUpDown.Value > max_value || Move_numericUpDown.Value < 0)
            {
                MessageBox.Show($"Enter a valid index between 0 and {max_value}.", "Invalid index", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Form1 form1 = new Form1();
                this.Close();
                form1.Move_Radio_Action(Convert.ToInt32(Move_numericUpDown.Value));
            }
        }
    }
}
