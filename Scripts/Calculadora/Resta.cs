using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resta : MonoBehaviour
{
    public string num1, num2;
    public GameObject inputFieldGM1, inputFieldGM2;
    public GameObject DisplayResultado;
    public GameObject restaText;
    public string resultado;



    public void GuardarInputResta()
    {

        num1 = inputFieldGM1.GetComponent<Text>().text;
        num2 = inputFieldGM2.GetComponent<Text>().text;

        resultado = num1;

        restaText.GetComponent<Text>().text = "-";

        DisplayResultado.GetComponent<Text>().text = "Resultado =  " + resultado;
       
        
    }
}
