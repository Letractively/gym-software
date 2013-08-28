<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Aluno>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.detalhes %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhes %></h2>

<fieldset>
    <legend>Aluno</legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.matricula %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Matricula) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.nome_razao %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeRazao) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apelido_fantasia %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ApelidoFantasia) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.valor_mensalidade %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorMensalidade) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.ativo_desde %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.AtivoDesde) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.dia_vencimento %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DiaVencimento) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.data_matricula %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataMatricula) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.data_trancamento %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataTrancamento) %>
    </div>


    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.cadastrado_desde %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CadastradoDesde) %>
    </div>





    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.cpf_cnpj %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CpfCnpj) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.rg %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.RG) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.data_nascimento %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataNascimento) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.sexo %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Sexo) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.rua %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Rua) %>
    </div>

    <div class="display-label"><%:Models.App_GlobalResources.Mensagem.numero%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>

    <div class="display-label"><%:Models.App_GlobalResources.Mensagem.bairro%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bairro) %>
    </div>

    <div class="display-label"><%:Models.App_GlobalResources.Mensagem.cidade%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cidade) %>
    </div>

    <div class="display-label"><%:Models.App_GlobalResources.Mensagem.estado%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
    </div>

    <div class="display-label"><%:Models.App_GlobalResources.Mensagem.cep%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CEP) %>
    </div>

    <div class="display-label"><%:Models.App_GlobalResources.Mensagem.complemento%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Complemento) %>
    </div>

    <div class="display-label"><%:Models.App_GlobalResources.Mensagem.telefone1%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Telefone1) %>
    </div>

    <div class="display-label"><%:Models.App_GlobalResources.Mensagem.telefone2%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Telefone2) %>
    </div>

    <div class="display-label"><%:Models.App_GlobalResources.Mensagem.email%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Email) %>
    </div>

    <div class="display-label"><%:Models.App_GlobalResources.Mensagem.senha%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Senha) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id=Model.Matricula }) %> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar_para_lista, "Index")%>
</p>

</asp:Content>
