using UnityEngine;
using TMPro;

public class LevelsOfFat : MonoBehaviour
{
    [SerializeField] private FatIndicatorValue _fatvalue;
    [SerializeField] private TextMeshPro _showLevelOfFat;

    private void Update()
    {
        if (_fatvalue._fatValue > 0.94f)
        {
            _showLevelOfFat.text = "Fat";
        }
        else if (_fatvalue._fatValue < 0.5f && _fatvalue._fatValue > 0.23f)
        {
            _showLevelOfFat.text = "Normal";
        }
        else if (_fatvalue._fatValue < 0.23f && _fatvalue._fatValue > 0.01218192f)
        {
            _showLevelOfFat.text = "Skinny";
        }
        else if (_fatvalue._fatValue <= 0.01218192f)
        {
            _showLevelOfFat.text = "Very Skinny";
        }
    }
}
