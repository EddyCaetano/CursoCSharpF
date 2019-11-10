<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="formulario">
        <div class="desc"> 
        <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
        </div>
        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox> <br />  

        <div class="desc">
        <asp:Label ID="lblSobrenome" runat="server" Text="Sobrenome:"></asp:Label>
        </div>
        <asp:TextBox ID="txtSobrenome" runat="server" CssClass="form-control"></asp:TextBox><br />  

        <div class="desc">
        <asp:Label ID="lblCPF" runat="server" Text="CPF:"></asp:Label>
        </div>
        <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control"></asp:TextBox><br />    

        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-success" OnClick="btnSalvar_Click" />
        <asp:Button ID="btnLimpar" runat="server" Text="Limpar" CssClass="btn btn-danger" OnClick="btnLimpar_Click" />
    </div>

    <div id="listagem"> 
        <asp:GridView ID="gdvPessoas" runat="server" CssClass="table table-striped"></asp:GridView>
    </div>


</asp:Content>
