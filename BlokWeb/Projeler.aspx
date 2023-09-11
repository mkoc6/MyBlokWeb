<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Projeler.aspx.cs" Inherits="BlokWeb.Projeler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>PROJELER</th>
            <th>ISLEMLER</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th><%#Eval("ID") %></th>
                        <td><%#Eval("PROJELER") %></td>
                         <td>
                            <asp:HyperLink NavigateUrl='<%#"ProjeSil.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sıl</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"ProjeGunceller.Aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Guncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
          <asp:HyperLink NavigateUrl="~/ProjeEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">PROJE EKLE</asp:HyperLink>
          </form>
</asp:Content>
