using PizzaPlace.Shared;
namespace PizzaPlace.Client.Shared
{
    public interface IOrderService
    {
        ValueTask PlaceOrder(ShoppingBasket basket);
    }
}
