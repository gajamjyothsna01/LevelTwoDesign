using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float playerSpeed;
    private SpriteRenderer sp;
    SpriteRenderer render;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();    
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal") * playerSpeed;
            transform.Translate(new Vector3(inputX,transform.position.y,transform.position.z));
            rb.velocity = new Vector3(inputX, rb.velocity.y,0);
        if (inputX < 0)
            render.flipX = false;
        else
            render.flipX = false;
        animator.SetBool("IsWalk", inputX != 0);

    }
}
