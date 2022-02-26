using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2completed : MonoBehaviour
{
    public GameObject stage2;
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(4f);
        Destroy(stage2);
    }


    
    private void OnTriggerEnter(Collider stage)
    {
        if (stage.tag == "stage2")
        {
            Debug.Log("stage2 completed");
            stage2.gameObject.SetActive(true);
            StartCoroutine(SelfDestruct());

        }


    }
}
