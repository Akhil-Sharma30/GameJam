using UnityEngine;
using UnityEngine.SceneManagement;

public class collison : MonoBehaviour
{
    public GameObject wrongPathAnimation;

    private void OnTriggerEnter(Collider Colliderinfo)
    {
        if(Colliderinfo.tag=="wrongPath")
        {
            Debug.Log("collided");
            wrongPathAnimation.gameObject.SetActive(true);
            Invoke("restart", 3f);
            //wrongPathAnimation.SetActive(true);
            
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
