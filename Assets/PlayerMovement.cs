using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D rb;

    public float playerSpeed;
    private SpriteRenderer sp;
    SpriteRenderer render;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // sp = GetComponent<SpriteRenderer>();    
        animator = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal") * playerSpeed;
           // transform.Translate(new Vector3(inputX,transform.position.y,transform.position.z));
            rb.velocity = new Vector3(inputX, rb.velocity.y);
        if (inputX < 0)
            render.flipX = true;
        else
            render.flipX = false;
        
        animator.SetBool("isWalk", inputX != 0);
      
    }
}
