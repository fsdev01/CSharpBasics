#pragma checksum "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20b6ff13f9a506a27102fe12feca3e728d0a5320"
// <auto-generated/>
#pragma warning disable 1591
namespace ContosoCrafts.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
using ContosoCrafts.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
using ContosoCrafts.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 10 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                                                             product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 12 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                                     product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-footer");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "small");
            __builder.AddAttribute(25, "class", "text-muted");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                                  (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "data-toggle", "modal");
            __builder.AddAttribute(30, "data-target", "#productModal");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddMarkupContent(32, "\r\n                    More Info\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 25 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"




    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n\r\n");
#nullable restore
#line 33 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal fade");
            __builder.AddAttribute(41, "id", "productModal");
            __builder.AddAttribute(42, "tabindex", "-1");
            __builder.AddAttribute(43, "role", "dialog");
            __builder.AddAttribute(44, "aria-labelledby", "productTitle");
            __builder.AddAttribute(45, "aria-hidden", "true");
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(49, "role", "document");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal-content");
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-header");
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "h5");
            __builder.AddAttribute(58, "class", "modal-title");
            __builder.AddAttribute(59, "id", "productTitle");
            __builder.AddContent(60, 
#nullable restore
#line 39 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                                                               selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.AddMarkupContent(62, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-body");
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "card");
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "card-img");
            __builder.AddAttribute(72, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 46 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "card-body");
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "p");
            __builder.AddAttribute(79, "class", "card-text");
            __builder.AddContent(80, 
#nullable restore
#line 49 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                                                  selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "modal-footer");
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 54 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                        ");
            __builder.AddMarkupContent(89, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 57 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "                        ");
            __builder.OpenElement(91, "span");
            __builder.AddContent(92, 
#nullable restore
#line 60 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(93, " ");
            __builder.AddContent(94, 
#nullable restore
#line 60 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                                          voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 61 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, "\r\n                    \r\n");
#nullable restore
#line 64 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                     for (int i = 1; i < 6; i++)
                    {
                        var currentStar = i;
                        if (i <= currentRating)
                        {
                            // highlight (checked) star i

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                            ");
            __builder.OpenElement(98, "span");
            __builder.AddAttribute(99, "class", "fa fa-star checked");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                                                                       (e=> SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 71 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                        }
                        else
                        {
                            // don't highligh star (not checked)

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                            ");
            __builder.OpenElement(103, "span");
            __builder.AddAttribute(104, "class", "fa fa-star");
            __builder.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                                                               (e=> SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 76 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
#nullable restore
#line 83 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "/Users/user/Projects/ContosoCrafts/ContosoCrafts/Components/ProductList.razor"
       
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
        // Data Binding
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating(); // Get current rating when user select the product
    }

    int currentRating = 0; // initalise rating to 0 (rounded integer)
    int voteCount = 0; // count # of votes
    string voteLabel; // display vote string (e.g. 1 vote or 2 votes)

    // Get current rating (average) from JSON file
    void GetCurrentRating()
    {
        // If rating is currently null
        if (selectedProduct.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        // If rating has an array
        else
        {
            // Count number of votes in the array
            voteCount = selectedProduct.Ratings.Count();

            // Generate label/string for # of votes
            // 1 vote (singular) or 2,3,4,5... votes plural
            voteLabel = voteCount > 1 ? "Votes" : "Vote";

            // current rating
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for {selectedProduct.Id}: {currentRating}");
    }

    // Update the current rating in the JSON file
    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectedProduct.Id} : {rating}");
        // Use Product Service to update the rating in JSON file (don't need to serialize manually)
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId); 
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591