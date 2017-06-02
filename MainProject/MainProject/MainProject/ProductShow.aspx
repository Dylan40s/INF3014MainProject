<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductShow.aspx.cs" Inherits="MainProject.ProductShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="~/Content/ProductPage.css" rel="stylesheet" runat="server" />
    
    <table style="width:100%">
        <tr>
            <td style="width:30%">
                <form>
                     Points:
                    <input id="filterScale" type ="range" min ="100" max="1000" step ="50" value ="1000" onChange="myFunction()"/>
                    <input id="textScale" type="text" value="1000" />
                </form>
            </td>
            <td style="width:70%">
                <asp:ListView ID="productList" runat="server" DataKeyNames="ProductID" GroupItemCount="4" ItemType="MainProject.Models.Product" SelectMethod="GetProducts">



                    <EmptyDataTemplate>
                        <table>
                            <tr>
                                <td>No data was returned.</td>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                    <GroupTemplate>
                        <tr id="itemPlaceholderContainer" runat="server">
                            <td id="itemPlaceholder" runat="server"></td>
                        </tr>
                    </GroupTemplate>
                    <ItemTemplate>

                        <td runat="server">
                            <ul>
                                <li><%#: Item.ProductName%></li>
                                <li>
                                    <a href="ProductDetails.aspx?productName=<%#:Item.ProductName %>">

                                        <image src='../Images/<%#:Item.ImagePath%>' alt="<%#:Item.ProductName%>" width="150" height="300" border="1" />

                                    </a>
                                </li>
                                <li>
                                    <br />
                                    <span>
                                        <b>Price: </b><%#:String.Format("{0:c}", Item.UnitPrice)%>
                                    </span>
                                    <br />
                                </li>
                                <li>&nbsp;</li>
                            </ul>
                        </td>

                    </ItemTemplate>
                    <LayoutTemplate>
                        <table style="width: 100%;">
                            <tbody>
                                <tr>
                                    <td>
                                        <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                            <tr id="groupPlaceholder"></tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                </tr>
                                <tr></tr>
                            </tbody>
                        </table>
                        </p>
          
            
                    </LayoutTemplate>


                </asp:ListView>
            </td>
        </tr>
    </table>


<script type="text/javascript">
    function myFunction() {
        document.getElementById("textScale").value = document.getElementById("filterScale").value;
        
    }
    </script>
</asp:Content>
