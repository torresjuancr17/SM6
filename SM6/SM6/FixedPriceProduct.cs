namespace SM6
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return (Price * (decimal)Tax) + Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\tPrice.......:{$"{Price:C2}",30}" +
                $"\n\tTax.........:{$"{Tax:P2}",30}\n\tValue.......:{$"{ValueToPay():C2}",30}";
        }
    }
}
