<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimler.aspx.cs" Inherits="BlokWeb.AdminEgitimler" %>
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
            <th>Genel Not Ort</th>
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
                        <td><%#Eval("GNOT") %></td>
                        <td><%#Eval("TARIH") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminEgitimSil.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sıl</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"AdminEgitimGuncelle.Aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Guncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
          <asp:HyperLink NavigateUrl="~/AdminEgitimEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Egitim EKLE</asp:HyperLink>
          </form>
</asp:Content>
