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

<<<<<<< Updated upstream
    public static int held;
    public static bool end1 = false;
    public static bool end2 = false;
    public static bool end3 = false;
    public static bool end4 = false;
    public static bool end5 = false;
    public static bool end6 = false;
    public static bool end7 = false;
    public static bool end8 = false;
    public static bool end9 = false;
=======
    private int gFieldLayer;

    public static int held;
    public static bool[] end = new bool[9];
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
<<<<<<< Updated upstream
        held = 0;
=======
        gFieldLayer = LayerMask.NameToLayer("Gravity Field");

        held = 0;
        for (int i = 0; i < 9; i++)
        {
            end[i] = false;
        }
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        isInteract = Input.GetButton("Interact");
        if(isInteract){
            //Debug.Log("Interact");
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
