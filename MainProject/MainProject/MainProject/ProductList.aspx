<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="MainProject.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/ProductPage.css" rel="stylesheet" />    
    <div>
        <hgroup>
            <h3>Products</h3>
        </hgroup>
        <br />
    </div>
    <div class="tableDiv">
        <table style="width:100%;">
            <tr>
                <td class="products" style="padding-right:40px">
                    <img src="/Images/shirtTemp.jpg" alt="shirtTemp.jpg" style="width:100%; height:150px" />
                    <br />
                    <p>View shirt designs</p>
                    <button class="productButton1 productButton" style="vertical-align:middle">View</button>
                </td>
                <td  class="products" style="padding-right:40px">
                    <img src="/Images/shirtTemp.jpg" alt="shirtTemp.jpg" style="width:100%; height:150px" />
                    <p>View home designs</p>
                    <button class="productButton1 productButton" style="vertical-align:middle">View</button>
                </td>
                <td class="products" style="padding-right:40px">
                    <img src="/Images/shirtTemp.jpg" alt="shirtTemp.jpg" style="width:100%; height:150px" />
                    <p>View stationary designs</p>
                    <button class="productButton1 productButton" style="vertical-align:middle">View</button>
                </td>
            </tr>

            <tr style="padding-top:20px">
                <td class="products" style="padding-right:40px">
                    <img src="/Images/shirtTemp.jpg" alt="shirtTemp.jpg" style="width:100%; height:150px" />
                    <br />
                    <p>View shirt designs</p>
                    <button class="productButton1 productButton" style="vertical-align:middle">View</button>
                </td>
                <td class="products" style="padding-right:40px">
                    <img src="/Images/shirtTemp.jpg" alt="shirtTemp.jpg" style="width:100%; height:150px" />
                    <p>View home designs</p>
                    <button class="productButton1 productButton" style="vertical-align:middle">View</button>
                </td>
                <td class="products" style="padding-right:40px">
                    <img src="/Images/shirtTemp.jpg" alt="shirtTemp.jpg" style="width:100%; height:150px" />
                    <p>View stationary designs</p>
                    <button class="productButton1 productButton" style="vertical-align:middle">View</button>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
