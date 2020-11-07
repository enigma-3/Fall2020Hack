using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Ground here is the tag that we give to the floor of the map
        if (collision.collider.tag == "Ground"){
            Player.GetComponent<PlayerMoveScript>().isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground"){
            Player.GetComponent<PlayerMoveScript>().isGrounded = false;
        }
    }
}
