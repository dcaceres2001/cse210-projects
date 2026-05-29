using System;
using System.Collections.Generic;

namespace OnlineOrdering;


public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Dynamic Shipping Charge Logic ($5.00 if US, $35.00 if International)
    public double CalculateShippingCost()
    {
        return _customer.IsUs() ? 5.00 : 35.00;
    }

    public double CalculateTotalCost()
    {
        double total = CalculateShippingCost();
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "----- PACKING LABEL -----\n";
        foreach (var product in _products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "----- SHIPPING LABEL -----\n";
        label += $"Customer Name: {_customer.GetName()}\n";
        label += $"Address:\n{_customer.GetAddress().GetFullAddress()}\n";
        return label;
    }
}