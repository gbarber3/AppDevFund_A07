<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Feb2Class.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>

    <br />
    <table align="center" style="width: 80%; border-style: solid; border-width: 1px">
        <tr>
            <td style="width: 396px">
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="438px"></asp:TextBox>
&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 396px; height: 20px;">
                <asp:Label ID="Label1" runat="server" ForeColor="#FF9966" Text="Label">Choice</asp:Label>
            </td>
            <td style="height: 20px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="1">Course 1001</asp:ListItem>
                    <asp:ListItem Value="2">Course 1002</asp:ListItem>
                    <asp:ListItem Value="3">CompSci</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="width: 396px">
                <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Programming course" />
            </td>
        </tr>
        <tr>
            <td style="width: 396px">
                <asp:Literal ID="ltrCourse" runat="server"></asp:Literal>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 396px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 396px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 396px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />


</asp:Content>
