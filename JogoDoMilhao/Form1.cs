using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Habilita a função de pular forms diferente do showDialog 
using System.Threading;

//tocar um WAV
using System.Media;


namespace JogoDoMilhao
{
    public partial class Form1 : Form
    {
       

        Thread nt;
        SoundPlayer som = new SoundPlayer("AberturaSM.wav");


        public Form1()
        {
            InitializeComponent();
            //utiliza o som de abertura 
            
            
            som.Play();
             
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void btnJogar_Click(object sender, EventArgs e)
        {
            //fecha o form que esta atual    
            this.Close();
            //pula para outro form 
            nt = new Thread(cadastroDoJogador);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

            som.Stop();
            
        }
        private void cadastroDoJogador()
        {
           
            Application.Run(new cadastroDoJogador());
        }
    }
}
