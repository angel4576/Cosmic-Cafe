using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BlackHole : MonoBehaviour
{

    public GameObject player;
    public Transform destination;
    public PlayerMovement movement;
    public bool isAccessed;
    public bool isPlayerInside;
    // public float freezeTime;
    // private float freezeEndTime;

    // Start is called before the first frame update
    void Start()
    {
        movement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
       if(movement.isInteract && isPlayerInside){
            player.transform.position = destination.position;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        isPlayerInside = true;
        

        // isAccessed = true;

        // freezeEndTime = Time.time + freezeTime; 
    }

    private void OnTriggerExit2D(Collider2D other) {
        isPlayerInside = false;
    }
}

