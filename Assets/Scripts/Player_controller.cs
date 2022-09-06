using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player_controller : MonoBehaviour
{
    Animator animator;
    SpriteRenderer spriteRenderer;
    SpriteRenderer spriteRendererSword;
    Transform point;
    Transform point2;
    public GameObject enemy;

    public Transform attackPos;
    public LayerMask whatIsEnemies;

    float distance_point_player;
    public float attackRange;
    public int damage;
    bool isLeft = true;

    void Awake()
    {
        point = GetComponent<Transform>();
        point2 = transform.Find("Point").GetComponent<Transform>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRendererSword = transform.Find("Sword").GetComponent<SpriteRenderer>();

        
    }
    void Start()
    {
        animator = GetComponent<Animator>();
        distance_point_player = point.position.x - point2.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                if (touchPosition.x > Camera.main.transform.position.x && isLeft == true)
                {
                    point2.position = new Vector3(point.position.x + (distance_point_player) , point2.position.y, 0);
                    Debug.Log(point2.position.x);
                    spriteRenderer.flipX = !spriteRenderer.flipX;
                    spriteRendererSword.flipX = spriteRenderer.flipX;
                    isLeft = false;
                }
                if (touchPosition.x <= Camera.main.transform.position.x && isLeft == false)
                {
                    point2.position = new Vector3(point.position.x -(distance_point_player), point2.position.y, 0);
                    Debug.Log(point2.position.x);
                    spriteRenderer.flipX = !spriteRenderer.flipX;
                    spriteRendererSword.flipX = spriteRenderer.flipX;

                    isLeft = true;
                }
                animator.SetTrigger("attack");

                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for(int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy_controller>().TakeDamage(damage);
                }

            }

        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }


}
