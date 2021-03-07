using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicePair : MonoBehaviour
{
   Dice pairDice = new Dice (4, "aluminio" , "verde");


    void Start()
    {
        pairDice.NumberFaces = 6;
        pairDice.Material = "Madera";
        pairDice.Color = "Azul";

         Debug.Log ("Este es el dado par, tiene  "+ pairDice.NumberFaces +"  caras"
        + " es de material  "+ pairDice.Material+ "  y de color " + pairDice.Color);

        for (int i = 2; i<= pairDice.NumberFaces; i+= 2)
        {
           Debug.Log(i);
        }





    }

}
