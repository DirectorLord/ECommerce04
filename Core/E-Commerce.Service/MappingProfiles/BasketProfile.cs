﻿using E_Commerce.Domain.Entities.Basket;
using E_Commerce.Shared.DataTransferObjects.Basket;

namespace E_Commerce.Service.MappingProfiles;

internal class BasketProfile : Profile
{
    public BasketProfile()
    {
        CreateMap<BasketItem, BasketItemDTO>().ReverseMap();

        CreateMap<CustomerBasket, CustomerBasketDTO>().ReverseMap();
    }
}
