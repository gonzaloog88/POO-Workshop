namespace POO_Workshop
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal valueToPay = 0;
            foreach (Product product in Products)
            {
                valueToPay += product.ValueToPay();
            }
            return valueToPay - (valueToPay * (decimal)Discount);
        }
        public override string ToString()
        {
            string products = string.Empty;
            foreach (Product product in Products)
            {
                products += product.Description + ", ";
            }
            products = products.Remove(products.Length - 2, 2);
            return $"{Id} {Description}" +
                $"\n\tProducts.......: {$"{products}",20}" +
                $"\n\tDiscount.......: {$"{Discount:P2}",20}" +
                $"\n\tValue..........: {$"{ValueToPay():C2}",20}";
        }
    }
}
