using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    Animator animator;
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    private bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        ChangeState();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump(){
        if (Input.GetButtonDown("Jump") && isGrounded == true){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }

    void ChangeState(){
        if (Input.GetKey(KeyCode.D))
        {
            if(!facingRight){
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
                facingRight = true;
            }

            animator.SetInteger("AnimState", 1);            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if(facingRight){
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
                facingRight = false;
            }

            animator.SetInteger("AnimState", 1);            
        }
        else
        {
            animator.SetInteger("AnimState", 0);
        }
    }
}
