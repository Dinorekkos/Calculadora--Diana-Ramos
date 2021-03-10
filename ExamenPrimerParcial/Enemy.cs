using UnityEngine;

public class Enemy : Circle
{
    Circle enemy = new Circle (23,5, "enemy");
    void Start()
    {
        enemy.RadiusCircle1 = 98;
        enemy.AreaCircle1 = 6;
        enemy.ObjectCircle1 = "This is a enemy";
    }

}
