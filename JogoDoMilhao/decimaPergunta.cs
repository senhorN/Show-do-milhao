using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Função Habilitada 
using System.Threading;
//função de som habilitada
using System.Media;

namespace JogoDoMilhao
{
    public partial class decimaPergunta : Form
    {
        Thread nt;
        Thread nt2;
        Thread nt3;

        //nt4 criada
        Thread nt4;

        //função som10 
        SoundPlayer som10 = new SoundPlayer("op3.wav");
        public decimaPergunta()
        {
            InitializeComponent();
            som10.Play();
        }

        private void btnDecimoA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Você certou!");

                //fecha form
                this.Close();


                //fecha som
                som10.Stop();

            }
        }

        private void btnDecimoB_Click(object sender, EventArgs e)
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

                //fecha som
                som10.Stop();
            }
        }
        private void Form1()
        {
            Application.Run(new Form1());
        }

        private void btnDecimoC_Click(object sender, EventArgs e)
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

                //fecha form
                som10.Stop();


            }
        }

        private void btnDecimoD_Click(object sender, EventArgs e)
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
                som10.Stop();
            }
        }

        private void decimaPergunta_Load(object sender, EventArgs e)
        {

        }
    }
}
