using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//habilitada a função do som 
using System.Media;

//usado para ir a outro form
using System.Threading;

namespace JogoDoMilhao
{
    
    public partial class primeiraPergunta : Form
    {
        
       
        //Altenativa A, B e D sao alternativas incorretas, e para elas criadas as Thread nt1 nt2 e nt3
        Thread nt;
        Thread nt2;
        Thread nt3;

        //thread criado para ir a proximo form
        Thread nt4;
        
        //variavel da musica criada 
        SoundPlayer som1 = new SoundPlayer("op2.wav");

        public primeiraPergunta()
        {
            InitializeComponent();
            
            //Som da pergunta 
            som1.Play();
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblErrar_Click(object sender, EventArgs e)
        {

        }
//                  ALTERNATIVA A
        private void btnA_Click(object sender, EventArgs e)
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
                som1.Stop();

            }    
        }
        private void Form1()
        {
            Application.Run(new Form1());
           
        }
/*-------------------------------------------------------------------------------------------- */ 
//                     ALTERNATIVA B
        private void btnB_Click(object sender, EventArgs e)
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

                //fecha o som
                som1.Stop();

            }
        }
/*------------------------------------------------------------------------------------------- */
//                     ALTERNATIVA C 
        private void btnC_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                MessageBox.Show("Você acertou!");

                
                //fecha o form
                this.Close();

                //direcionando para a segunda pergunta
                nt4 = new Thread(segundaPergunta);
                nt4.SetApartmentState(ApartmentState.STA);
                nt4.Start();

                //fecha o som
                som1.Stop();

            }

        }
        private void segundaPergunta()
        {
            Application.Run(new segundaPergunta());
        }
/*------------------------------------------------------------------------------------------- */
//                        ALTERNATIVA D 
        private void btnD_Click(object sender, EventArgs e)
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

                //fecha o som
                som1.Stop();

            }
        }
    }
    
}
