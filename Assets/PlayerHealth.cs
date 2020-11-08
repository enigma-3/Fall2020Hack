using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    Animator animator;
    private float curHealth; 
    public float maxHealth; 


    public Slider slider;  




    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth; 
        slider.value = curHealth/maxHealth; 
        animator = GetComponent<Animator>();
    }

    public void takeDamage(float damage){

        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("damage"); 

        curHealth -= damage; 
        slider.value = curHealth/maxHealth;
        if (curHealth <= 0){
            print("player is dead");            
            //Player Dies
            animator.SetInteger("AnimState", 2);
            SceneManager.LoadScene("MainMenu");            
        }       
    }
}
