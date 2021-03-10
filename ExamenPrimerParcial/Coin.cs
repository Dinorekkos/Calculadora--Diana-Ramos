using UnityEngine;
public class Coin : Circle
{
public Circle coin = new Circle (0,0, "coin");

 void Start() 
 {
    coin.RadiusCircle1 = 3;
    coin.AreaCircle1 = 6;
    coin.ObjectCircle1 = "This is a Coin";
    
    Debug.Log(coin.RadiusCircle1);

  
 }
    



}

