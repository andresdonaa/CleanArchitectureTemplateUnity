public class ShipPresenter : IToggleShipVisibilityOutputBoundary
{
    private readonly ShipViewModel shipViewModel;

    public ShipPresenter(ShipViewModel shipViewModel)
    {
        this.shipViewModel = shipViewModel;
    }

    public void ToggleVisibility()
    {
        shipViewModel.IsVisible.Value = !shipViewModel.IsVisible.Value;
    }
}

