<%@ Page Title="Accounts Home" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="True"
    CodeBehind="Default.aspx.cs" Inherits="Accounts.Web.Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 class="title">Profit Calculator</h2> 
					
                    <asp:Panel ID="pnlError" CssClass="error" runat="server" Visible="false">There was an error in the calculation.</asp:Panel>
                    <table cellpadding="0" cellspacing="0" align="center">
                        <thead><tr><th>Line Item</th><th>Amount</th></tr></thead>
                        <tbody>
                            <tr>
                                <td>Revenue</td>
                                <td><asp:TextBox ID="txtRevenue" runat="server" Width="200" /></td>
                            </tr>
                            <tr>
                                <td>Expenses</td>
                                <td><asp:TextBox ID="txtExpenses" runat="server" Width="200" /></td>
                            </tr>
                            <tr>
                                <td>Net</td>
                                <td><asp:Literal runat="server" ID="litNet" /></td>
                            </tr>
                        </tbody>
                    </table>
                    <br />
                    <asp:Button ID="btnDisplayTotals" runat="server" Text="Display Totals"
                            OnClick="btnDisplayTotals_Click" />
</asp:Content>
