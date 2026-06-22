using UnityEngine;

public class Model
{
    public int Level { get; private set; }
    public int Coins { get; private set; }
    public double UpgradeCost { get; private set; }
    
    private const double E = 2.71828;

    public Model(int startLevel = 1, int startCoins = 0, int upgradeCost = 1)
    {
        Level = startLevel;
        Coins = startCoins;
        UpgradeCost = upgradeCost;
    }

    public void AddCoin() => Coins += Level;

    public void AddLevel()
    {
        Level++;
        UpdateCost();
    }
    
    private void UpdateCost()
    {
        Coins -= (int) UpgradeCost;
        UpgradeCost = Mathf.Exp(Level);
    }
}
