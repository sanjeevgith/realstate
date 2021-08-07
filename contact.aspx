<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true"
    CodeFile="contact.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<table align="center" cellpadding="10">
        <tr align="center">
            <td align="center">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Fullscreen capture 5112014 111240 AM.bmp.jpg"
                    Height="248px" Width="950px" />
            </td>
        </tr>
        <tr align="center">
            <td align="center">
                <span style="font-family: 'Times New Roman', Times, serif"><strong><span style="color: #CC0000">
                    ADDRESS:</span><br />
                    506 Raj Legacy<br />
                    Vikhroli(west)<br />
                    Mumbai-83<br />
                </strong></span>
            </td>
        </tr>
        <tr align="center">
            <td align="center">
                <span style="font-family: 'Times New Roman', Times, serif"><strong><span style="color: #FF0000">
                    PHONE:</span><br />
                    0100-100-1000<br />
                    <br />
                    <span style="color: #CC0000">FAX:<br />
                    </span>020-200-2000<br />
                    <br />
                    EMAIL:<br />
                    &nbsp;&nbsp;&nbsp; <span style="text-decoration: underline; color: #0000FF">Info@Tiwarirealestate.com</span>
                </strong></span>
            </td>
        </tr>
    </table>--%>
    <table border="0" cellpadding="0" cellspacing="0" width="80%" align="center">
        
       <h2 align="center"> Find US HERE</h2>
        <tr>
            
            <td align="center" style="width: 750px">
               
                <br />
                <br />
                <br />
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Fullscreen capture 5112014 111240 AM.bmp"
                    Width="550px" Height="231px" /><br />
                <br />
                <br />
                <div align="center">
                    <span style="font-family: 'Times New Roman', Times, serif"><strong><span style="color: #CC0000">
                        ADDRESS:</span><br />
                        manoo heights,<br />
                        chand nagar,<br />
                        kausa-mumbra<br />
                    </strong></span>
                </div>
            </td>
            <td>
                <h2>
                    CONTACT US</h2>
                <table border="0" cellpadding="10" cellspacing="0">
                    <tr>
                        <td>
                            Name
                        </td>
                        <td>
                            <asp:TextBox runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Email ID
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Address
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" />
                        </td>
                    </tr>
                    <tr align="center">
                        <td colspan="2">
                            <asp:Button Text="Submit" runat="server" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
