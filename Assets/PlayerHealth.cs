using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private float curHealth; 
    public float maxHealth; 


    public Slider slider;  




    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth; 
        slider.value = curHealth/maxHealth; 
    }

    public void takeDamage(float damage){

        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("damage"); 

        curHealth -= damage; 
        slider.value = curHealth/maxHealth;
        if (curHealth < 0){
            curHealth = 0; 
            //Player Dies
            
        }       
    }
}
