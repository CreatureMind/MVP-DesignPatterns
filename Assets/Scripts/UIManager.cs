using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private View _view;
    
    private Presenter _presenter;

    private void Start()
    {
        var model = new Model(startCoins: 1000, startLevel: 1, upgradeCost: 1);
        _presenter = new Presenter(model, _view);
    }

    private void OnDestroy()
    {
        _presenter?.Dispose();
    }
}