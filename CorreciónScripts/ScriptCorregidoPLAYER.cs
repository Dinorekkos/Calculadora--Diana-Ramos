using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //Move Player.
    private Rigidbody2D playerRgb;
    public float maxSpeed;
    public  float movementPlayer;
   
    //Turn Player.
    private bool turnRight = true;
    private SpriteRenderer turnPlayerSpriteRenderer;
    
    //Jump Player.
    public bool floor = false;
    public LayerMask layerfloor;
    public Transform checkFloor;
    public float areaFloor = 0.2f;
    public float highJump;
    public bool canJump = true;
    
    
    //Anim Player.
    public Animator animController;
    public GameObject gmGO;
    public GameManager gmScript;
    

    void Start()
    {
        PlayerPrefs.DeleteAll();
        playerRgb = GetComponent<Rigidbody2D>();
        turnPlayerSpriteRenderer= GetComponent<SpriteRenderer>();
        animController = GetComponent<Animator>();
    }

    
    public void CanMove()
    {
        canJump = !canJump;
    }
    

    void FlipPlayer()
    {
        turnRight = !turnRight;
        turnPlayerSpriteRenderer.flipX = !turnPlayerSpriteRenderer.flipX;
    }


    public void MovePlayer()
    {
        playerRgb.velocity = new Vector2(movementPlayer * maxSpeed, playerRgb.velocity.y);
    }


    public void FixedUpdate()
    {
        //Control Movement.
        movementPlayer = Input.GetAxis("Horizontal");

        if (movementPlayer > 0 && !turnRight)
        {
            FlipPlayer();
        }
        else if (movementPlayer < 0 && turnRight)
        {
            FlipPlayer();
        }
        MovePlayer();
        
        if (canJump && floor && Input.GetAxis("Jump") > 0)
        {
            animController.SetTrigger("JumpPlayer");
            playerRgb.velocity = new Vector2(playerRgb.velocity.x, 0f);
            playerRgb.AddForce(new Vector2(0, highJump), ForceMode2D.Impulse);
            floor = false;
            animController.SetBool("JuanitoAvanzarbool", false); 
        }
        floor = Physics2D.OverlapCircle(checkFloor.position, areaFloor, layerfloor);
        
        //Anims Motion.
        AnimMovement();
    }


    public void AnimMovement()
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
            gmScript.GameOff();
        }
        if (other.gameObject.CompareTag("Bomb"))
        {
            Debug.Log("JugadorTocobbomba");
            Destroy(other.gameObject);
            gmScript.GameOff();
        }
    }
    
    void AddScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 50);
    }
}

