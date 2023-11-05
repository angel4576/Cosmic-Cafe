using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BlackHole : MonoBehaviour
{

    public Transform destination;
    public PlayerMovement movement;
    bool isRecentlyTeleported;
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
        
        
    }
   
    // why?
    // public IEnumerator CoolDown(){
    //     isRecentlyTeleported = true;
    //     yield return new WaitForSeconds(1f);
    //     isRecentlyTeleported = false;
    // }

    private void OnTriggerEnter2D(Collider2D other) {
        if(!movement.isRecentlyTeleported){
            other.transform.position = destination.position;
            StartCoroutine(movement.CoolDown());
            //StartCoroutine(CoolDown());
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
    }
}

