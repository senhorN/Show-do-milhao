using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//habilitada a função
using System.Threading;
//Habilita a função de som
using System.Media;

namespace JogoDoMilhao
{
    public partial class nonaPergunta : Form
    {
        //Função nt 
        Thread nt;
        Thread nt2;
        Thread nt3;
        //função nt4 criada
        Thread nt4;

        //função de som WAV
        SoundPlayer som9 = new SoundPlayer("op11.wav");
        public nonaPergunta()
        {
            InitializeComponent();
            som9.Play();
        }
/*------------------------------------------------------------------------------------------ */
//                      ALTERNATIVA A 
        private void btnNonaA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você errou! :(");

                //fecha form
                this.Close();

                nt = new Thread(Form1);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

                //fecha o som
                som9.Stop();
            }

        }
        private void Form1()
        {
            Application.Run(new Form1());
        }
/*--------------------------------------------------------------------------------------- */
//                      ALTERNATIVA B
        private void btnNonaB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você errou! :(");

                //fecha form
                this.Close();

                nt2 = new Thread(Form1);
                nt2.SetApartmentState(ApartmentState.STA);
                nt2.Start();

                //fecha o som
                som9.Stop();
            }

        }
/*------------------------------------------------------------------------------------------- */
//                      ALTERNATIVA C 
        private void btnNonaC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você errou! :(");

                //fecha form
                this.Close();

                nt3 = new Thread(Form1);
                nt3.SetApartmentState(ApartmentState.STA);
                nt3.Start();

                //fecha som
                som9.Stop();
            }
        }
/*------------------------------------------------------------------------------------------ */
//                      ALTERNATIVA D
        private void btnNonaD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você acertou!");

                //fecha form
                this.Close();

                nt4 = new Thread(decimaPergunta);
                nt4.SetApartmentState(ApartmentState.STA);
                nt4.Start();

                //fecha som
                som9.Stop();

            }
        }
        private void decimaPergunta()
        {
            Application.Run(new decimaPergunta());
        }
    }
}
