using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody2D rb;
    bool hasHit;
    float startTime;
    float duration = 4.0f;
    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
   
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if(Time.time - startTime > duration){
            Destroy(this.gameObject);
        }

    
    }

    // private void OnCollisionEnter2D(Collision2D colision){
    //     hasHit = true;
    //     rb.velocity = Vector2.zero;
    //     rb.isKinematic = true;
    // }


}
