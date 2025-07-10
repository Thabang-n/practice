namespace builderPatternPractice
{
    public partial class Product
    {
        public class ProductBuilder
        {
            private readonly Product _product = new Product();
            public ProductBuilder SetName(string name)
            {
                this._product._name = name;
                return this;
            }

            public ProductBuilder SetPrice(double price)
            {
                this._product._price = price;
                return this;
            }

            public Product Build()
            {
                return _product;
            }
        }  
    }
}
