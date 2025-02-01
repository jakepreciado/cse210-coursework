public class Order 
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public int CalculateTotalCost()
    {
        int totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.getTotalCost();
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"{product.getProductName()} - {product.getQuantity()}\n";
        }
        return packingLabel.Trim();
    }

    public string GetShippingLabel()
    {
        return $"Shipping To: {_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
    }

}