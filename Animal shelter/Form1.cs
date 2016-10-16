using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animal_shelter.Repo;
using Animal_shelter.Context;

namespace Animal_shelter
{
    public partial class Form1 : Form
    {
        DogRepo repo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_walkdog_Click(object sender, EventArgs e)
        {
            repo = new DogRepo(new MemoryContext());
            Hond hond = new Hond(50,"Bert", new Asiel(),true);


            try
            {
                repo.walkdog(dateTimePicker1.Value.Date, hond);
            }

            catch(UitlaatException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
