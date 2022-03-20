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
    }
}
