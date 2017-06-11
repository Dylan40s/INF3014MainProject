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
                        <img src="../Images/<%#:Item.ImagePath %>" style="border: solid; width: 200px; height: 300px" alt="~/Images/<%#:Item.ImagePath %>"  />
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
                        <a
href="/AddToCart.aspx?productID=<%#:Item.ProductID %>">
                            <span class="ProductListItem">
                                 <b>Add To Cart<b>
                            </span>
                        </a>
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
                    <td runat="server" id="helpTD">
                        <div class="helpContainer">
                            <button class="helpBtn">Help</button>
                            <div class="helpContainer-content" >

                                <asp:Label runat="server" Text="" ID="helpText"></asp:Label>
                                <br />
                                <asp:Image runat="server" ImageUrl="wrong" ID="helpImage" OnLoad="<%#helpImageSelect(Item.CategoryID ?? default(int))%>" /> 

                            
                            </div>
                        </div>
                        <br />

                        <asp:Button ID="submit" runat="server" Text="Add to cart" OnClick="addToCart" CausesValidation="true" />

                    </td>
                    

                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
    <script type="text/javascript">
      
    </script>
</asp:Content>
