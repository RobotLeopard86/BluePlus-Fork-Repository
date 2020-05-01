using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnfinishedMovementScript : MonoBehaviour
{
    private Rigidbody2D playerBody;
    float speed = 0.025f;
    public int maxJumpRadius = 10;
    // Start is called before the first frame update
    void Start()
    {
       playerBody = GameObject.Find("Player").GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement
        //Left
        if(Input.GetKey("a")){
            playerBody.transform.position = new Vector2(playerBody.transform.position.x - speed, playerBody.transform.position.y);
        }
        //Right
        if(Input.GetKey("d")){
            playerBody.transform.position = new Vector2(playerBody.transform.position.x + speed, playerBody.transform.position.y);
        }
        if(Input.GetKey("space")){
            //Add jump code here
        }
    }
}
