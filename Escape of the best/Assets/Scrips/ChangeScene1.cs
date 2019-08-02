using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //add the  u chose here 
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Nivel2");
        }
    }
}
