using UnityEngine;

public class RoadGeneration : MonoBehaviour
{
    [SerializeField] private GameObject[] Roads;
    [SerializeField] private Transform _roadsSpawnPos;

    private int numberOfRoad;

    private void Start()
    {
        numberOfRoad = Random.Range(0, 2);
        for (int i = 0; i < Roads.Length; i++)
        {
            if (numberOfRoad == i)
            {
                var cell = Instantiate(Roads[i], _roadsSpawnPos);
                cell.transform.localPosition = new Vector3(cell.transform.localPosition.x, cell.transform.localPosition.y, cell.transform.localPosition.z);
            }
        }
    }
}
