using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    [SerializeField] private GameObject[] FoodsPrefabs;
    [SerializeField] private Transform _foodSpawnPos;

    private int numberOfFood;

    private void Start()
    {
        numberOfFood = Random.Range(0, 8);
        for (int i = 0; i < FoodsPrefabs.Length; i++)
        {
            if (numberOfFood == i)
            {
                var cell = Instantiate(FoodsPrefabs[i], _foodSpawnPos);
                cell.transform.localPosition = new Vector3(cell.transform.localPosition.x, cell.transform.localPosition.y, cell.transform.localPosition.z);
            }
        }
    }
}
