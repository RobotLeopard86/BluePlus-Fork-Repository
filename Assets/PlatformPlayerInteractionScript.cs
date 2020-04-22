using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlayerInteractionScript : MonoBehaviour
{
    private Rigidbody2D playerbody;
    private Collider2D playercollider;
    private int jumpRadius;
    // Start is called before the first frame update
    void Start()
    {
        playerbody = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        playercollider = GameObject.Find("Player").GetComponent<Collider2D>();
        //jumpRadius = 
    }

    // Update is called once per frame
    void Update()
    {
        //Is touching platform?
        if(!playercollider.IsTouching(GameObject.Find("StarterPlatform1").GetComponent<Collider2D>()) || !playercollider.IsTouching(GameObject.Find("StarterPlatform2").GetComponent<Collider2D>())){
            playerbody.gravityScale = 1;
        }
        //Kill app if player falls
        if(playerbody.transform.position.y <= -7f){
            Application.Quit();
        }
    }
}
