namespace SM6
{
    public class Invoice : IPay

    {
        List<Product> _products = new List<Product>();

        public Invoice()
        {

        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal acumu = 0;

            foreach (Product product in _products)
            {
                acumu += product.ValueToPay();
            }
            return acumu;
        }

        public override string ToString()
        {
            string listP = ("");

            foreach (Product product in _products)
            {
                listP += product.ToString() + "\n";
            }
            Console.WriteLine(" RECEIPT");
            Console.WriteLine(" -------------------------------------------------");
            return $"{listP}\n\t=================================================" +
                $"\n\tTOTAL.........:\t{$"{ValueToPay():c2}",30}";
        }
    }
}
