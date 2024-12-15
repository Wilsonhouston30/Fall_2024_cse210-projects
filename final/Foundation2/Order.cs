public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double CalculateTotal()
    {
        double totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5 : 35;

        return totalProductCost + shippingCost;
    }

    public string GetPackLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel.TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetName()}\n{_customer.GetAddress()}";
    }
}
