public class InventoryItem //information containing product information
{
    public string productCode { get; set; }
    public string productName { get; set; }
    public int productQuantity { get; set; }
    public float price { get; set; } //only need a float for space in decimal
}