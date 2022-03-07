namespace SM6

{
    class VariablePriceProduct : Product
    {
        public override decimal ValueToPay()
        {

            return Price * (decimal)Quantity + (Price * (decimal)Quantity * (decimal)Tax);
        }

        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override string ToString()
        {
            return $"{ base.ToString()}\n\t" +
                $"Measurement.:{$"{Measurement}",5}\n\tQuantity....:{$"{Quantity:N2}",30}\n\t" +
                $"Price.......:{$"{Price:C2}",30}\n\tTax.........:{ $"{Tax:P2}",30}\n\t" +
                $"Value.......:{ $"{ValueToPay():C2}",30}";

        }
    }
}