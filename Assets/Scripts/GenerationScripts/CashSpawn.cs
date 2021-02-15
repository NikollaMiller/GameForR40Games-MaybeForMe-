using UnityEngine;

public class CashSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] CashPrefabs;
    [SerializeField] private Transform _CashSpawnPos;

    private int numberOfCash;

    private void Start()
    {
        numberOfCash = Random.Range(0, 6);
        for (int i = 0; i < CashPrefabs.Length; i++)
        {
            if (numberOfCash == i)
            {
                var cell = Instantiate(CashPrefabs[i], _CashSpawnPos);
                cell.transform.localPosition = new Vector3(cell.transform.localPosition.x, cell.transform.localPosition.y, cell.transform.localPosition.z);
            }
        }
    }
}
