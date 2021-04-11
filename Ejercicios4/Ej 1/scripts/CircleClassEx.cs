
public class CircleClassEx 
{
    private int circlePoint1X, circlePoint1Y;
     private int circlePointRadio;

    public CircleClassEx(int aCirclePoint1X, int aCirclePoint1Y, int aCirclePointRadio)
    {   
        circlePoint1X = aCirclePoint1X;
        circlePoint1Y = aCirclePoint1Y;
        circlePointRadio = aCirclePointRadio;        
    }

    public int CirclePoint1X
    {
        get {return circlePoint1X;}
        set {circlePoint1X = value;}
    }
    public int CirclePoitn1Y
    {
        get { return circlePoint1Y;}
        set {circlePoint1Y = value;}
    }

    public int CirclePointRadio
    {
        get{return circlePointRadio;}
        set { circlePointRadio = value;}
    }

    
}
