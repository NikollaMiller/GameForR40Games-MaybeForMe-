using UnityEngine;
using UnityEngine.UI;

public class CharacterUpgrade : MonoBehaviour
{
    public static float pushStrength;
    [SerializeField] private Text _upgradeCount;

    private int _upgradeValue = 5;

    private void Start()
    {
        _upgradeValue = PlayerPrefs.GetInt("upgradePrice", _upgradeValue);
        pushStrength = PlayerPrefs.GetFloat("pushVal", pushStrength);
    }

    private void Update()
    {
        if (pushStrength <= 0)
        {
            pushStrength = 0.1f;
        }
        print(pushStrength);
        _upgradeCount.text = $"{_upgradeValue}";
        PlayerPrefs.SetInt("upgradePrice", _upgradeValue);
        PlayerPrefs.SetFloat("pushVal", pushStrength);
    }

    public void ClickToUpgrade()
    {
        _upgradeValue *= 2;
        if (CashSystem._cash >= _upgradeValue)
        {
            pushStrength += 0.1f;
            CashSystem._cash -= _upgradeValue;
        }
    }
}
