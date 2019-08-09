using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuRe : MonoBehaviour
{
    public void PlayGame()
    {
        //Este codigo hace que al precionar el boton, me cargue el nivel que este a -4 de la escena Final.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
