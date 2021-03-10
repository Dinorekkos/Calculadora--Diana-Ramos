
using UnityEngine;

public class Bullet : Circle
{
    Circle bullet = new Circle (78.5f,3, "bullet");
    void Start()
    {
        bullet.RadiusCircle1 = 3.2f;
        bullet.AreaCircle1 = 32.16f;
        bullet.ObjectCircle1 = "This is a bullet";
    }

    
}
