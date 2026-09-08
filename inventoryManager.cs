public class InventoryManager
{
    private List<InventoryItem> Items = new List<InventoryItem>;

    public void AddItem(InventoryItem Item)
    {
        Items.add(Item);
    }

    public void RemoveItem(string ProductCode)
    {
        InventoryItem Item = Items.Find(x => x.ProductCode == ProductCode);

        if (Item != null)
        {
            Items.Remove(Item);
        }
        else
        {
            throw new InvalidOperationException("Invalid Product Code");
        }
    }

    public InventoryItem FindItem(string ProductCode)
    {
        return Items.Find(x => x.ProductCode == ProductCode);
    }

    public List<InventoryItem> GetAllItems()
    {
        return items;
    }
}