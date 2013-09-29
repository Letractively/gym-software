<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Relatórios
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Relatórios</h2>

<p><%: Html.ActionLink("Produtos com estoque baixo", "Index", "Produto/RelatorioProdutoEstoqueBaixo")%></p>
<p><%: Html.ActionLink("Produtos cadastrados", "Index", "Produto/RelatorioProduto")%></p>
<p><%: Html.ActionLink("Funcionarios cadastrados", "Index", "Funcionario/RelatorioFuncionario")%></p>
<p><%: Html.ActionLink("Funcionarios Por Permicao", "Index", "Funcionario/RelatorioFuncionarioPorPermicao")%></p>
<p><%: Html.ActionLink("Aluno cadastrados", "Index", "Aluno/RelatorioAluno")%></p>




</asp:Content>
