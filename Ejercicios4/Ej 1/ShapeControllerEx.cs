using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeControllerEx : MonoBehaviour
{
    [Header ("Buttons")]
    [SerializeField] private GameObject buttonsFigures;
    [SerializeField] private GameObject buttonReturn;



    [Header ("FiguresLayer")]
    [SerializeField] private GameObject rectangleGroup;
    [SerializeField] private GameObject triangleGroup;
    [SerializeField] private GameObject circleGroup;

    [Header ("Texts GameObjects")]
    [SerializeField] private GameObject txtSelectFigureMenu;
    
    
     [Header ("Texts Rectangle")]

     [SerializeField] private Text selectOperationRecatngle;
     [SerializeField] private Text pointRectangle1;
     [SerializeField] private Text pointRectangle2;
     [SerializeField] private Text resultRectangleTxt;

     
     [Header ("Texts Circle")]
      [SerializeField] private Text selectOperationCircle;
      [SerializeField] private Text radioCircleTxt;
      [SerializeField] private Text centerCircleTxt;
      [SerializeField] private Text resultCircleTxt;
     
      [Header ("Texts Triangle")]
      [SerializeField] private Text selectOperationTriangle;
      [SerializeField] private Text resultTriangleTxt;

      [SerializeField] private Text edgePoint1Txt;
      [SerializeField] private Text edgePoint2Txt;
      [SerializeField] private Text edgePoint3Txt;


    [Header ("Data Rectangle")]
    
    [SerializeField] private int rectanglePoint1;
    [SerializeField] private int rectanglePoint2;

    [Header ("Data Circle")]
    [SerializeField] private int circleRadioPoint;
    [SerializeField] private int circleCenterPoint;

    [Header ("Data Triangle")]
    [SerializeField] private int trianglePoint1;
    [SerializeField] private int trianglePoint2;
    [SerializeField] private int trianglePoint3;






    RectangleClass rectangleObject = new RectangleClass(0,0);
    CircleClassEx circleObject = new CircleClassEx (0,0);
    TriangleClassEx triangleObject = new TriangleClassEx (0,0,0);
    

     private void Awake()
    {
        rectangleGroup.SetActive(false);
        triangleGroup.SetActive(false);
        circleGroup.SetActive(false);
        buttonReturn.SetActive(false);
    }

    //Botones Menu
    public void RectangleShapeEx()
    {   
        buttonsFigures.SetActive(false);
        rectangleGroup.SetActive(true);
        txtSelectFigureMenu.SetActive(false);
        buttonReturn.SetActive(true);

    }
  
    public void CircleShapeButton()
    {
        buttonsFigures.SetActive(false);
        circleGroup.SetActive(true);
        txtSelectFigureMenu.SetActive(false);
        buttonReturn.SetActive(true);
    }

    public void TriangleShapeButton()
    {
        buttonsFigures.SetActive(false);
        triangleGroup.SetActive(true);
        txtSelectFigureMenu.SetActive(false);
        buttonReturn.SetActive(true);

    }
    


    // Get Inputs de las figuras
    private void GetInputsRectangule()
    {
        rectangleObject.Point1Rectangle = rectanglePoint1;
        rectangleObject.Point2Rectangle = rectanglePoint2;

    }

    private void GetInputsCircle()
    {
        circleObject.RadioCirclePoint = circleRadioPoint;
        circleObject.CenterCirlcePoint = circleCenterPoint;

    }

    private void GetInputsTriangle()
    {
        triangleObject.TrianglePoint1 = trianglePoint1;
        triangleObject.TrianglePoint2 = trianglePoint2;
        triangleObject.TrinaglePoint3 = trianglePoint3;
    }

    // Funciones de Rectangle
    public void GetRectangleBase()
    {
        GetInputsRectangule();
        Debug.Log(rectanglePoint1);
        pointRectangle1.text = rectanglePoint1.ToString();

    }
    public void GetRectangleHeight()
    {   
        GetInputsRectangule();
        Debug.Log(rectanglePoint2);
        pointRectangle2.text = rectanglePoint2.ToString();
    }
    public void GetRectanglePerimeter()
    {      
        GetInputsRectangule();
        float rectangleResultPerimeter;
        selectOperationRecatngle.text = "Perimeter";
        rectangleResultPerimeter = rectanglePoint1 + rectanglePoint1 + rectanglePoint2 + rectanglePoint2;
        resultRectangleTxt.text = rectangleResultPerimeter.ToString();

    }
     public void GetRectangleArea()
    {
        GetInputsRectangule();
        float rectangleResultArea;
        selectOperationRecatngle.text = "Area";
        rectangleResultArea = rectanglePoint1 * rectanglePoint2; 
        resultRectangleTxt.text = rectangleResultArea.ToString();
    }


    // Funciones Circulo
    public void GetCircleRadio()
    {   
        GetInputsCircle();
        selectOperationCircle.text = "Radio";
        Debug.Log (circleRadioPoint);
        radioCircleTxt.text = circleRadioPoint.ToString();
    }

    public void GetCircleDiameter()
    {
        GetInputsCircle();
        float resultDiameter;
        selectOperationCircle.text = "Diameter";
        resultDiameter = circleRadioPoint * 2;
        centerCircleTxt.text = resultDiameter.ToString();
        
    }

    public void GetCirclePerimeter()
    {
        GetInputsCircle();
        double resultCirclePerimeter;
        selectOperationCircle.text = "Perimeter";
        resultCirclePerimeter = (Math.PI * 2) * circleRadioPoint;
        Debug.Log(resultCirclePerimeter);
        resultCircleTxt.text = resultCirclePerimeter.ToString();
    }

    public void GetCircleArea()
    {
        GetInputsCircle();
        double resultCircleArea;
        selectOperationCircle.text = "Area";
        resultCircleArea = (Math.PI * Math.Pow(circleRadioPoint,2));
        resultCircleTxt.text = resultCircleArea.ToString();
        Debug.Log(resultCircleArea);
    }

    //Funciones Triangle

    public void GetEdgesTriangle()
    {
        GetInputsTriangle();
        edgePoint1Txt.text = trianglePoint1.ToString();
        edgePoint2Txt.text = trianglePoint2.ToString();
        edgePoint3Txt.text = trianglePoint3.ToString();
    
    }
    public void GetTriangle()
    {
        GetInputsTriangle();
        string triangleType;
        selectOperationTriangle.text = "Triangle Type";
        
        if(trianglePoint1 == trianglePoint2 && trianglePoint1 == trianglePoint3 && trianglePoint2 == trianglePoint3)
        {
            triangleType  = "Equilatero";
            resultTriangleTxt.text = triangleType;
        }

        if(trianglePoint1 == trianglePoint2  && trianglePoint2 != trianglePoint3)
        {
            triangleType  = "Isósceles";
            resultTriangleTxt.text = triangleType;
        }

        if(trianglePoint1!=trianglePoint2 && trianglePoint1 != trianglePoint3 && trianglePoint2 != trianglePoint3)
        {
             triangleType  = "Escaleno";
             resultTriangleTxt.text = triangleType;
        }
    }

    public void GetTrianglePerimeter()
    {
        GetInputsTriangle();
        float trianglePerimeter;
        selectOperationTriangle.text = "Perimeter";
        trianglePerimeter = trianglePoint1 + trianglePoint2 + trianglePoint3;
        resultTriangleTxt.text = trianglePerimeter.ToString();
    }

    public void GetTriangleArea()
    {
        GetInputsTriangle();
        float triangleArea;
        float baseTriangle;
        float hightTraingle;
        selectOperationTriangle.text = "Area";
        baseTriangle = trianglePoint1 - trianglePoint2;
        if(baseTriangle<= 0) baseTriangle = trianglePoint2;
        hightTraingle = trianglePoint1 - trianglePoint3;
        if (hightTraingle<= 0) hightTraingle = trianglePoint3 - trianglePoint1;

        triangleArea = (baseTriangle * hightTraingle) /2;
        resultTriangleTxt.text = triangleArea.ToString();
    }


    public void ReturnBotton()
    {
        buttonsFigures.SetActive(true);
        buttonReturn.SetActive(false);
       txtSelectFigureMenu.SetActive(true);
        
        if(rectangleGroup.activeInHierarchy == true)
        {
            rectangleGroup.SetActive(false);
        }
        if(triangleGroup.activeInHierarchy == true)
        {
            triangleGroup.SetActive(false);
        }

        if(circleGroup.activeInHierarchy == true)
        {
            circleGroup.SetActive(false);
        }

    }




    
}