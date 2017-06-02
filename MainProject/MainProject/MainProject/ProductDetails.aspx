<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="MainProject.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/detailPage.css" rel="stylesheet" />
    <asp:FormView ID="productDetail" runat="server" ItemType="MainProject.Models.Product" SelectMethod="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ProductName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="../Images/<%#:Item.ImagePath %>" style="border: solid; width: 200px; height: 300px" alt="~/Images/<%#:Item.ImagePath %>" />
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align: left;">
                        <b>Description:</b><br />
                        <%#:Item.Description %>
                        <br />
                        <span>
                            <b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %>
                        </span>
                        <br />
                        <span>
                            <b>Product Number:</b>&nbsp;<%#:Item.ProductID %>
                        </span>
                        <br />
                        <span>
                            <p>
                                Quantity
                            </p>
                            <asp:TextBox ID="productQuantity" runat="server">1</asp:TextBox>
                        </span>
                        <br />
                        <span>
                            <asp:FileUpload ID="ProductImage" runat="server" />
                        </span>
                        <br />
                        <span>

                            <asp:Button ID="AddImageButton" runat="server" Text="Add image" OnClick="addImage_click" CausesValidation="true" />
                        </span>
                        <br />
                        <br />
                        <asp:Image ImageUrl="placeholder" ID="imagePlaceHolder" runat="server" Style="height: 150px; width: 150px;" AlternateText="No image selected" />
                    </td>
                    <td>
                        <div class="helpContainer">
                            <button class="helpBtn">Help</button>
                            <div class="helpContainer-content">
                                <table>
                                    <tr>
                                        <td>
                                            <h4>Clothing examples</h4>
                                            <img src="Images/ClothsExample.png" alt="Clothing example" class="exampleImages" />
                                        </td>
                                        <td>
                                            <h4>Homeware examples</h4>
                                            <img src="Images/HomewareExample.png" alt="Clothing example" class="exampleImages"  />
                                        </td>
                                       
                                    </tr>
                                    <tr>
                                         <td>
                                            <h4>Stationery examples</h4>
                                            <img src="Images/StationeryExample.png" alt="Clothing example" class="exampleImages" />
                                        </td>
                                        <td>
                                            <h4>General examples</h4>
                                            <img src="Images/GeneralExample.png" alt="Clothing example" class="exampleImages" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                        <br />

                        <asp:Button ID="submit" runat="server" Text="Add to cart" OnClick="addToCart" CausesValidation="true" />

                    </td>
                    

                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
