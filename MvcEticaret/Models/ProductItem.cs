namespace MvcEticaret.Models
{
    public class ProductItem
    {public string title { get; set; }
        public int startCount { get; set; }
        public int oldPrice { get; set; }

        public int price { get; set; }
        public string imageUrl { get; set; }
        public int isSale { get; set; }

        public static List<ProductItem> ProductItems = new List<ProductItem>();

        ProductItems.Add(new ProductItem()
        {
            title = "title";
            startCount = 200;
            oldPrice = 300;
            price = 500;
            imageUrl = string.Empty;
            isSale = 250;
            
        }
    }
}
