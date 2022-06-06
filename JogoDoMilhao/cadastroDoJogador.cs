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

//Habilita a conexão com o banco de dados 
using MySql.Data.MySqlClient;

namespace JogoDoMilhao
{
    public partial class cadastroDoJogador : Form

    {
        //função nt criada
        Thread nt;
        
        //Ativando o banco de dados 
        MySqlConnection mConn = new MySqlConnection(
        "Persist Security Info = false;" + 
        "Server = localhost;" + 
        "database = showdomilhao;" + 
        "uid = root;" +
        "pwd = "
        );


        public cadastroDoJogador()
        {
            InitializeComponent();
        }

        private void cadastroDoJogador_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            try
            {
                //aberto a conexão do banco 
                mConn.Open();
                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comandosql = new MySqlCommand();

                    //Insere os dados no banco de dados 
                    comandosql.CommandText = $"INSERT INTO tb_cadastro(nome) VALUES('{txtBoxNome.Text}')";

                    //Qual conexão será utilizada
                    comandosql.Connection = mConn;

                    //Executa o comando 
                    comandosql.ExecuteNonQuery();

                    txtBoxNome.Clear();

                    //Informação de registro salvo 
                    MessageBox.Show("Registro salvo com sucesso!",
                    "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
/*-----------------------------------------------------------------------------------------------------*/
                    //fecha o form de cadastro 
                    this.Close();

                    //pula para outro form
                    nt = new Thread(infoDoJogo);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                
                
                }
            }
            catch (Exception erro)
            {
                //informação caso o banco de dados tenha erro de conexão
                MessageBox.Show("Erro detecatdo, entre em contato com Dev \n\n" + erro.Message,
                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();

            }
        }
        private void infoDoJogo()
        {
            Application.Run(new infoDoJogo());
        }
    }
}
