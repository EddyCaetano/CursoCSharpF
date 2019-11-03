using Dados.DAO;
using Dados.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        ArquivoTexto dados = new ArquivoTexto();
        public Form1()
        {
            InitializeComponent();
            ListarPessoas();
        }
        private void ListarPessoas()
        {
            List<Pessoa> lista = dados.LerTodos();
            dgvPessoas.DataSource = lista;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            lblErro.Text = ""; // para limbar o label d erro e deixar vazio
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string CPF = txtCPF.Text;

            if ( ValidaFormulario(nome, sobrenome, CPF))
            {

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.Sobrenome = sobrenome;
            pessoa.CPF = CPF;
            dados.Salvar(pessoa);

            Limpar();
            ListarPessoas();

            }

            
        }
        private bool ValidaFormulario (string nome, string sobrenome, string CPF)
            {
                bool valido = true;
                if (nome.Trim() == "")
                {
                    lblErro.Text = " O nome não foi preenchiodo.";
                    valido = false;
                }
                if (sobrenome.Trim() == "")
                {
                    lblErro.Text += " O Sobrenome não foi preenchiodo."; //o "+" vai juntar os textos
                    valido = false;
                }
                if (CPF.Trim() == "")
                {
                    lblErro.Text += " O CPF não foi preenchiodo."; //o "+" vai juntar os textos
                    valido = false;
                }

            return valido;
            }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCPF.Text = "";
        }
    }
}
