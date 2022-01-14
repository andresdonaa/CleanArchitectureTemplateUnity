using UnityEngine;

public class ShipController : MonoBehaviour
{
    private ToggleShipVisibility toggleVisibilityUseCase;

    public void Configure(ToggleShipVisibility toggleVisibilityUseCase)
    {
        this.toggleVisibilityUseCase = toggleVisibilityUseCase;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) //for demo purpose
            toggleVisibilityUseCase.ToggleVisibility();
    }
}