using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = new Vector3(player.position.x , player.position.y , -10);
        transform.position = Vector3.Slerp(transform.position, newpos, speed * Time.deltaTime);
    }
}
