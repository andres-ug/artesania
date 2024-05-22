using artesania.DTOs;
using artesania.Services;

namespace artesania.Components.Pages;

public partial class Home
{
    protected override void OnInitialized()
    {
        cartService.ClearCart();
    }
}