using UniRx;

public class ShipViewModel
{
    public readonly ReactiveProperty<bool> IsVisible;

    public ShipViewModel()
    {
        IsVisible = new BoolReactiveProperty(true);
    }
}