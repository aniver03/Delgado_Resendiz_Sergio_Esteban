using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeFinal : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //Codigo utilizado para al tocar la puerta, o registrar el triger entre mi objeto con el tag player y la puerta, el jugador gane automaticamente el juego.
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Final");
        }
    }
}