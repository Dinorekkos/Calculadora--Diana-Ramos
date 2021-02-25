using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Calculation : MonoBehaviour
{
  public float result;


public void AddinDebug(float result)
{
    Debug.Log  (Add(result));
}
    public static float Add(float result)
    {
        float num1 = 8 , num2= 7;
        result = num1 + num2;
        return result;
    }

    public static float Substract(float result)
    {
        float num1 = 8 , num2 = 7;
        result = num1 - num2;
        return result;
    }



}
