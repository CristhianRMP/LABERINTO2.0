using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class puntos : MonoBehaviour
{
    // Start is called before the first frame update
    public float Puntos;
    public TextMeshProUGUI textoPuntos;

    private void Update(){
        textoPuntos.text = "Score: " + Puntos.ToString();
    }
    
}
