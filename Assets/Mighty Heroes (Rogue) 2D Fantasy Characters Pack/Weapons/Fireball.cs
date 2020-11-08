using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    
    float direction;
    float duration = 3f; 
    float startTime ; 

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time - startTime >= duration){
            Destroy(this.gameObject); 
        }
    }


    void doDamage(GameObject other){
        PlayerHealth health =  other.GetComponent<PlayerHealth>();

        float damage = Random.Range(15,20);
        health.takeDamage(damage);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player"){
            doDamage(other.gameObject);
            Destroy(this.gameObject); 
        }
    }


}
