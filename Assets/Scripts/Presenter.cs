using UnityEngine;

public class Presenter
{
    private readonly Model _model;
    private readonly View _view;

    public Presenter(Model model, View view)
    {
        _model = model;
        _view = view;
        _view.AddCoinClicked += OnAddCoinClicked;
        _view.UpgradeClicked += OnUpgradeClicked;
        UpdateView();
    }

    private void OnAddCoinClicked()
    {
        _model.AddCoin();
        UpdateView();
    }
    
    private void OnUpgradeClicked()
    {
        if (_model.Coins < _model.UpgradeCost)
            return;
        
        _model.AddLevel();
        UpdateView();
    }

    private void UpdateView()
    {
        _view.SetLevelText(_model.Level);
        _view.SetCoinText(_model.Coins);
        _view.SetUpgradeCostText(_model.UpgradeCost);
    }

    public void Dispose()
    {
        _view.AddCoinClicked -= OnAddCoinClicked;
        _view.UpgradeClicked -= OnUpgradeClicked;
    }
}
