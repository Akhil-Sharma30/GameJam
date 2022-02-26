using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2complete : MonoBehaviour
{
    public GameObject stage2;

    IEnumerator destroyAI()
    {
        yield return new WaitForSeconds(4f);
        Destroy(stage2);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "stage2")
        {
            Debug.Log("stage 2 completed");
            stage2.SetActive(true);
            StartCoroutine(destroyAI());
        }
    }
}
