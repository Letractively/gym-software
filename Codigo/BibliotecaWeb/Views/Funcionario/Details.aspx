<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Funcionario>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.detalhes %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhes %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.funcionario %></legend>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.codigo_funcionario %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoFuncionario) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.codigo_pessoa %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoPessoa) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.nome_razao %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeRazao) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.permicao %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Permicao) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.cpf_cnpj %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CpfCnpj) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.rg %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.RG) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.data_nascimento %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataNascimento) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.sexo %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Sexo) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.rua %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Rua) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.numero %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.bairro %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bairro) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.cidade %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cidade) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.estado %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.cep %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CEP) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.complemento %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Complemento) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.telefone1 %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Telefone1) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.telefone2 %></b></div>
    <div class="display-field"> 
        <%: Html.DisplayFor(model => model.Telefone2) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.email %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Email) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.senha %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Senha) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = Model.CodigoFuncionario })%> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar_para_lista, "Index")%>
</p>

</asp:Content>
