<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Home/Site.Master" Inherits="System.Web.Mvc.ViewPage<Teste.Models.Cidade>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div>
    <fieldset style="width:330px;">
    <legend>Cadastro Cidade</legend>
    <table>
        <tr>
            <td><%=Html.Label("Nome:") %></td>
            <td><%=Html.TextBox("Nome")%></td>
        </tr>
        <tr>
            <td><%=Html.Label("Estado:") %></td>
            <td><select id="cmbEstado" size="1"><option>Selecione...</option></select></td>
        </tr>
        <tr>
            <td><%=Html.Label("Capital:") %></td>
            <td><%=Html.CheckBox("Capital")%></td>
        </tr>
        <tr>
            <td colspan="2"><input type="button" id="btnSalvarCidade" value="SALVAR" /></td>
        </tr>
    </table>
    </fieldset>
    </div>

</asp:Content>
