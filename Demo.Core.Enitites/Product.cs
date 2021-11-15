namespace Demo.Core.Enitites
{
    public class Product
    {

        public int ProdutcId { get; set; }
        public string Name { get; set; }

        public Store Store { get; set; }

        public bool ProductType { get; set; }

    }
}
