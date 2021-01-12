using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace how_to_save_yourself_from_death_in_circle
{
    public partial class jesophus_problem : Form
    {
        public jesophus_problem()
        {
            InitializeComponent();
        }
        public static int josephus(int n, int k)
        {
            
            if (n == 1)
                return 1;
            else
                /* The position returned  
                by josephus(n - 1, k) is 
                adjusted because the 
                recursive call josephus(n 
                - 1, k) considers the  
                original position k%n + 1 
                as position 1 */
                return (josephus(n - 1, k)
                           + k - 1) % n + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to specify two variants N and K which is usually 2 since every second person will be killed","Information",MessageBoxButtons.OK);
        }

        private void RBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RBox.Text = Convert.ToString(josephus(Convert.ToInt16(N_Box.Text), Convert.ToInt16(K_Box.Text)));
        } 

    }
}
