using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_controller : MonoBehaviour
{

    public float movementSpeed = 20f;
    public Rigidbody2D rb;
    public GameObject player;
    public float distance = 5f;
    public int health;
    bool isMoving;
    bool isFromLeft;
    SpriteRenderer sR;
    Animator animator;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        sR = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("PlayerChar");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.transform.position.x);
        if (player.transform.position.x - rb.position.x == 0) movement.x = 0;
        else if (player.transform.position.x - rb.position.x > 0)
        {
            sR.flipX = false;
            movement.x = 10f;
            isMoving = true;
            isFromLeft = true;
        }
        else
        {
            sR.flipX = true;
            movement.x = -10f;
            isMoving = true;
            isFromLeft = false;
        }
        movement.y = 0f;
        if (isFromLeft && player.transform.position.x - distance < rb.position.x)
        {
            isMoving = false;
        }
        
        else if (!isFromLeft && player.transform.position.x + distance > rb.position.x)
        {
            isMoving = false;
        }
    }


    void FixedUpdate()
    {
        if(isMoving)
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
        animator.SetBool("isMoving", isMoving);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(health);
        if (health <= 0)
        {
            animator.SetBool("isMoving", false);
            animator.SetTrigger("isDead");
            Debug.Log("Bylem tu 1");
            StartCoroutine(TimeDead());
            Debug.Log("Bylem tu 2");
            
        }
    }

    IEnumerator TimeDead()
    {
        yield return new WaitForSeconds(5); //this will wait 5 seconds
        Destroy(gameObject);
    }

}
