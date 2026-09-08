public class InventoryItem //information containing product information
{
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public int ProductQuantity { get; set; }
    public decimal ProductPrice { get; set; } //most precise type for managing dollar amount
}    