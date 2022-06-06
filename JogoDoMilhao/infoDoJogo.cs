using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace JogoDoMilhao
{
    public partial class infoDoJogo : Form
    {
        Thread nt;
        public infoDoJogo()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            //fecha o form
            this.Close();

            //criando uma variavel para ir á proximo form 
            nt = new Thread(primeiraPergunta);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void primeiraPergunta()
        {
            Application.Run(new primeiraPergunta());
        }
    }
}
