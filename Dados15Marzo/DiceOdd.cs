using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceOdd : MonoBehaviour
{
    Dice oddDice = new Dice(10, "plastico", "blanco con negro");


    void Start()
    {
        oddDice.NumberFaces = 12;
        oddDice.Material = " Metal";
        oddDice.Color = "RGB";

        Debug.Log ("Este es el dado impar, tiene "+ oddDice.NumberFaces +" caras"
        + "es de material "+ oddDice.Material+ "  y de color " + oddDice.Color);

        for (int i = 1; i<=oddDice.NumberFaces; i ++)
        {
            if (i % 2 != 0)
            {
                Debug.Log (i);
            }
        
        }

    }


}
