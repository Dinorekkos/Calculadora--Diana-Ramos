
using NUnit.Framework;

public class testCar1
{
    [Test]
    public void TestVelocity_1()
    {  
      //Arrange
       var carsController = new CarController(); 
       var carControllerDistance = 0;
       var testDistance = 200;

        //ACT
        carControllerDistance = carsController.goalDistance;
        
        //Assert
        Assert.That(carControllerDistance, Is.EqualTo(testDistance));
    }

    [Test]
    public void TestNumberOfCars_2()
    {
        var carsController = new CarController();
        var numberOflistCars = 0;
        var expectedNumberOfCars= 10;

        carsController.Awake();

        numberOflistCars = carsController.carlist.Count;
        
        Assert.That (numberOflistCars, Is.EqualTo(expectedNumberOfCars));
    }
    

    [Test]
    public void TestSelectTCars_3()
    {
        var carsController = new CarController();
        System.Random testRandom = new System.Random();
        var randomCar = 0;
        var expectedRandomCar = 0;
       
        carsController.Awake();

        randomCar = testRandom.Next(1,carsController.carlist.Count);
        expectedRandomCar = 10;

        Assert.That(randomCar, Is.EqualTo(expectedRandomCar));

    }

    [Test]
    public void TestRandomCars_4()
    {
        var carsController = new CarController();
        var randomCar1 = 0;
        var randomCar2 = 0;
        
        carsController.Awake();
        carsController.SelectCars();
        randomCar1 = carsController.randomCar1;
        randomCar2 = carsController.randomCar2;

        Assert.AreNotEqual(randomCar1, randomCar2);
        
    }

    [Test]
    public void TestDistanceCar_5()
    {
        var carsController = new CarController();
        float testCarVelocity = 0;
        float  testCarDistance = 0;
        float expectedCarDistance = 0;
        
        carsController.Awake();
        testCarVelocity = carsController.tenthCar.MaxVelocity;
        testCarDistance = testCarVelocity / 3.6f;
        expectedCarDistance = 69.4f;

        Assert.That(testCarDistance, Is.EqualTo(expectedCarDistance));
    }

    [Test]
    public void TestTimeCar_6()

    {
        var carsController = new CarController();
        float testCarDistance = 0;
        var goalDistance = 0;
        float timeTestCar = 0;
        float expectedTime =0;
        
        testCarDistance = carsController.tenthCar.MaxVelocity / 3.6f;
        goalDistance = 200;
        timeTestCar = testCarDistance / goalDistance;
        expectedTime = 0.347f;

        Assert.That(timeTestCar,Is.EqualTo(expectedTime));
    }   

    [Test]
    public void TetsLoserCar_7()
    {
        var carsController = new CarController();
        var goalDistance = 0;
        float timeCar1 = 0;
        float timeCar2 = 0;
        float distanceCar1 = 0;
        float distanceCar2 = 0;
        
        distanceCar1 = carsController.tenthCar.MaxVelocity / 3.6f;
        distanceCar2 = carsController.ninthCar.MaxVelocity / 3.6f;
        goalDistance = 200;
        timeCar1 = distanceCar1 / goalDistance;
        timeCar2 = distanceCar2 / goalDistance;

        Assert.AreNotEqual(timeCar1, timeCar2);
    }
    [Test]
    public void TestEqualCars_8()
    {
        var carsController = new CarController();
        var goalDistance = 0;
        float timeCar1 = 0;
        float timeCar2 = 0;
        float distanceCar1 = 0;
        float distanceCar2 = 0;
        
        distanceCar1 = carsController.tenthCar.MaxVelocity / 3.6f;
        distanceCar2 = carsController.secondCar.MaxVelocity / 3.6f;
        goalDistance = 200;
        timeCar1 = distanceCar1 / goalDistance;
        timeCar2 = distanceCar2 / goalDistance;

        Assert.That(timeCar1, Is.EqualTo(timeCar2));
    }

    [Test]
    public void TestCarName_9() 
    {
        var carsController = new CarController();
        var nameCarTest  = "";
        var expectedCarName = "Audi TT RS Roadster";

        nameCarTest = carsController.tenthCar.CarName.ToString();

        Assert.That(nameCarTest, Is.EqualTo(expectedCarName));
    }


    [Test]
    public void TestCarVelocity_10()
    {
        var carsController = new CarController ();
        float testCarVelocity = 0;
        float expectedCarVelocity = 0;

        testCarVelocity = carsController.tenthCar.MaxVelocity;
        expectedCarVelocity = 250;

        Assert.That(testCarVelocity,Is.EqualTo(expectedCarVelocity));
    }



}
