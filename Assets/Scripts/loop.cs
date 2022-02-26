using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loop : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "notReal")
        {
            Debug.Log("not real part seen");
            Invoke("notRealDoor", 2f);
            
        }
    }

    void notRealDoor()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
