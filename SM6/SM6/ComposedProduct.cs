namespace SM6

{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal Acum = 0;

            foreach (Product product in Products)
            {
                Acum = Acum + product.ValueToPay();
            }
            return Acum - (Acum * (decimal)Discount);
        }


        public override string ToString()
        {
            string listP = null;

            foreach (Product product in Products)
            {
                listP += product.Description + ", ";
            };
            return $"{base.ToString()}\n\tProducts....:\t" +
                $"{listP}\n\tDiscount....:\t{$"{Discount:p2}",30}\n\t" +
                $"Value.......:\t{$"{ValueToPay():c2}",30}";
        }
    }
}