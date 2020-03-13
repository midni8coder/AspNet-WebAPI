function GetAllProducts(productID) {
    var completeUrl = "https://localhost:44355/api/Product/GetAllProducts";
    if (productID)
        completeUrl = "https://localhost:44355/api/Product/GetProductDetail?productID=" + productID
    $.ajax({
        type: "get",
        url: completeUrl,
        dataType: "json",
        contentType: "application/json;",
        success: function (response) {
            console.log(response);
        }
    });
}