using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10.0f;
    public GameObject killAura;
    private Vector2 moveVector;
    private bool attacking;
    private float corutineTime = 0;
    public float attackTime = 10;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        killAura.SetActive(false);
        attacking = false;
    }

    void Update()
    {
        if (corutineTime > 0) corutineTime -= Time.deltaTime;
        if (attacking && corutineTime <= 0) Attack(false);
        if (Input.GetButtonDown("Jump"))
        {
            Attack(true);
        }
        if (!attacking)
        {
            moveVector.x = Input.GetAxis("Horizontal");
            moveVector.y = Input.GetAxis("Vertical");
            rb.MovePosition(rb.position + moveVector.normalized * speed * Time.deltaTime);

        }
    }


    void Attack(bool attack)
    {
        attacking = attack;
        if (attack)
        {
            corutineTime = attackTime;
            killAura.SetActive(true);
        }
        else
        {
            killAura.SetActive(false);
            corutineTime = 0;
        }
    }
}