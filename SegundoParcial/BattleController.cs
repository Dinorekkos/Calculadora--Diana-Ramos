using UnityEngine;
using System;

public class BattleController : MonoBehaviour {


    void Start()
    {
        // Inicialización de objetos
        Character generic = new Character("gen1", 10, 5, 2, 1, 2, 1, 0, 1);
        Debug.Log("El nombre del caracter es:  " + generic.Name);

        Enemy enemigo1 = new Enemy();
        enemigo1.Name = "ene1";
        Debug.Log("El nombre del enemigo es: " + enemigo1.Name);

        // Inicialización de objetos con constructor en clase Base: 
        // Se manda parámetro de constructor a la clase base para que se
        // Inicialice en la clase Character y no en Enemy
        Enemy enemigo2 = new Enemy("BaseEnemy");
        Debug.Log("El nombre del enemigo es: " + enemigo2.Name);
        enemigo2.createRandomStatus(10);
        Debug.Log("Los LifePoints del enemigo2 es: " + enemigo2.LifePoints);

        Enemy fool = new Enemy();
        fool.createFoolEnemy(5);
        Debug.Log("Este son los life points del fool enemy " + fool.LifePoints);


    }

    // A1 (3 PUNTOS)
    public void EnemyAmbush(Enemy enemy, Hero hero)
    {
        
        int ambush = (int)((enemy.Attack)*2)*(enemy.Speed/hero.Speed);
        hero.LifePoints -= Mathf.Abs(ambush); //12pts

        //---- En esta parte del código estamos comprobando que mientras no se cumpla la condición de abajo
        // (enemy.LifePoints>0 | hero.LifePoints > 0) No pasaremos a lo que está adentro
        while(enemy.LifePoints>0 | hero.LifePoints > 0)
        {
            //---- Aquí cuando el enemy.speed sea mayor o igual al Hero.Speed sacaremos un nuevo valor para
            // hero.LifePoints, mediante una operacion y eso se resta con los puntos ya prestablecidos 
            // de hero.lifepoints 
            if(enemy.Speed >= hero.Speed)
            {
                hero.LifePoints -= Mathf.Abs((enemy.Attack)*enemy.criticalHit(enemy.Lucky) - hero.Defense);  
                enemy.LifePoints -= Mathf.Abs((hero.Attack)*hero.criticalHit(hero.Lucky) - enemy.Defense); //
            }
            //---- Aquí se realiza un cambio, si enemy.speed es menor 0 igaul al hero speed, se va a ejecutar 
            // la siguiente parte del código para setear los nuevos valores a Enmy.lifepoints y a hero.lifepoints
            else
            {
                enemy.LifePoints -= Mathf.Abs((hero.Attack)*hero.criticalHit(hero.Lucky) - enemy.Defense);
                hero.LifePoints -= Mathf.Abs((enemy.Attack)*enemy.criticalHit(enemy.Lucky) - hero.Defense); //43
            }
        }
    }

    // A2 (2 PUNTOS)
    public void MagicAttack(Enemy enemy, Hero hero)
    {
        //- Aquí declaramos que si ambas condicionales se complen, setearemos los hero.lifepoints con la nueva operación
        // "Si enemy.speed es mayor o igual a hero.speed, Y si enemy.MagicPoints es mayor a 4, entonces cambia hero.lifePoints
        if(enemy.Speed >= hero.Speed && enemy.MagicPoints > 4)
        {
            hero.LifePoints -= Mathf.Abs((enemy.Attack)*2*enemy.criticalHit(enemy.Lucky) - hero.Defense);
        }
        // Misma situación con los condicionales, sin embargo esta sólo se va a complir si la condicional
        // de arriba es falsa
        else if(enemy.Speed < hero.Speed && hero.MagicPoints > 4)
        {
            enemy.LifePoints -= Mathf.Abs((hero.Attack)*hero.criticalHit(hero.Lucky) - enemy.Defense);
        }
    }

    // A3 (2 PUNTOS)
    public void CounterAttack(Enemy enemy, Hero hero)
    {
        if(hero.MagicPoints > 2)
        {            
            //Aquí ya se cumplió la condicional, y seteamos con los parámetros. Enemy.LifePoints y hero.MagicPoints
            // los parámetros que acompletan la operación ya tienen un valor asignado por la Clase Enemy y Hero que heredan
            // de la clase Character que tiene un constructor
            // La operación completa será  convertida a su valor absoluto para no tener un problema de bucle 
            enemy.LifePoints -= Mathf.Abs((int)((enemy.Attack)*hero.criticalHit(hero.Lucky)*1.5 - enemy.Defense)); //47
            hero.MagicPoints -= Mathf.Abs(2);
        }
        
    }
    
    // A4 (4 PUNTOS)
    public void UnitedAttack(Enemy enemy, Hero heroA, Hero heroB, Hero heroC)
    {
        // Aquí vamos a crear una condicional mayor o igual comparado con un número entero dividido entre 3
        // Este numero entero se sumarán entre los parametros de las declaraciones previas de clases 
        if(enemy.Speed >= (int)(heroA.Speed + heroB.Speed + heroC.Speed)/3)
        {
            System.Random random = new System.Random();
            
            // Una vez cumplida la condicional utilizarémos un Switch con 3 cases. Un randomClass sacará un
            //número random entre 0 y 2 para seleccionar cual de las operaciones realizar y setearl los Parámetros
            // de las clases  
            switch(random.Next(3))
            {
                case 0:
                heroA.LifePoints -= Mathf.Abs((enemy.Attack)*enemy.criticalHit(enemy.Lucky) - heroA.Defense);
                break;

                case 1:
                heroB.LifePoints -= Mathf.Abs((enemy.Attack)*enemy.criticalHit(enemy.Lucky) - heroB.Defense);
                break;

                case 2:
                heroC.LifePoints -= Mathf.Abs((enemy.Attack)*enemy.criticalHit(enemy.Lucky) - heroC.Defense);
                break;
            }            
        }
        //Esta parte sólo se ejecutará si la condición de arriba es false
        else
        {
            //Si dio false, setearemos el parámetro enemy.Lifepoints mediante una operación que entra a las diferentes
            //nuevas clases que se crearón dentro del método  
            enemy.LifePoints -= Mathf.Abs(((heroA.Attack)*heroA.criticalHit(heroA.Lucky) +
            (heroB.Attack)*heroB.criticalHit(heroB.Lucky) + 
            (heroC.Attack)*heroC.criticalHit(heroC.Lucky) - enemy.Defense));
        }
    }

    // B1 (1 PUNTO)
    public void DefendFromEnemy(Enemy enemy , Hero hero)
    {
        //-  Al llamar esta función inicializamos dos clases para acceder a sus parámetros que setearemos 
        // con otros valores int y una ecuación 
        hero.LifePoints = hero.LifePoints - ((enemy.Attack)*enemy.criticalHit(enemy.Lucky))/2;
    }

    // B2 (1 PUNTO)
    public void EscapeFromEnemies(Enemy enemyA, Enemy enemyB, Hero heroA,Hero heroB, Hero heroC)
    {
       bool succesfulyEscaped = false;
        //En esta funcón inicializamos 2 clases enemy y dos clases hero a las cuales accederémos a su parámetro y dentro 
        // del condicional realizarémos dos operaciones de la cual saldrán dos numeros enteros, los cuales comprobarán
        //el condicioal 
        if(enemyA.Speed + enemyB.Speed > heroA.Speed + heroB.Speed + heroC.Speed)
        {
            succesfulyEscaped = true;
        }
    }
    // B3 (1 PUNTO)
    public void GetExperience(Enemy enemy, Hero heroA, Hero heroB, Hero heroC)
    {
        // Aquí setearémos la experiencia de cada uno de los heroés inicializados en la parte de  arriba
        // esto mediante una operacion de un entero entre 3 
        heroA.Experience = (int)enemy.Level/3;
        heroB.Experience = (int)enemy.Level/3;
        heroC.Experience = (int)enemy.Level/3;
    }

}