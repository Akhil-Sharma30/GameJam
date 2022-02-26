using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public GameObject end;
    private void OnTriggerEnter(Collider colliderinfo)
    {
        if (colliderinfo.tag == "finishLine")
        {
            Debug.Log("finshed the game");
            end.gameObject.SetActive(true);
        }
    }
}
