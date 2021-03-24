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
     [SerializeField] private Text rectanglePoint1XYtxt;
     [SerializeField] private Text rectanglePoint2XYtxt;
     [SerializeField] private Text rectanglePointBasetxt;
     [SerializeField] private Text rectanglePointHeightxt;
    
     
     [SerializeField] private Text resultRectangleTxt;

     
     [Header ("Texts Circle")]
      [SerializeField] private Text selectOperationCircle;
      [SerializeField] private Text radioCircleTxt;
      [SerializeField] private Text diameterCircleTxt;
      [SerializeField] private Text point1CircleTxt;
      

      [SerializeField] private Text resultCircleTxt;
     
      [Header ("Texts Triangle")]
      [SerializeField] private Text selectOperationTriangle;
      [SerializeField] private Text resultTriangleTxt;
      [SerializeField] private Text edgePoint1Txt;
      [SerializeField] private Text edgePoint2Txt;
      [SerializeField] private Text edgePoint3Txt;
       [SerializeField] private Text distance1to2Txt;
       [SerializeField] private Text distance2to3Txt;
       [SerializeField] private Text distance3to1Txt;
      


    float baseRectangle;
    float heightRectangle;
    
     [Header ("Data Rectangle")]
    [SerializeField] private int rectanglePoint1X;
    [SerializeField] private int rectanglePoint1Y;

    [SerializeField] private int rectanglePoint2X;
    [SerializeField] private int rectanglePoint2Y;


    float circleRadio;
    float circleDiameter;

    [Header ("Data Circle")]
    [SerializeField] private int circlePoint1X;
    [SerializeField] private int circlePoint1Y;
    [SerializeField] private int circlePointRadio;
   

    float distance1To2;
    float distnace2To3;
    float distance3To1;

    [Header ("Data Triangle")]
    [SerializeField] private int trianglePoint1X;
    [SerializeField] private int trianglePoint1Y;
    [SerializeField] private int trianglePoint2X;
    [SerializeField] private int trianglePoint2Y;
    [SerializeField] private int trianglePoint3X;
     [SerializeField] private int trianglePoint3Y;


    RectangleClass rectangleObject = new RectangleClass(0,0,0,0);
    CircleClassEx circleObject = new CircleClassEx (0,0,0);
    TriangleClassEx triangleObject = new TriangleClassEx (0,0,0,0,0,0);
    

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
        rectangleObject.Point1RectangleX = rectanglePoint1X;
        rectangleObject.Point1RectangleY = rectanglePoint1Y;
        rectangleObject.Point2RectangleX = rectanglePoint2X;
        rectangleObject.Point2RectangleY = rectanglePoint2Y;

    }

    private void GetInputsCircle()
    {
       circleObject.CirclePoint1X = circlePoint1X;
       circleObject.CirclePoitn1Y = circlePoint1Y;
       circleObject.CirclePointRadio = circlePointRadio;
      

    }

    private void GetInputsTriangle()
    {
        triangleObject.TrianglePoint1X = trianglePoint1X;
        triangleObject.TrianglePoint1Y = trianglePoint1Y;
        triangleObject.TrianglePoint2X = trianglePoint2X;
        triangleObject.TrianglePoint2Y = trianglePoint2Y;
        triangleObject.TrianglePoint3X = trianglePoint3X;
        triangleObject.TrianglePoint3Y = trianglePoint3Y; 
    }

    // Funciones de Rectangle
    public void GetRectangleBase()
    {
        
        GetInputsRectangule();
        rectanglePoint1XYtxt.text = "(" + rectanglePoint1X.ToString() +"," + rectanglePoint1Y.ToString() + ")"; 
        baseRectangle = rectanglePoint1X - rectanglePoint2X;
        if (baseRectangle < 0 ) baseRectangle = rectanglePoint2X - rectanglePoint1X;
        rectanglePointBasetxt.text = baseRectangle.ToString();

       
    }
    public void  GetRectangleHeight()
    {  
        GetInputsRectangule();
        rectanglePoint2XYtxt.text = "(" + rectanglePoint2X.ToString() +"," + rectanglePoint2Y.ToString() + ")"; 
        heightRectangle = rectanglePoint1Y - rectanglePoint2Y;
        if (heightRectangle <= 0) heightRectangle = rectanglePoint2Y - rectanglePoint1Y;
        rectanglePointHeightxt.text = heightRectangle.ToString();
  
       
    }
    public void GetRectanglePerimeter()
    {      
        GetInputsRectangule();
        float rectangleResultPerimeter;
        selectOperationRecatngle.text = "Perimeter";
        rectangleResultPerimeter = heightRectangle + heightRectangle + baseRectangle + baseRectangle;
        resultRectangleTxt.text = rectangleResultPerimeter.ToString();
       

    }
     public void GetRectangleArea()
    {
        GetInputsRectangule();
        float rectangleResultArea;
        selectOperationRecatngle.text = "Area";
        rectangleResultArea =  baseRectangle * heightRectangle;
        resultRectangleTxt.text = rectangleResultArea.ToString();
    }


    // Funciones Circulo
    public void GetCircleRadio()
    {   
        GetInputsCircle();
        selectOperationCircle.text = "Radio";
        circleRadio = circlePointRadio;
        point1CircleTxt.text = "(" + circlePoint1X.ToString() + "," + circlePoint1Y.ToString() + ")";
        radioCircleTxt.text = circleRadio.ToString();
    }

    public void GetCircleDiameter()
    {
        GetInputsCircle();
        float resultDiameter;
        selectOperationCircle.text = "Diameter";
        resultDiameter = circleRadio * 2;
        diameterCircleTxt.text = resultDiameter.ToString();
        
    }

    public void GetCirclePerimeter()
    {
        GetInputsCircle();
        double resultCirclePerimeter;
        selectOperationCircle.text = "Perimeter";
        resultCirclePerimeter = (float)Math.Round((Math.PI * 2) * (circleRadio),2);
       resultCircleTxt.text = resultCirclePerimeter.ToString();
    }

    public void GetCircleArea()
    {
        GetInputsCircle();
        double resultCircleArea;
        selectOperationCircle.text = "Area";
        resultCircleArea = (float)Math.Round((Math.PI) * Math.Pow(circleRadio,2));
        resultCircleTxt.text = resultCircleArea.ToString();
        
    }

    //Funciones Triangle

    public void GetEdgesTriangle()
    {
        GetInputsTriangle();
        edgePoint1Txt.text = "(" + trianglePoint1X.ToString() + "," + trianglePoint1Y.ToString() + ")"; 
        edgePoint2Txt.text = "(" + trianglePoint2X.ToString() + "," + trianglePoint2Y.ToString() + ")"; 
        edgePoint3Txt.text = "(" + trianglePoint3X.ToString() + "," + trianglePoint3Y.ToString() + ")"; 
    
    }
    public void GetTriangle()
    {
        GetInputsTriangle();
        string triangleType;
       

        distance1To2 = (float)Math.Round(Mathf.Sqrt(Mathf.Pow((trianglePoint2X - trianglePoint1X),2) + Mathf.Pow((trianglePoint2Y - trianglePoint1Y),2)), 2);
        distnace2To3 = (float)Math.Round(Mathf.Sqrt(Mathf.Pow((trianglePoint3X - trianglePoint2X),2) + Mathf.Pow ((trianglePoint3Y - trianglePoint2Y),2)),2);
        distance3To1 = (float)Math.Round (Mathf.Sqrt(Mathf.Pow((trianglePoint3X - trianglePoint1X),2) + Mathf.Pow ((trianglePoint3Y - trianglePoint1Y),2)),2);

        distance1to2Txt.text = distance1To2.ToString();
        distance2to3Txt.text = distnace2To3.ToString();
        distance3to1Txt.text = distance3To1.ToString();
       
       
       selectOperationTriangle.text = "Triangle Type";
        
        if(distance1To2 == distnace2To3 && distnace2To3 == distance3To1 && distance1To2 == distance3To1)
        {
            triangleType  = "Equilatero";
            resultTriangleTxt.text = triangleType;
        }

        if(distance1To2 == distnace2To3  && distnace2To3 != distance1To2)
        {
            triangleType  = "Isósceles";
            resultTriangleTxt.text = triangleType;
        }

        if(distance1To2 != distnace2To3 && distance3To1!= distance1To2 && distnace2To3 != distance1To2)
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
        trianglePerimeter = distance1To2 + distnace2To3 + distance3To1;
        resultTriangleTxt.text = trianglePerimeter.ToString();
    }

    public void GetTriangleArea()
    {
        GetInputsTriangle();
        float triangleArea;
        float baseTriangle;
        float hightTraingle;
        selectOperationTriangle.text = "Area";
        baseTriangle = distance1To2;
        hightTraingle = distnace2To3;

        triangleArea = (float) Math.Round((baseTriangle * hightTraingle) /2);
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