using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private AudioSource _poshSound;
    [SerializeField] private GameObject FinishPanel;

    private FatIndicatorValue _fat;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void Start()
    {
        _fat = GameObject.FindGameObjectWithTag("Fat").GetComponent<FatIndicatorValue>();
    }

    private void Update()
    {
        switch (transform.localScale.x < 0.42386f)
        {
            case true:
                transform.localScale = new Vector3(0.42386f, 0.42386f, 0.42386f);
                break;
            default:
            {
                switch (transform.localScale.x > 1.4149f)
                {
                    case true:
                        transform.localScale = new Vector3(1.4149f, 1.4149f, 1.4149f);
                        break;
                }

                break;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
                _fat._fatValue += 0.1f;
                transform.localScale = new Vector3(transform.localScale.x + 0.05f, transform.localScale.y + 0.05f, transform.localScale.z + 0.05f);
                Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Cash")
        {
                CashSystem._cash += 1;
                Destroy(other.gameObject);
        }

         if (other.tag == "Finished")
        {
                FinishPanel.SetActive(true);
                Time.timeScale = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FinishPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
