<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Home/Site.Master" Inherits="System.Web.Mvc.ViewPage<Teste.Models.Cidade>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div>
    <fieldset style="width:330px;">
    <legend>Cadastro Estado</legend>
    <table>
        <tr>
            <td><%=Html.Label("Nome:") %></td>
            <td><%=Html.TextBox("Nome")%></td>
        </tr>
        <tr>
            <td><%=Html.Label("Sigla:") %></td>
            <td><%=Html.TextBox("Sigla")%></td>
        </tr>
        <tr>
            <td><%=Html.Label("País:") %></td>
            <td><%=Html.TextBox("Pais")%></td>
        </tr>
        <tr>
            <td><%=Html.Label("Região:") %></td>
            <td><%=Html.TextBox("Regiao")%></td>
        </tr>
        <tr>
            <td colspan="2"><input type="button" id="btnSalvarEstado" value="SALVAR" /></td>
        </tr>
    </table>
    </fieldset>
    </div>

</asp:Content>
