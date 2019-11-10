using Dados.DAO;
using Dados.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppWebForms
{
    public partial class _Default : Page
    {
        ArquivoTexto arquivo_texto = new ArquivoTexto();
        protected void Page_Load(object sender, EventArgs e)
        {
            CarreLista();
        }

        private void CarreLista()
        {
            gdvPessoas.DataSource = arquivo_texto.LerTodos();
            gdvPessoas.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;
            pessoa.Sobrenome = txtSobrenome.Text;
            pessoa.CPF = txtCPF.Text;

            arquivo_texto.Salvar(pessoa);
            Limpar();
            CarreLista();
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
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