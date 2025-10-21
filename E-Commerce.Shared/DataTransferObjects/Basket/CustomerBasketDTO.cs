namespace E_Commerce.Shared.DataTransferObjects.Basket;

public class CustomerBasketDTO
{
    public string Id { get; set; }
    public ICollection<BasketItemDTO> MyProperty { get; set; }
}
public class BasketItemDTO
{
#nullable disable
    public int Id { get; set; }
    public string Name { get; init; }
    public string Description { get; init; }
    public string PictureUrl { get; init; }
    public decimal Price { get; init; }
    public int Quantity { get; set; }
}