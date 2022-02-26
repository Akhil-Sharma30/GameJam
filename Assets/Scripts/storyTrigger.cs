using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storyTrigger : MonoBehaviour
{
    public GameObject story;
   
    void Update()
    {
        if (Input.GetKey("r"))
        {
            Debug.Log("showing story");
            story.SetActive(true);
        }
    }
}
