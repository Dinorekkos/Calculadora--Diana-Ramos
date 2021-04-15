using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class unitTest1 
{
    [Test]
    public void CalculatedRectangleArea_Test()
    {
        //Arrange
        var area = new ShapeControllerEx();
        var rectangleObject = new RectangleClass(1,2,3,4);
        
        var expectedRectangleBase = 2f;
        var calculateRectangleBase = 0f;

        var expectedRectangleHeight = 2f;
        var calculatedRectangleHeight = 0f;

       // var expectedRectangleArea = 4f;
       // var calculatedRectangleArea = 0f;
       
        
        //ACT- funcion a probar
        calculateRectangleBase = area.GetRectangleBase();
        calculatedRectangleHeight = area.GetRectangleHeight();

       // calculatedRectangleArea = area.GetRectangleArea();

        //Assert - Afirmacion 
        //Assert.That(calculatedRectangleArea, Is.EqualTo(expectedRectangleArea));

        Assert.That(calculateRectangleBase, Is.EqualTo(expectedRectangleBase));
        Assert.That(calculatedRectangleHeight, Is.EqualTo(expectedRectangleHeight));

    }
    
}
