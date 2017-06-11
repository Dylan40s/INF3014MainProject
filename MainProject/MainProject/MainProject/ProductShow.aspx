<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductShow.aspx.cs" Inherits="MainProject.ProductShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="~/Content/ProductPage.css" rel="stylesheet" runat="server" />
    
    <table id="tableID" style="width:100%" >
        <tr>
            <td style="width:30%" runat="server" id="scaleID">
                    <h4>Category</h4>
                    <asp:RadioButtonList ID="categorySelect" runat="server">
                        <asp:ListItem Text="Clothing" Value="1" />
                        <asp:ListItem Text="Houseware" Value="2" />
                        <asp:ListItem Text="Stationery" Value="3" />
                        <asp:ListItem Text="Specials" Value="4" />
                    </asp:RadioButtonList>
                     <h4>Price</h4>
                    <input id="filterScale" type ="range" min ="10" max="1000" step ="50" value ="1000" onChange="myFunction()"/>
                    <asp:TextBox ID="textScale" runat="server" Visible="True" Text="<1000"></asp:TextBox>
                    <h4>Colour</h4>
                <asp:RadioButtonList ID="colourSelect" runat="server">
                        <asp:ListItem Text="Blue" Value="1" />
                        <asp:ListItem Text="Red" Value="2" />
                        <asp:ListItem Text="Black" Value="3" />
                        <asp:ListItem Text="Green" Value="4" />
                        <asp:ListItem Text="White" Value="3" />
                        <asp:ListItem Text="Other" Value="4" />
                    </asp:RadioButtonList>
                <asp:Button class="FilterButton" runat="server" onclick="applyFilters" Text="Apply filter" ClientIDMode="Static"></asp:Button>
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
        MyTextBox = document.getElementById("<%= textScale.ClientID %>");
        //alert(MyTextBox.value);

        MyTextBox.value = "<" + document.getElementById("filterScale").value;
        
    }
    </script>
</asp:Content>
