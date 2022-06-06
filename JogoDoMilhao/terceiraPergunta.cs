using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//função habilitada 
using System.Threading;

//Habilitada a função do som WAV
using System.Media;

namespace JogoDoMilhao
{
    public partial class terceiraPergunta : Form
    {
        //função criada para pular forms 
        Thread nt;
        Thread nt2;
        Thread nt3;

        //direcionador
        Thread nt4;

        //variavel som3 criada
        SoundPlayer som3 = new SoundPlayer("op11.wav");
        public terceiraPergunta()
        {
            InitializeComponent();

            //toca o som3
            som3.Play();
        }
/*------------------------------------------------------------------------------------------- */
//                     ALTERNATIVA A 
        private void btnTerceiroA_Click(object sender, EventArgs e)
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

                //fecha o som
                som3.Stop();

            }

        }
        private void Form1()
        {
            Application.Run(new Form1());
        }
/*------------------------------------------------------------------------------------------- */ 
//                      ALTERNATIVA B 
        private void btnTerceiroB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você acertou!");

                //fecha form 
                this.Close();

                nt4 = new Thread(quartaPergunta);
                nt4.SetApartmentState(ApartmentState.STA);
                nt4.Start();

                //fecha o som
                som3.Stop();

            }
        }
        private void quartaPergunta()
        {
            Application.Run(new quartaPergunta());
        }
/*------------------------------------------------------------------------------------------- */
//                     ALTERNATIVA C 
        private void btnTerceiroC_Click(object sender, EventArgs e)
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

                //fecha som
                som3.Stop();

            }
        }
       
/*------------------------------------------------------------------------------------------- */
//                    ALTERNATIVA D 
        private void btnTerceiroD_Click(object sender, EventArgs e)
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

                //fecha som
                som3.Stop();

            }
        }
    }
}
