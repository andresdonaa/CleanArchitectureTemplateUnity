public class ToggleShipVisibility : IToggleVisibility
{
    private readonly IToggleShipVisibilityOutputBoundary toggleShipVisibilityOutputBoundary;

    public ToggleShipVisibility(IToggleShipVisibilityOutputBoundary toggleShipVisibilityOutputBoundary)
    {
        this.toggleShipVisibilityOutputBoundary = toggleShipVisibilityOutputBoundary;
    }

    public void ToggleVisibility() 
    {
        toggleShipVisibilityOutputBoundary.ToggleVisibility();
    }
}