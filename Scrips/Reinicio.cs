using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //Codigo utilizado para que al registrarse el choque entre el player y el objeto, automaticamente me reinicie el nivel 3. 
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Nivel3");
        }
    }
}
