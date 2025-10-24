namespace E_Commerce.Domain.Contracts;

public interface IBasketRepository
{
    Task<bool> DeleteAsync(string id)
}
