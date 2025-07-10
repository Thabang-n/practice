

using builderPatternPractice;

var product = new Product.ProductBuilder()
    .SetName("keyboard")
    .SetPrice(2000.00)
    .Build();

Console.WriteLine(product._name,product._price);