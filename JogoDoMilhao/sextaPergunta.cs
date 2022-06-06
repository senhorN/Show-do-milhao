using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//habilitando função no form
using System.Threading;
//habilitado a função de som WAV
using System.Media;

namespace JogoDoMilhao
{
    public partial class sextaPergunta : Form
    {
        //função criada
        Thread nt;
        Thread nt2;
        Thread nt3;
        //nt4 para o sétimo form
        Thread nt4;

        //função som6 criada
        SoundPlayer som6 = new SoundPlayer("op3.wav");


        public sextaPergunta()
        {
            InitializeComponent();
            som6.Play();
        }
/*------------------------------------------------------------------------------------------- */
//                    ALTERNATIVA A
        private void btnSextaA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você acertou!");

                //fecha form
                this.Close();

                nt4 = new Thread(setimaPergunta);
                nt4.SetApartmentState(ApartmentState.STA);
                nt4.Start();

                //fecha som
                som6.Stop();

                
            }

        }
        private void setimaPergunta()
        {
            Application.Run(new setimaPergunta());
        }
/*------------------------------------------------------------------------------------------ */
//                    ALTERNATIVA B
        private void btnSextaB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você errou! :(");

                //fecha form
                this.Close();

                //pula para outro form
                nt = new Thread(Form1);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

                //fecha form
                som6.Stop();

            }

        }
        private void Form1()
        {
            Application.Run(new Form1());
        }

/*------------------------------------------------------------------------------------------ */
//                   ALTERNATIVA C
        private void btnSextaC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você errou! :(");

                //fecha form
                this.Close();

                //pula pra outro form
                nt2 = new Thread(Form1);
                nt2.SetApartmentState(ApartmentState.STA);
                nt2.Start();

                //fecha som
                som6.Stop();
            }

        }
/*------------------------------------------------------------------------------------------ */
//                   ALTERNATIVA D
        private void btnSextaD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você errou! :(");

                //fecha form
                this.Close();

                //pula pra outro form
                nt3 = new Thread(Form1);
                nt3.SetApartmentState(ApartmentState.STA);
                nt3.Start();

                //fecha som
                som6.Stop();
            }

        }
    }
}
