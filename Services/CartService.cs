using artesania.Database;
using artesania.DTOs;
using artesania.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace artesania.Services;

public class CartService
{
    private readonly ArtesaniaContext _context;
    private readonly IMapper _mapper;

    public CartService(ArtesaniaContext context, IMapper mapper)
    {
        _context = context;
        this._mapper = mapper;
    }

    public List<ShoppingCartDto> Cart { get; set; } = new();

    public void AddToCart(ProductDto product)
    {
        var productInCart = Cart.FirstOrDefault(x => x.Product.Name == product.Name);
        if (productInCart != null)
        {
            productInCart.Quantity++;
        }
        else
        {
            Cart.Add(new ShoppingCartDto { Product = product, Quantity = 1 });
        }
    }

    public void RemoveFromCart(ProductDto product)
    {
        var productInCart = Cart.FirstOrDefault(x => x.Product.Name == product.Name);
        if (productInCart == null) return;

        if (productInCart.Quantity > 1)
        {
            productInCart.Quantity--;
        }
        else
        {
            Cart.Remove(productInCart);
        }
    }

    public void ClearCart()
    {
        Cart.Clear();
    }

    public async Task MakePurchase(Customer customer)
    {
        var productos = _context.Products.AsNoTracking();
            // Products = Cart.Select(_mapper.Map<ShoppingCartDto, ShoppingCart>).ToList(),
        var purchase = new Purchase
        {
            Customer = customer,
            Products = Cart.Select(x => new ShoppingCart(){
                ProductId = productos.First(p => p.Name == x.Product.Name).Id,
                Quantity = x.Quantity
            }).ToList(),
            PurchaseDate = DateTime.Now
        };

        await _context.Purchases.AddAsync(purchase);
        await _context.SaveChangesAsync();
    }
}