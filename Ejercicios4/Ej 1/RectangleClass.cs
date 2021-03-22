
public class RectangleClass 
{
    
    private int point1Rectangle;
    private int point2Rectangle;


    public RectangleClass(int aPoint1Rectangle, int aPoint2Rectangle)
    {
        point1Rectangle = aPoint1Rectangle;
        point2Rectangle = aPoint2Rectangle;
    }


    public int Point1Rectangle
    {
        get{return point1Rectangle;}
        set { point1Rectangle = value;}
    }

    public int Point2Rectangle
    {
        get{return point2Rectangle;}
        set {point2Rectangle = value;}
    }   

}
