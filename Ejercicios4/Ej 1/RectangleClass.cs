
public class RectangleClass 
{
    
    private int point1RectangleX,point1RectangleY;
    private int point2RectangleX, point2RectangleY;


    public RectangleClass(int aPoint1RectangleX, int aPoint1RectangleY, int aPoint2RectangleX,  int aPoint2RectangleY)
    {
        point1RectangleX = aPoint1RectangleX;
        point1RectangleY = aPoint1RectangleY;
        point2RectangleX = aPoint2RectangleX;
        point2RectangleY = aPoint2RectangleY;
    }


    public int Point1RectangleX
    {
        get{return point1RectangleX;}
        set { point1RectangleX = value;}
    }

    public int Point1RectangleY
    {
        get {return point1RectangleY;}
        set {point1RectangleY = value;}
    }


    public int Point2RectangleX
    {
        get{return point2RectangleX;}
        set {point2RectangleX = value;}
    }   

    public int Point2RectangleY
    {
        get {return point2RectangleY;}
        set {point2RectangleY = value;}
    }

}
