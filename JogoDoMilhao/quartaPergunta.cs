using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Função habilitada 
using System.Threading;
//Habilita a função de som WAV
using System.Media;

namespace JogoDoMilhao
{
    public partial class quartaPergunta : Form
    {
        //função de pular de form
        Thread nt;
        Thread nt2;
        Thread nt3;

        //função parao proximo form
        Thread nt4;

        //variavel som4 criada
        SoundPlayer som4 = new SoundPlayer("op4.wav");

        public quartaPergunta()
        {
            InitializeComponent();
            som4.Play();
        }

        private void btnQuartaA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você acertou!");

                //fecha form
                this.Close();

                nt4 = new Thread(quintaPergunta);
                nt4.SetApartmentState(ApartmentState.STA);
                nt4.Start();

                //fecha o som
                som4.Stop();

            }

        }
        private void quintaPergunta()
        {
            Application.Run(new quintaPergunta());
        }
/*----------------------------------------------------------------------------------------- */
//                     ALTERNATIVA B
        private void btnQuartaB_Click(object sender, EventArgs e)
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

                //fecha o form
                som4.Stop();

            }

        }
        private void Form1()
        {
            Application.Run(new Form1());
        }
/*----------------------------------------------------------------------------------------- */
//                     ALTERNATIVA C
        private void btnQuartaC_Click(object sender, EventArgs e)
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

                //fecha o form
                som4.Stop();

            }
        }
/*----------------------------------------------------------------------------------------- */
//                     ALTERNATIVA D
        private void btnQuartaD_Click(object sender, EventArgs e)
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


                //fecha o form
                som4.Stop();
            }
        }
    }
}
