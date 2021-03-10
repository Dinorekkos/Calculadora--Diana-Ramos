using UnityEngine;

public class Circle : MonoBehaviour
{
   public Coin coinScript;

   ShapeController circle = new ShapeController (0,0,10, 25,"Circle");

public void CreateCircleClass()
{
    Debug.Log (circle.figure + "  tiene de radio = " + circle.radius + " un area de= " + circle.area);
}


public void CreatChildren()
{
    Debug.Log("Se crea Coin");
    Debug.Log("Se crea Bullet");
    Debug.Log("Se crea Enemy");
    Debug.Log("Se crea Partner");
}



private float radiusCircle1;
private float areaCircle1;
private string objectCirle1;


public Circle (float aRadiusCircle1, float aAreaCircle1, string aObjectCircle1)
{
    radiusCircle1 = aRadiusCircle1;
    areaCircle1 = aAreaCircle1;
    objectCirle1 = aObjectCircle1;
}

public float RadiusCircle1
{
    get {return radiusCircle1;}
    set {radiusCircle1 = value;}
}

public float AreaCircle1
{
    get {return areaCircle1;}
    set {areaCircle1 = value;}

}

public string ObjectCircle1
{
    get {return objectCirle1;}
    set {objectCirle1 = value;}

}

public Circle()
{
}





}

