<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Funcionario>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Excluir</h2>

<h3>Você Realmente deseja apagar esse registro?</h3>
<fieldset>
    <legend>Funcionario</legend>

    <div class="display-label">Codigo do Funcionario</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoFuncionario) %>
    </div>

    <div class="display-label">Permicao</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Permicao) %>
    </div>


    <div class="display-label">Codigo da Pessoa</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoPessoa) %>
    </div>

    <div class="display-label">CPF / CNPJ</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CpfCnpj) %>
    </div>

    <div class="display-label">RG</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.RG) %>
    </div>

    <div class="display-label">Data de Nascimento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataNascimento) %>
    </div>

    <div class="display-label">Sexo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Sexo) %>
    </div>

    <div class="display-label">Rua</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Rua) %>
    </div>

    <div class="display-label">Número</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>

    <div class="display-label">Bairro</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bairro) %>
    </div>

    <div class="display-label">Cidade</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cidade) %>
    </div>

    <div class="display-label">Estado</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
    </div>

    <div class="display-label">CEP</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CEP) %>
    </div>

    <div class="display-label">Complemento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Complemento) %>
    </div>

    <div class="display-label">Telefone 1</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Telefone1) %>
    </div>

    <div class="display-label">Telefone 2</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Telefone2) %>
    </div>

    <div class="display-label">E-mail</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Email) %>
    </div>

    <div class="display-label">Senha</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Senha) %>
    </div>

</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Voltar para Lista", "Index") %>
    </p>
<% } %>

</asp:Content>
