using UnityEngine;
using System;

public class Trigger : MonoBehaviour
{
    private FatIndicatorValue _fat;

    private bool _triggered;

    private void Start()
    {
        _fat = GameObject.FindGameObjectWithTag("Fat").GetComponent<FatIndicatorValue>();
    }

    private void Update()
    {
        if (transform.localScale.x < 0.42386f)
        {
            transform.localScale = new Vector3(0.42386f, 0.42386f, 0.42386f);
        }
        else if(transform.localScale.x > 1.5124f)
        {
            transform.localScale = new Vector3(1.5124f, 1.5124f, 1.5124f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            _fat._fatValue += 0.1f;
            transform.localScale = new Vector3(transform.localScale.x + 0.05f, transform.localScale.y + 0.05f, transform.localScale.z + 0.05f);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Cash")
        {
            CashSystem._cash += 1;
        }
    }
}
