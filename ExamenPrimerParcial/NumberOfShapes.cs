using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberOfShapes : MonoBehaviour
{
    public static float numberOfShapes = 0;
    private Text txtNumberOfShapes;

    void Awake()
    {
        txtNumberOfShapes = GetComponent<Text>();
    }

    private void Update()
    {
      txtNumberOfShapes.text = "" + numberOfShapes;  
    }


}
