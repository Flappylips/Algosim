using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlgorithmSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         Bubblesort bubsort = new Bubblesort(); /*declares variable & creates object puuting this above core code
                                          * stops mutiple forms being opened*/
        private void Bubsort_Click(object sender, EventArgs e)
        {
            bubsort.Show(); // opens Bubblesort form on button click (bubble button)
        }
          Linear lin1 = new AlgorithmSimulator.Linear(); //declares variable & creates object
        private void Linear_Click(object sender, EventArgs e)
        {
            lin1.Show();
     
        }
    }
}
