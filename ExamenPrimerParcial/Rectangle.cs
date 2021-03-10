using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{

ShapeController rectangle = new ShapeController (4, 2, 0,16, "Rectangle" );

public void CreatRectangleClass()

{
    Debug.Log (rectangle.figure + "  tiene" + rectangle.numberOfVertex + " vértices "  +" un area de= " + rectangle.area);
}


}
