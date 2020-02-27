<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WEBControl.Contact" %>
<%@ Register Src="~/WebUserControl1.ascx" TagName="WebControl" TagPrefix="TWebControl"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 
&nbsp;<TWebControl:WebControl ID="Header" runat="server"  /> 
    
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <br />  
    
    
    
    

</asp:Content>
