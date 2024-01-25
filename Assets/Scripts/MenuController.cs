using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadNivel1(){
        SceneManager.LoadScene("Nivel1");
    }

    public void LoadSinopsis(){
        SceneManager.LoadScene("Sinopsis");
    }
    public void LoadReglas(){
        SceneManager.LoadScene("Reglas");
    }
    public void LoadInterface(){
        SceneManager.LoadScene("Interface");
    }

    public void LoadRegistro(){
        SceneManager.LoadScene(3);
    }
    public void Interface(){
        SceneManager.LoadScene(0);
    }

    public void Salir()
    {
        //Salir del juego 
        Debug.Log("Saliendo");
        Application.Quit();
    }
}
