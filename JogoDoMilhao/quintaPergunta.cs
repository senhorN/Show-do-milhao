using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//habilitada a função de pular forms
using System.Threading;

using System.Media;

namespace JogoDoMilhao
{
    public partial class quintaPergunta : Form
    {
        Thread nt;
        Thread nt2;
        Thread nt3;

        //função para ir ao proximo form
        Thread nt4;

        //variavel som5 criada
        SoundPlayer som5 = new SoundPlayer("op11.wav");

        public quintaPergunta()
        {
            InitializeComponent();
            som5.Play();
        }

/*------------------------------------------------------------------------------------- */ 
//                      ALTERNATIVA B
        private void btnQuintaB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("você errou!");

                //fecha o form atual
                this.Close();


                //criando uma variavel para ir a outro form
                nt = new Thread(Form1);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

                //fecha som
                som5.Stop();

            }
        }
        private void Form1()
        {
            Application.Run(new Form1());
        }

/*------------------------------------------------------------------------------------- */
//                      ALTERNATIVA A 
        private void btnQuintaA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("você errou!");

                //fecha o form atual
                this.Close();


                //criando uma variavel para ir a outro form
                nt2 = new Thread(Form1);
                nt2.SetApartmentState(ApartmentState.STA);
                nt2.Start();

                //fecha som
                som5.Stop();
            }
        }
/*------------------------------------------------------------------------------------- */ 
//                      ALTERNATIVA C
        private void btnQuintaC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você acertou!");

                //fecha form atual
                this.Close();


                nt4 = new Thread(sextaPergunta);
                nt4.SetApartmentState(ApartmentState.STA);
                nt4.Start();

                //fecha som
                som5.Stop();

            }
        }
        private void sextaPergunta()
        {
            Application.Run(new sextaPergunta());
        }
/*------------------------------------------------------------------------------------- */ 
//                      ALTERNATIVA D
        private void btnQuintaD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("você errou!");

                //fecha o form atual
                this.Close();


                //criando uma variavel para ir a outro form
                nt3 = new Thread(Form1);
                nt3.SetApartmentState(ApartmentState.STA);
                nt3.Start();

                //fecha som
                som5.Stop();
            }
        }
    }
}
