<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimGuncelle.aspx.cs" Inherits="BlokWeb.AdminEgitimGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <form id="Form1" runat="server">
        <div class="form-group">
             <div>
                <asp:Label ID="Label5" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label1" runat="server" Text="BASLIK"></asp:Label>
                <asp:TextBox ID="TxtBaslık" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                     <asp:Label ID="Label2" runat="server" Text="ALTBASLIK" ></asp:Label>
                <asp:TextBox ID="TxtAltBaslık" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                     <asp:Label ID="Label3" runat="server" Text="ACIKLAMA" ></asp:Label>
                <asp:TextBox ID="TxtAciklama" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
            </div>  
            <br />
            <div>
                     <asp:Label ID="Label7" runat="server" Text="GENEL NOT" ></asp:Label>
                <asp:TextBox ID="TxtGmot" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
            </div>
            <br />
            <div>
                     <asp:Label ID="Label4" runat="server" Text="TARIH" ></asp:Label>
                <asp:TextBox ID="TxtTarih" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
           <br />
            <asp:Button ID="BtnGuncelle" runat="server" Text="Guncele" CssClass="btn btn-primary" OnClick="BtnGuncelle_Click1"    />
        </div>
    </form>

</asp:Content>
