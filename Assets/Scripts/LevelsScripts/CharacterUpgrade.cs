using UnityEngine;
using UnityEngine.UI;

public class CharacterUpgrade : MonoBehaviour
{
    [SerializeField] private Text _upgradeCount;

    private int _upgradeValue = 5;

    private void Start()
    {
        _upgradeValue = PlayerPrefs.GetInt("upgradeVal", _upgradeValue);
    }

    private void Update()
    {
        _upgradeCount.text = $"{_upgradeValue}";
        PlayerPrefs.SetInt("upgradeVal",_upgradeValue);
    }

    public void ClickToUpgrade() 
    {
        _upgradeValue *= 2;
        if (CashSystem._cash >= _upgradeValue)
        {
            CashSystem._cash -= _upgradeValue;
        }
    }
}
