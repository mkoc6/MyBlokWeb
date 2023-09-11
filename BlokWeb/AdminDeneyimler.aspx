<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDeneyimler.aspx.cs" Inherits="BlokWeb.AdminDeneyimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <form id="Form1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>BASLIK</th>
            <th>ALT BASLIK</th>
            <th>ACIKLAMA</th>
            <th>TARIH</th>
            <th>ISLEMLER</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th><%#Eval("ID") %></th>
                        <td><%#Eval("BASLIK") %></td>
                        <td><%#Eval("ALTBASLIK") %></td>
                        <td><%#Eval("ACIKLAMA") %></td>
                        <td><%#Eval("TARIH") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminDeneyimSil.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sıl</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"AdminDeneyimGuncelle.Aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Guncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
          <asp:HyperLink NavigateUrl="~/AdminDeneyinEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">DENEYİM EKLE</asp:HyperLink>
          </form>
</asp:Content>
