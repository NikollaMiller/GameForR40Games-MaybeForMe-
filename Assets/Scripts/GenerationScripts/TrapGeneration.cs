using UnityEngine;

public class TrapGeneration : MonoBehaviour
{
    [SerializeField] private GameObject[] Traps;
    [SerializeField] private Transform _trapSpawnPos;

    private int numberOftrap;

    private void Start()
    {
        numberOftrap = Random.Range(0,5);
        for (int i = 0; i < Traps.Length; i++)
        {
            if (numberOftrap == i)
            {
                var cell = Instantiate(Traps[i], _trapSpawnPos);
                cell.transform.localPosition = new Vector3(cell.transform.localPosition.x, cell.transform.localPosition.y, cell.transform.localPosition.z);
            }
        }
    }
}
