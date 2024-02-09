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
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();//conectar a tela ocm a classe dao
        }//Fim do construtor

        private void label2_Click(object sender, EventArgs e)
        {

        }//Fim do método

        private void codigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do codigo

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do telefone

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }//Fim da cidade

        private void estado_TextChanged(object sender, EventArgs e)
        {

        }//Fim do estado

        private void cadastro_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(codigo.Text);
            string name = nome.Text;
            string tell = telefone.Text;
            string cid = cidade.Text;
            string estad = estado.Text;

            bd.inserir(cod, name, tell, cid, estad);//Inserindo no bd

            //Limpado os campos
            codigo.Text = "";
            nome.Text = "";
            telefone.Text = "";
            cidade.Text = "";
            estado.Text = "";
        }//Fim do cadastrar

        private void sair_Click(object sender, EventArgs e)
        {

        }//Fim do sair
    }//Fim da classe
}//Fim do projeto
