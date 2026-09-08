InventoryItem Item = new InventoryItem();

Item.ProductCode = "MTG001";
Item.ProductName = "Bob";
Item.ProductQuantity = 1;
Item.ProductPrice = 1.00m; //using m with decimal for strict dollar amount needed in space

Console.WriteLine(Item.ProductName);
