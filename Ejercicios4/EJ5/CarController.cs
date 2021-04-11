using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CarController : MonoBehaviour
{   
    System.Random randomCarSelected = new System.Random();
    public List<CarAtributes> carlist = new List<CarAtributes>();  
    public CarAtributes firstCar = new CarAtributes (4, 4, 8 , 4395, 275, 6, "BMW x6M");
    public CarAtributes secondCar = new CarAtributes (2, 4, 8 , 2995, 250, 6, "Audi S5 Cabriolet");
    CarAtributes thirdCar = new CarAtributes (5, 5, 8 , 1332, 199, 6, "2020 Jeep Renegade");
    CarAtributes forthCar = new CarAtributes (5, 6, 4, 1798, 187, 9, "Honda Jade 2017");
    CarAtributes fifthCar = new CarAtributes (2, 2, 6 , 3493, 308, 6, "2016 Honda NSX II ");
    CarAtributes sixthCar = new CarAtributes (2, 2, 8 , 3902, 340, 7, "2019 Ferrari F8 Tributo");
    CarAtributes septhCar = new CarAtributes (2, 2, 8 , 3990, 340, 6, "Ferrari SF90 Spider");
    CarAtributes eightCar = new CarAtributes (2, 2, 6, 3995, 300, 7, "Porsche 718 Spyder");
    public CarAtributes ninthCar = new CarAtributes (2, 2, 12 , 6498, 320, 7, "Lamborghini Centenario");
    public CarAtributes tenthCar = new CarAtributes (2, 4, 5, 2480, 250, 7, "Audi TT RS Roadster");

   

    public int goalDistance = 200;
    public float distanceCar1;
    public float distanceCar2;
    public float timeCar1;
    public float timeCar2;
    public float lossTimeCar;

     public int randomCar1;
     public int randomCar2;

public void Awake() 
{
    carlist.Add(firstCar);
    carlist.Add(secondCar);
    carlist.Add(thirdCar);
    carlist.Add(forthCar);
    carlist.Add(fifthCar);
    carlist.Add(sixthCar);
    carlist.Add(septhCar);
    carlist.Add(eightCar);
    carlist.Add(ninthCar);
    carlist.Add(tenthCar);
}
    public void SelectCars()
    {   
        randomCar1 = randomCarSelected.Next(1, carlist.Count);
        randomCar2 = randomCarSelected.Next(1, carlist.Count);   
        Debug.Log(randomCar1);
        Debug.Log(randomCar2);  
        CompareCars(randomCar1, randomCar2);
        if(randomCar1 == randomCar2)
        {

        }
    }

    public void CompareCars(int index1, int index2)
    {   
        
         CarAtributes tempo1 =  carlist[index1];
         CarAtributes tempo2 = carlist[index2];

         Debug.Log("Autos en carrera");
         Debug.Log(carlist[index1].AtributesToString(tempo1));
         Debug.Log(carlist[index2].AtributesToString(tempo2));

         distanceCar1 = carlist[index1].MaxVelocity / 3.6f;
         distanceCar2 = carlist[index2].MaxVelocity / 3.6f;
         
         timeCar1 = distanceCar1 / goalDistance;
         timeCar2 = distanceCar2 / goalDistance;
        
        Debug.Log("Tiempo Carro 1 = "+ timeCar1 + " seg " +  "TiempoCarro 2 ="+   + timeCar2 + " seg");

        if (timeCar1 < timeCar2)
        {   
            lossTimeCar = timeCar1 - timeCar2;
            Debug.Log("Perdió el auto 1 por = " + lossTimeCar+ " seg");
        }  

        if (timeCar1 > timeCar2)
        {
            Debug.Log("Ganó auto 1");
        }       

        if (timeCar2 < timeCar1)
        {
            lossTimeCar = timeCar2 - timeCar1;
            Debug.Log("Perdió auto 2 por = " + lossTimeCar + " seg");
            
        }  

        if (timeCar2 > timeCar1)
        {
            Debug.Log("Ganó auto 2");
        }

        if (timeCar1 == timeCar2)
        {
            Debug.Log("Ningun auto ganó, ambos tienen la misma velocidad");
        }          
           
    }
    public void ShowCars()
    {
        Debug.Log("CARRO 1 = " + firstCar.AtributesToString(firstCar));
    
        Debug.Log("CARRO 2 = " + secondCar.AtributesToString(secondCar));
        Debug.Log("CARRO 3 = " + thirdCar.AtributesToString(thirdCar));
        Debug.Log("CARRO 4 = " + forthCar.AtributesToString(forthCar));
        Debug.Log("CARRO 5 = " + fifthCar.AtributesToString(fifthCar));
        Debug.Log("CARRO 6 = " + sixthCar.AtributesToString(sixthCar));
        Debug.Log("CARRO 7 = " + septhCar.AtributesToString(septhCar));
        Debug.Log("CARRO 8 = " + eightCar.AtributesToString(eightCar));
        Debug.Log("CARRO 9 = " + ninthCar.AtributesToString(ninthCar));
        Debug.Log("CARRO 10 = " + tenthCar.AtributesToString(tenthCar));

        Debug.Log(carlist.Count);
    }

}
