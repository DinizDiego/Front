using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemaFront
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }//Fim do construtor

        private void Menu_Load(object sender, EventArgs e)
        {

        }//Fim do método -> Faz o carregamento de conteúdos da minha tela

        private void button3_Click(object sender, EventArgs e)
        {

        }//Atualizar

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }//Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {

        }//Consultar

        private void button4_Click(object sender, EventArgs e)
        {

        }//Excluir
    }//Fim da classe
}//Fim do projeto
