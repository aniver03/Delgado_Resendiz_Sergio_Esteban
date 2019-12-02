using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuprincipal : MonoBehaviour
{

    public void PlayGame()
    {
        //Al precionar el boton me dirigira hacia la escena siguiente que es la numero 1, ya que el menu es el 0.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        //Al precionar el boton quitara automaticamente el juego.
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void PlayGame2()
    {
        //Este codigo hace que al precionar el boton, me cargue el nivel que este a -4 de la escena Final.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

}
