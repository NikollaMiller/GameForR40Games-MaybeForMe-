using UnityEngine;
using UnityEngine.UI;

public class CashSystem : MonoBehaviour
{
    public static int _cash;
    [SerializeField] private Text _cashValueDisplay;

    private void Start()
    {
        _cash = PlayerPrefs.GetInt("Cadsh",_cash);
    }

    private void Update()
    {
        _cashValueDisplay.text = $"balance:{_cash}";
        PlayerPrefs.SetInt("Cadsh", _cash);
    }
}
