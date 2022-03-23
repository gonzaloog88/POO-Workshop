namespace POO_Workshop
{
    public class Invoice : IPay
    {
        private ICollection<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public decimal ValueToPay()
        {
            decimal valueToPay = 0M;
            foreach(Product product in _products)
            {
                valueToPay += product.ValueToPay();
            }
            return valueToPay;
        }
        public override string ToString()
        {
            string products = string.Empty;
            foreach (Product product in _products)
            {
                products += product.ToString()+"\n";
            }
            return $"RECEIPT" +
                $"\n---------------------------------------------" +
                $"\n{products}" +
                $"                        ====================="+
                $"\nTOTAL                    {$"{ValueToPay():C2}",20}";
        }
    }
}
