<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="adminControl.ascx.cs" Inherits="BTL_LTW.Manage.adminControl" %>
<%@ Register src="menu/menuControl.ascx" tagname="menuControl" tagprefix="uc1" %>
<%@ Register Src="~/Manage/footer/footerControl.ascx" TagPrefix="uc1" TagName="footerControl" %>

<uc1:menuControl ID="menuControl1" runat="server" />
<asp:PlaceHolder ID="placeholder" runat="server" ></asp:PlaceHolder>
<uc1:footerControl runat="server" ID="footerControl" />
