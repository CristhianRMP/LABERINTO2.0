using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SelectName : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI textoNombre;
    public GameObject ButtonPlay;

    private void Update(){
        if(textoNombre.text.Length < 4){
            ButtonPlay.SetActive(false);
        }
        if(textoNombre.text.Length >= 4){
            ButtonPlay.SetActive(true);
        }
    }

    public void play(){
        PlayerPrefs.SetString("nombre1", inputField.text);
        SceneManager.LoadScene(4);
    }
}
