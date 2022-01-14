using UnityEngine;

public class GameInstaller : MonoBehaviour
{
    [Header("Ship")]
    [SerializeField] private ShipView shipView;
    [SerializeField] private ShipController shipController;

    private void Awake()
    {
        ShipInstall();
    }

    private void ShipInstall()
    {
        //ViewModel
        var shipViewModel = new ShipViewModel();
        shipView.SetModel(shipViewModel);

        //Presenter
        var shipPresenter = new ShipPresenter(shipViewModel);

        //Use Case
        var toggleVisibilityUseCase = new ToggleShipVisibility(shipPresenter);

        //Controller
        shipController.Configure(toggleVisibilityUseCase);
    }
}