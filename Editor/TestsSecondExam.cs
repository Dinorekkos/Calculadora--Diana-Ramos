using System.Collections;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools;

public class TestsSecondExam 
{
    //A1 3puntos
    [UnityTest]
    public IEnumerator TestEnemyAmbus_A1_1()
    {   
        var battleClassGO = new GameObject(); 
        var enemyAmbush = battleClassGO.AddComponent<BattleController>();
        var enemy = new Enemy();
        var hero = new Hero();
        var level = 12;
        enemy.createBarbarianEnemy(level);
        hero.createBarbarianHero(level);
        enemyAmbush.EnemyAmbush(enemy,hero);
        yield return null;
        
        Assert.That(enemy.LifePoints, Is.LessThan(100));
    } 
    
    
     [UnityTest]
    public IEnumerator TestEnemyAmbus_A1_2()
    {   
        var battleClassGO = new GameObject(); 
        var enemyAmbush = battleClassGO.AddComponent<BattleController>();
        var enemy = new Enemy();
        var hero = new Hero();
        var level = 12;

        enemy.createBarbarianEnemy(level);
        hero.createBarbarianHero(level);

        enemyAmbush.EnemyAmbush(enemy,hero);
        yield return null;
        
        Assert.That(hero.LifePoints,Is.LessThanOrEqualTo(43));
    } 
    
    //B2 1 punto
     [UnityTest]
    public IEnumerator TestEnemyAmbus_B_2()
    {   
        var battleClassGO = new GameObject(); 
        var enemyAmbush = battleClassGO.AddComponent<BattleController>();

        var firstResult = 0;
        var secondResult = 0;

        var enemyA = new Enemy();
        var enemyB = new Enemy();

        var heroA = new Hero();
        var heroB = new Hero();
        var heroC = new Hero();
        var level = 32;

        enemyA.createBarbarianEnemy(level);
        enemyB.createBarbarianEnemy(level);
        heroA.createBarbarianHero(level);
        heroB.createBarbarianHero(level);
        heroC.createBarbarianHero(level);

        enemyA.Speed = 22;
        enemyB.Speed = 4;
        heroA.Speed = 12;
        heroB.Speed = 6;
        heroC.Speed = 15;

        firstResult = enemyA.Speed + enemyB.Speed;
        secondResult = heroA.Speed + heroB.Speed + heroC.Speed;
        
        enemyAmbush.EscapeFromEnemies(enemyA, enemyB, heroA, heroB,heroC);
        yield return null;
        
        Assert.Less(firstResult, secondResult);
    } 
    
    //A3 2 puntos
    [UnityTest]
    public IEnumerator TestCounterAttack_A3_1()
    {
        var battleClassGO = new GameObject(); 
        var magicAttackMD = battleClassGO.AddComponent<BattleController>();
        var enemy = new Enemy();
        var hero = new Hero();
        var level = 12;
         
        enemy.createBarbarianEnemy(level);
        hero.createBarbarianHero(level);

        magicAttackMD.CounterAttack(enemy,hero);
        yield return null;

        Assert.That(enemy.LifePoints, Is.LessThan(52));
    } 
      [UnityTest]
    public IEnumerator TestCounterAttack_A3_2()
    {
        var battleClassGO = new GameObject(); 
        var magicAttackMD = battleClassGO.AddComponent<BattleController>();
        var enemy = new Enemy();
        var hero = new Hero();
        var level = 12;
         
        enemy.createBarbarianEnemy(level);
        hero.createBarbarianHero(level);

        magicAttackMD.CounterAttack(enemy,hero);
        yield return null;

        Assert.That(hero.MagicPoints, Is.InRange(2,10));
    } 
   // A4 4 puntos
   [UnityTest]
   public IEnumerator TestUnitedAttack_A4_1()
   {
       var battleClassGO = new GameObject();
       var uitedAttack = battleClassGO.AddComponent<BattleController>();
       var enemyA = new Enemy();
       var heroA = new Hero();
       var heroB = new Hero();
       var heroC = new Hero();
       var level = 12;

       enemyA.createBarbarianEnemy(level);
       heroA.createBarbarianHero(level);
       heroB.createBarbarianHero(level);
       heroC.createBarbarianHero(level);

       uitedAttack.UnitedAttack(enemyA, heroA,heroB,heroC);    
       yield return null;

       Assert.That(heroA.LifePoints, Is.InRange(-10,29));

   }

    [UnityTest]
   public IEnumerator TestUnitedAttack_A4_2()
   {
       var battleClassGO = new GameObject();
       var uitedAttack = battleClassGO.AddComponent<BattleController>();
       var enemyA = new Enemy();
       var heroA = new Hero();
       var heroB = new Hero();
       var heroC = new Hero();
       var level = 12;

       enemyA.createBarbarianEnemy(level);
       heroA.createBarbarianHero(level);
       heroB.createBarbarianHero(20);
       heroC.createBarbarianHero(level);

       uitedAttack.UnitedAttack(enemyA, heroA,heroB,heroC);    
       yield return null;

       Assert.That(heroB.LifePoints, Is.InRange(17,50));

   }

  [UnityTest]
   public IEnumerator TestUnitedAttack_A4_3()
   {
       var battleClassGO = new GameObject();
       var uitedAttack = battleClassGO.AddComponent<BattleController>();
       var enemyA = new Enemy();
       var heroA = new Hero();
       var heroB = new Hero();
       var heroC = new Hero();
       var level = 12;

       enemyA.createBarbarianEnemy(level);
       heroA.createBarbarianHero(level);
       heroB.createBarbarianHero(15);
       heroC.createBarbarianHero(level);

       uitedAttack.UnitedAttack(enemyA, heroA,heroB,heroC);    
       yield return null;

       Assert.That(heroB.LifePoints, Is.InRange(10,36));

   }

 [UnityTest]
   public IEnumerator TestUnitedAttack_A4_4()
   {
       var battleClassGO = new GameObject();
       var uitedAttack = battleClassGO.AddComponent<BattleController>();
       var enemyA = new Enemy();
       var heroA = new Hero();
       var heroB = new Hero();
       var heroC = new Hero();
       var level = 12;

       enemyA.createBarbarianEnemy(level);
       heroA.createBarbarianHero(level);
       heroB.createBarbarianHero(level);
       heroC.createBarbarianHero(32);

       uitedAttack.UnitedAttack(enemyA, heroA,heroB,heroC);    
       yield return null;

       Assert.That(heroB.LifePoints, Is.InRange(9,30));

   }



}
