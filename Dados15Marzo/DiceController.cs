public class Dice
{

private float numberFaces;
private string material;
private string color;


public Dice (float anumberFaces, string amaterial, string acolor)
{

 numberFaces = anumberFaces;
 material = amaterial;
 color = acolor;

}

public float NumberFaces
{
    get {return numberFaces;}
    set {numberFaces = value;}

}

public string Material 

{
    get {return material;}
    set {material = value;}
}

public string Color
{
    get { return color;}
    set { color = value;}
}

}