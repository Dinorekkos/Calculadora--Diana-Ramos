
public class TriangleClassEx
{
    private int trianglePoint1X, trianglePoint1Y;
    private int trianglePoint2X, trianglePoint2Y;
    private int trianglePoint3X, trianglePoint3Y;

    public TriangleClassEx (int atrianglePoint1X1, int atrianglePoint1Y, int atrianglePoint2X, int atrianglePoint2Y,int atrianglePoint3X, int  atrianglePoint3Y)
    {
        trianglePoint1X = atrianglePoint1X1;
        trianglePoint1Y = atrianglePoint1Y;
        trianglePoint2X = atrianglePoint2X;
        trianglePoint2Y = atrianglePoint2Y;
        trianglePoint3X = atrianglePoint3X;
        trianglePoint3Y = atrianglePoint3Y;
        
    }

public int TrianglePoint1X
{
    get {return trianglePoint1X;}
    set {trianglePoint1X = value;}
}

public int TrianglePoint1Y
{
 get{return trianglePoint1Y;}
 set{trianglePoint1Y = value;}
}

public int TrianglePoint2X
{
    get{return trianglePoint2X;}
    set{trianglePoint2X = value;}
}

public int TrianglePoint2Y  
{
    get {return trianglePoint2Y;}
    set {trianglePoint2Y  = value;}
}

public int TrianglePoint3X 
{
    get {return trianglePoint3X;}
    set {trianglePoint3X = value;}
}

public int TrianglePoint3Y
{
    get { return trianglePoint3Y;}
    set {trianglePoint3Y = value;}
}



}
