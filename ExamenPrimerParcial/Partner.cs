using UnityEngine;

public class Partner : Circle
{
    Circle enemy = new Circle (6,1, "partner");
    void Start()
    {
        enemy.RadiusCircle1 = 9;
        enemy.AreaCircle1 = 3;
        enemy.ObjectCircle1 = "This is a partner";
    }




}
