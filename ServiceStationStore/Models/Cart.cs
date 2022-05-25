namespace ServiceStationStore.Models
{
    public class Cart
    {
        private readonly List<CartLine> lineCollection = new();
        public virtual void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection.Where(p => p.Product.ProductId == product.ProductId).FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new CartLine { Product = product, QuantityCart = quantity });
            }
            else
            {
                line.QuantityCart += quantity;
            }
        }
        public virtual void RemoveLine(Product product) => lineCollection.RemoveAll(l => l.Product.ProductId == product.ProductId);
        public virtual decimal ComputeTotalValue() => (decimal)lineCollection.Sum(e => e.Product.Price * e.QuantityCart);
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int QuantityCart { get; set; }
    }
}
