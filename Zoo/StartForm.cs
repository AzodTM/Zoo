using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonCreate.Hide();            
            buttonCreateBird.Show();
            buttonCreateFish.Show();
            buttonCreateArthropod.Show();
            buttonCreateMammal.Show();
        }

        private void buttonCreateArthropod_Click(object sender, EventArgs e)
        {
            
        }
    }
}
