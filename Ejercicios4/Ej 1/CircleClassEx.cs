
public class CircleClassEx 
{
    private int radioCirclePoint, centerCirclePoint;

    public CircleClassEx(int aRadioCircle, int aCenterCirclePoint)
    {
        radioCirclePoint = aRadioCircle;
        centerCirclePoint = aCenterCirclePoint;
    }

    public int RadioCirclePoint
    {
        get { return radioCirclePoint;}
        set {radioCirclePoint = value;}
    }

    public int CenterCirlcePoint
    {
        get{return centerCirclePoint;}
        set {centerCirclePoint = value;}
    }


}
