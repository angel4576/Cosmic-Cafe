using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float xDirection;
    private float yDirection;
    private Rigidbody2D rb;
    public float speed = 8f;
    public bool isInteract;
    public bool isRecentlyTeleported;
    public Transform destination;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isInteract = Input.GetButton("Interact");
        if(isInteract){
            Debug.Log("Interact");
        }
    }

    void FixedUpdate() {
        GroundMovement();
    }

    public IEnumerator CoolDown(){
        isRecentlyTeleported = true;
        yield return new WaitForSeconds(1f);
        isRecentlyTeleported = false;
    }

    void GroundMovement()
    {
        xDirection = Input.GetAxis("Horizontal");
        yDirection = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(xDirection * speed, yDirection * speed);
        // rb.AddForce(new Vector2(xDirection * speed, yDirection * speed));
    }

    // private void OnTriggerEnter2D(Collider2D other) {
        
    //     if(isInteract){
    //         transform.position = destination.position;
    //     }
    // }
    
}
