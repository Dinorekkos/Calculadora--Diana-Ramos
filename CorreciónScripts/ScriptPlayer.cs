/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //MoverJugador
    private Rigidbody2D jugador;
    public float maxspeed;
    public  float mover;
   

    //VoltearJugador
    private bool voltearDerecha = true;
    private SpriteRenderer jugadorVoltea;
    
    //Saltar
    public LayerMask capasuelo;
    public Transform checarSuelo;
    public float revisarSuelo = 0.2f;
    public float saltoAltura;
    public bool puedoSaltar = true;
    public bool suelo = false;
    
    //anim Personaje 
    public Animator animController;

    public GameObject gmGO;
    public GameManager gmScript;
    
    
    
    
    
    
    
    void Start()
    {
        PlayerPrefs.DeleteAll();
        jugador = GetComponent<Rigidbody2D>();
        jugadorVoltea= GetComponent<SpriteRenderer>();
        animController = GetComponent<Animator>();

    }
    
    void Update()
    {
        
    }
    
    public void PuedesMoverte()
    {
        puedoSaltar = !puedoSaltar;
    }
    
    void Voltear()
    {
        voltearDerecha = !voltearDerecha;
        jugadorVoltea.flipX = !jugadorVoltea.flipX;
    }

    public void Mover()
    {
        jugador.velocity = new Vector2(mover * maxspeed, jugador.velocity.y);
    }


    public void FixedUpdate()
    {
        //MovimientoControles
        mover = Input.GetAxis("Horizontal");
        if (mover > 0 && !voltearDerecha)
        {
            Voltear();
        }
        else if (mover < 0 && voltearDerecha)
        {
            Voltear();
        }
        
        Mover();
        
        if (puedoSaltar && suelo && Input.GetAxis("Jump") > 0)
        {
            
            animController.SetTrigger("JumpPlayer");
            jugador.velocity = new Vector2(jugador.velocity.x, 0f);
            jugador.AddForce(new Vector2(0, saltoAltura), ForceMode2D.Impulse);
            suelo = false;
            animController.SetBool("JuanitoAvanzarbool", false);
            
        }
        suelo = Physics2D.OverlapCircle(checarSuelo.position, revisarSuelo, capasuelo);
        
        //AnimsMOtion
        AnimPersonaje();
    }


    public void AnimPersonaje()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animController.SetBool("JuanitoAvanzarbool", true); 
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animController.SetBool("JuanitoAvanzarbool", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animController.SetBool("JuanitoAvanzarbool", false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animController.SetBool("JuanitoAvanzarbool", false);
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Debug.Log("Moneda toco player");
            AddScore();
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("DeadzonePlayer"))
        {
            Debug.Log("JugadorTocoLava");
            gmScript.JuegOfinal();
        }

        if (other.gameObject.CompareTag("Bomb"))
        {
            Debug.Log("JugadorTocobbomba");
            Destroy(other.gameObject);
            gmScript.JuegOfinal();
        }
        
    }
    

    void AddScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 50);
    }
    
}

*/