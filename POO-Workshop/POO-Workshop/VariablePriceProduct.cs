namespace POO_Workshop
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return ((decimal)Quantity * Price) * ((decimal)Tax + 1);
        }
        public override string ToString()
        {
            return $"{Id} {Description}" +
                $"\n\tMeasurement....: {$"{Measurement}",20}" +
                $"\n\tQuantity.......: {$"{Quantity:N2}",20}" +
                $"\n\tPrice..........: {$"{Price:C2}",20}" +
                $"\n\tTax............: {$"{Tax:P2}",20}" +
                $"\n\tValue..........: {$"{ValueToPay():C2}",20}";
        }
    }
}
