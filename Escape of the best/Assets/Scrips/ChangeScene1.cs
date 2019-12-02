using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //Si al colicionar mi player con un objeto que tenga el Tag Puerta0 entonces me cargara el la escena que lleve por nombre Nivel1. 
        if (other.gameObject.tag == "Puerta0")
        {
            SceneManager.LoadScene("Nivel1");
        }
        //Si al colicionar mi player con un objeto que tenga el Tag Puerta1 entonces me cargara el la escena que lleve por nombre Nivel2. 
        else if (other.gameObject.tag == "Puerta1")
        {
            SceneManager.LoadScene("Nivel2");
        }
        //Si al colicionar mi player con un objeto que tenga el Tag Puerta2 entonces me cargara el la escena que lleve por nombre Nivel3. 
        else if (other.gameObject.tag == "Puerta2")
        {
            SceneManager.LoadScene("Nivel3");
        }
        //Si al colicionar mi player con un objeto que tenga el Tag Puerta3 entonces me cargara el la escena que lleve por nombre Final. 
        else if (other.gameObject.tag == "Puerta3")
        {
            SceneManager.LoadScene("Final");
        }
        
    }
}
