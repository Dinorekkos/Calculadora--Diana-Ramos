using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    ShapeController triangle = new ShapeController (3, 1, 0, 0.5f, "Triangle");

    public void CreatTriangleClass()
    {
        Debug.Log(triangle.figure + "tiene " + triangle.numberOfVertex + " vértices, sus lados miden "+ triangle.lenghtSide
        + " y tiene un área de " + triangle.area);

    }



}
