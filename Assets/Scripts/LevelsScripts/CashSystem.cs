using UnityEngine;

public class CashSystem : MonoBehaviour
{
    public static int _cash;

    private void Start()
    {
        _cash = PlayerPrefs.GetInt("Cash",_cash);
    }

    private void Update()
    {
        PlayerPrefs.SetInt("Cash", _cash);
    }
}
