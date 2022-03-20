namespace POO_Workshop
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"{Id} {Description}" +
                $"\n\tPrice..........: {$"{Price:C2}",20}" +
                $"\n\tTax............: {$"{Tax:P2}",20}" +
                $"\n\tValue..........: {$"{ValueToPay():C2}",20}";
        }
    }
}
