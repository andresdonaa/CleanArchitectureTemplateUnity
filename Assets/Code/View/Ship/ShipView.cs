using UniRx;
using UnityEngine;

public class ShipView : ViewBase
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    private ShipViewModel shipViewModel;

    public void SetModel(ShipViewModel shipViewModel)
    {
        this.shipViewModel = shipViewModel;

        this.shipViewModel
            .IsVisible
            .Subscribe(ToggleVisibility)
            .AddTo(_disposables);
    }

    private void ToggleVisibility(bool isVisible)
    {
        spriteRenderer.enabled = isVisible;
    }
}