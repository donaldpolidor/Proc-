public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // Frais d'expédition
        totalCost += customer.IsInUSA() ? 5.0 : 35.0;

        return totalCost;
    }

    public string GetPackagingLabel()
    {
        string label = "Packaging Label:\n";
        foreach (Product product in products)
        {
            label += product.GetPackagingLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}
