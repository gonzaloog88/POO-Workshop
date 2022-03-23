namespace POO_Workshop
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price * ((decimal)Tax + 1);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
