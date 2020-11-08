using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float curHealth; 
    public float maxHealth; 


    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth; 
    }

    public void takeDamage(float damage){
        curHealth -= damage; 
        Debug.Log(curHealth);
        if (curHealth < 0){
            curHealth = 0; 
            //Player Dies
            Debug.Log("Dies"); 
        }       
    }

}
