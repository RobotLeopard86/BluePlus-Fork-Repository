using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlayerInteractionScript : MonoBehaviour
{
    private Rigidbody2D playerbody;
    private Collider2D playercollider;
    private int maxJumpRadius;
    private Object platform;
    private Object previous;
    private int minJumpRadius;
    private
    // Start is called before the first frame update
    void Start(){
        playerbody = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        playercollider = GameObject.Find("Player").GetComponent<Collider2D>();
        //maxJumpRadius = <your value>;
        minJumpRadius = 3;
    }

    // Update is called once per frame
    void Update(){
        //Kill app if player falls
        if(playerbody.transform.position.y <= -7f){
            QuitGame();
        }
        /*
        if(playercollider.IsTouching(GameObject.Find("StarterPlatform2").GetComponent<Collider2D>())){
            Destroy(GameObject.Find("StarterPlatform1"));
            platform = Object.Instantiate(GameObject.Find("StarterPlatform2"), new Vector3(Random.Range(minJumpRadius, maxJumpRadius), Random.Range(GameObject.Find("StarterPlatform2").transform.position.y + 6, GameObject.Find("StarterPlatform2").transform.position.y - 6), 0), new Quaternion(0f, 0f, 0f, 1), true);
        }
        if(playercollider.IsTouching(platform.GetComponent<Collider2D>()) && GameObject.Find("StarterPlatform2")){
            Destroy(GameObject.Find("StarterPlatform2"));
            previous = platform;
            platform = Object.Instantiate(previous, new Vector3(Random.Range(minJumpRadius, maxJumpRadius), Random.Range(previous.transform.position.y + 6, previous.transform.position.y - 6), 0), new Quaternion(0f, 0f, 0f, 1), true);
        } else if(playercollider.IsTouching(platform.GetComponent<Collider2D>())){
            Destroy(previous);
            previous = platform;
            platform = Object.Instantiate(previous, new Vector3(Random.Range(minJumpRadius, maxJumpRadius), Random.Range(previous.transform.position.y + 6, previous.transform.position.y - 6), 0), new Quaternion(0f, 0f, 0f, 1), true);
        }
        */
    }

    void QuitGame(){
        Application.Quit();
    }
}
