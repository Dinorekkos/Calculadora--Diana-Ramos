using NUnit.Framework;

public class TestControllerEj
{
    [Test]
   public void TestEnemyLevel_1()
   {
       //Arrange
       var enemyBarbarian = new Enemy();
       var level = 11;
       //Act
       enemyBarbarian.createBarbarianEnemy(11);
       //Assert
       Assert.That(enemyBarbarian.Level,Is.EqualTo(level));
    }

    [Test]
    public void TestEnemyLifePoints_2()
    {
        var enemyBarbarian = new Enemy();
        var expectedLifePoints = 5;
        enemyBarbarian.createBarbarianEnemy(11);
        Assert.LessOrEqual(enemyBarbarian.LifePoints, expectedLifePoints);
    }

    [Test]
    public void TestEnemyMagicPoints_3()
    {
        var enemyBarbarian = new Enemy();
        var expectedMagicPoints = 10;
        enemyBarbarian.createBarbarianEnemy(11);
        Assert.That(enemyBarbarian.MagicPoints,Is.SameAs(expectedMagicPoints));
    }
    [Test]
    public void TestEnemyStaminaPoints_4()
    {
        var enemyBarbarian = new Enemy();
        var expectedStaminaPoints = 5;
        enemyBarbarian.createBarbarianEnemy(11);
        Assert.LessOrEqual(enemyBarbarian.Stamina,expectedStaminaPoints);
    }

    [Test]
    public void TestEnemySpeed_5()
    {
        var enemyBarbarian = new Enemy();
        var expectedSpeedPoints =18;
        enemyBarbarian.createBarbarianEnemy(11);
        Assert.NotZero(enemyBarbarian.Speed);
    }

    [Test]
    public void TestEnemyDefense_6() 
    {
        var enemyBarbarian = new Enemy();
        var expectedDefensePoints = 3;
        enemyBarbarian.createBarbarianEnemy(11);
        Assert.Positive(enemyBarbarian.Defense);
    }

    [Test]
    public void TestEnemyAttack_7()
    {
        var enemyBarbarian = new Enemy();
        var expectedAttackPoints = 15;
        enemyBarbarian.createBarbarianEnemy(11);
        Assert.Greater(enemyBarbarian.Attack, expectedAttackPoints);
    }



}
