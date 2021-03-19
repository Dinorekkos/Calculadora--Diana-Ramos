using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAtributes : CarClass
{
 
 private int numberOfDoors;
 private int numberOfPassengers;
 private int gasolineConsumption;
 private int gasolineCapacity;
 private float maxVelocity;
 private int numberOfVelocity;
 private string carName;

public CarAtributes(int aNumberOfDoors, int aNumberOfPassengers, int aGasolineConsumption, int aGasolineCapacity, float aMaxVelocity, int aNumberOfVelocity, string aCarName)
{
        numberOfDoors = aNumberOfDoors;
        numberOfPassengers = aNumberOfPassengers;
        gasolineConsumption = aGasolineConsumption;
        gasolineCapacity = aGasolineCapacity;
        maxVelocity = aMaxVelocity;
        numberOfVelocity = aNumberOfVelocity;
        carName = aCarName;
}



public int NumberOfDoors
{
  get {return numberOfDoors;}
  set {numberOfDoors = value;}
}

public int NumberOfPassengers
{
  get {return numberOfPassengers;}
  set {numberOfPassengers = value;}
}

public int GasolineConsumption
{
  get {return gasolineConsumption;}
  set {gasolineConsumption = value;}
}

public int GasolineCapacity
{
  get {return gasolineCapacity;}
  set {gasolineCapacity = value;}
}
public float MaxVelocity
{
  get {return maxVelocity;}
  set {maxVelocity = value;}
}
 
 public int NumberOfVelocity
{
  get {return numberOfVelocity;}
  set {numberOfVelocity = value;}
}
 
public string CarName
{
  get {return carName;}
  set {carName = value;}
}
public string AtributesToString (CarAtributes debugCars)
{ 
   string tempo = debugCars.CarName.ToString() + " " + debugCars.NumberOfDoors.ToString() + " " + debugCars.NumberOfPassengers.ToString() + " " 
   + debugCars.GasolineConsumption.ToString() + " " + debugCars.GasolineCapacity.ToString() + " " + debugCars.MaxVelocity.ToString() + " " + debugCars.NumberOfVelocity.ToString();
   return tempo;

}





}
