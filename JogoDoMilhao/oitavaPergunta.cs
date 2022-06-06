using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Habilita a função
using System.Threading;

using System.Media;

namespace JogoDoMilhao
{
    public partial class oitavaPergunta : Form
    {
        //função
        Thread nt;
        Thread nt2;
        Thread nt3;

        //função
        Thread nt4;

        //função do som 8 habilitada
        SoundPlayer som8 = new SoundPlayer("op2.wav");

        public oitavaPergunta()
        {
            InitializeComponent();
            som8.Play();
        }
/*----------------------------------------------------------------------------------- */
//                      ALTERNATIVA A 
        private void btnOitavaA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você errou!");

                //fecha form
                this.Close();

                nt = new Thread(Form1);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

                //fecha som
                som8.Stop();
            }
        }
        private void Form1()
        {
            Application.Run(new Form1());
        }
/*----------------------------------------------------------------------------------- */
//                      ALTERNATIVA B              
        private void btnOitavaB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você errou!");

                //fecha form
                this.Close();

                nt2 = new Thread(Form1);
                nt2.SetApartmentState(ApartmentState.STA);
                nt2.Start();

                //fecha som
                som8.Stop();
            }
        }
/*------------------------------------------------------------------------------------ */
//                      ALTERNATIVA C
        private void btnOitavaC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você acertou!");

                //fecha form
                this.Close();

                nt4 = new Thread(nonaPergunta);
                nt4.SetApartmentState(ApartmentState.STA);
                nt4.Start();

                //fecha som
                som8.Stop();
                
            }
        }
        private void nonaPergunta()
        {
            Application.Run(new nonaPergunta());

        }
/*------------------------------------------------------------------------------------ */
//                      ALTERNATIVA D
        private void btnOitavaD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você errou!");

                //fecha form
                this.Close();

                nt3 = new Thread(Form1);
                nt3.SetApartmentState(ApartmentState.STA);
                nt3.Start();

                //fecha som 
                som8.Stop();
            }
        }
    }
}
