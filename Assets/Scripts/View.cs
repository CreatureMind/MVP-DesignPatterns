using System;
using UnityEngine;
using UnityEngine.UIElements;

public class View : MonoBehaviour
{
    public event Action AddCoinClicked;
    public event Action UpgradeClicked;
    
    private UIDocument _document;
    private VisualElement _root;
    
    private Button _addCoinButton;
    private Button _upgradeButton;
    
    private TextField _levelText;
    private TextField _coinsText;
    private TextField _upgradeCostText;
    
    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        
        InitializeUI(_document);
    }

    private void OnEnable()
    {
        _addCoinButton.clicked += OnAddCoinButtonClicked;
        _upgradeButton.clicked += OnUpgradeButtonClicked;
    }

    private void OnDestroy()
    {
        _addCoinButton.clicked -= OnAddCoinButtonClicked;
        _upgradeButton.clicked -= OnUpgradeButtonClicked;
    }

    private void InitializeUI(UIDocument document)
    {
        _root = document.rootVisualElement;
        
        _addCoinButton = _root.Q<Button>(UI_PlayerStats.AddCoin);
        _upgradeButton = _root.Q<Button>(UI_PlayerStats.Upgrade);
        
        _levelText = _root.Q<TextField>(UI_PlayerStats.Level);
        _coinsText = _root.Q<TextField>(UI_PlayerStats.Coins);
        _upgradeCostText = _root.Q<TextField>(UI_PlayerStats.UpgradeCost);
    }

    private void OnAddCoinButtonClicked()
    {
        AddCoinClicked?.Invoke();
    }

    private void OnUpgradeButtonClicked()
    {
        UpgradeClicked?.Invoke();
    }

    public void SetLevelText(int level)
    {
        _levelText.value = level.ToString();
    }
    
    public void SetCoinText(int coins)
    {
        _coinsText.value = coins.ToString();
    }
    
    public void SetUpgradeCostText(double cost)
    {
        _upgradeCostText.value = cost.ToString("0.0000");
    }
}
