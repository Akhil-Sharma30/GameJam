using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject wrongPathchosen;
    public void wrongPath()
    {
        wrongPathchosen.SetActive(true);
    }

}
