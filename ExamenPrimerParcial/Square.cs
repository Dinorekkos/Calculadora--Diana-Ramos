using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
   
   ShapeController square = new ShapeController(4,5, 0 , 25, "Square");

   public void CreatSquareClass()
   {
       Debug.Log(square.figure + " tiene " + square.numberOfVertex + " de vértices, sus lados miden"+ 
       square.lenghtSide + " y tiene un area de " + square.area);

   }






}
