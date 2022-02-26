using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1complete : MonoBehaviour
{
    public GameObject stage1;
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(4f);
        Destroy(stage1);
    }

    private void OnTriggerEnter(Collider stage)
    {
        if (stage.tag == "stage1")
        {
            Debug.Log("stage1 completed");
            stage1.SetActive(true);
            StartCoroutine(SelfDestruct());
            
        }
        
        
    }
}
