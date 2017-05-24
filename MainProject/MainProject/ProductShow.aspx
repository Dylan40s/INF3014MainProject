<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductShow.aspx.cs" Inherits="MainProject.ProductShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/ProductPage.css" rel="stylesheet" />
    <table style="width: 100%; height: 100%">
        <tr>
            <td style="width: 20%;">
                <div class="nonScrollable">
                    Hello   
                </div>
            </td>

            <td style="width: 80%;">
                <div class="productScroll">
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
                                <table class="productTable">
                                    <tr>
                                        <td>
                                            <!-- this should have href thing here by product name -->
                                            <span>
                                                <b><%#:Item.ProductName%>
                                            </span>
                                            <br />
                                        </td>
                                    </tr>
                                    <tr>

                                        <td>
                                            <!-- this should have href thing here by product name -->
                                            <image src='Images/<%#:Item.ImagePath%>' width="150" height="300" border="1" />
                                            <a href="<%#: GetRouteUrl("ProductsByCategoryRoute", new {categoryName = "Shirts"}) %>">click here
                                            </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <!-- this should have href thing here by product name -->
                                            <br />
                                            <span>
                                                <b>Price: </b><%#:String.Format("{0:c}", Item.UnitPrice)%>
                                            </span>
                                            <br />

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                                </p>
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
                        </LayoutTemplate>
                    </asp:ListView>
                </div>
            </td>
        </tr>
    </table>


</asp:Content>
