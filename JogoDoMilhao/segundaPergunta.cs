using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Passar para o proximo form
using System.Threading;
//Habilitando o som de extensão WAV
using System.Media;

namespace JogoDoMilhao
{
    public partial class segundaPergunta : Form
    {
        Thread nt;
        Thread nt2;
        Thread nt3;
        //função que vai para o proximo form
        Thread nt4;

        SoundPlayer som2 = new SoundPlayer("op3.wav");

        public segundaPergunta()
        {
            InitializeComponent();
            som2.Play();
        }

        private void btnSegundoA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você acertou!");

                //fecha form
                this.Close();
                //direcionando para a terceira pergunta 
                nt4 = new Thread(terceiraPergunta);
                nt4.SetApartmentState(ApartmentState.STA);
                nt4.Start();
                
                //O som para
                som2.Stop();

            }
        }
        private void terceiraPergunta()
        {
            Application.Run(new terceiraPergunta());
        }
/*------------------------------------------------------------------------------------------- */
//                       ALTERNATIVA B 
        private void btnSegundoB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Que pena, você errou! :(");

                //fecha o form atual
                this.Close();


                //criando uma variavel para ir a outro form
                nt = new Thread(Form1);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

                //O som para 
                som2.Stop();

            }
        }
        private void Form1()
        {
            Application.Run(new Form1());
        }

/*--------------------------------------------------------------------------------------------- */
//                     ALTERNATIVA C
        private void btnSegundoC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Que pena, você errou! :(");

                //fecha o form atual
                this.Close();


                //criando uma variavel para ir a outro form
                nt2 = new Thread(Form1);
                nt2.SetApartmentState(ApartmentState.STA);
                nt2.Start();

                //O som para
                som2.Stop();

            }
        }
/*-------------------------------------------------------------------------------------------- */ 
//                      ALTERNATIVA D
        private void btnSegundoD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Que pena, você errou! :(");

                //fecha o form atual
                this.Close();


                //criando uma variavel para ir a outro form
                nt3 = new Thread(Form1);
                nt3.SetApartmentState(ApartmentState.STA);
                nt3.Start();

                //O som para
                som2.Stop();

            }
        }
    }
}
