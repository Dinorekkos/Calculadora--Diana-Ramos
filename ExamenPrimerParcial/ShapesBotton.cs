using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesBotton : MonoBehaviour
{
   
    [SerializeField] private GameObject circleScript;
    [SerializeField] private GameObject rectangleScript;
    [SerializeField] private GameObject triangleScript;
    [SerializeField] private GameObject squareScript;
    
    private int numberFigure; 

 public void ShowShapesButton()
{ 
    CreatShapes();
}
 
private void CreatShapes()
{
    numberFigure = Random.Range(0,5);
    NumberOfShapes.numberOfShapes += 1;
    
    switch (numberFigure)
    {
        case 1:
        circleScript.gameObject.GetComponent<Circle>().CreateCircleClass();
        circleScript.gameObject.GetComponent<Circle>().CreatChildren();
        break;

        case 2:
        rectangleScript.gameObject.GetComponent<Rectangle>().CreatRectangleClass();
        break;

        case 3:
        squareScript.gameObject.GetComponent<Square>().CreatSquareClass();
        break;

        case 4:
        triangleScript.gameObject.GetComponent<Triangle>().CreatTriangleClass();
        break;
    }
}




}
