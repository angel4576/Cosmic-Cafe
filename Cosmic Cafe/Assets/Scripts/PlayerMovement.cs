using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Speed")]
    private float xDirection;
    private float yDirection;
    public float speed = 8f;
    public float speedDivisor = 3f;

    private Rigidbody2D rb;
    public Transform destination;
    
    [Header("Player Status")]
    public bool isInteract;
    public bool isRecentlyTeleported;

    private int gFieldLayer;
    
    //public int[]arr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        gFieldLayer = LayerMask.NameToLayer("Gravity Field");
    }

    // Update is called once per frame
    void Update()
    {
        isInteract = Input.GetButton("Interact");
        if (isInteract)
        {
            Debug.Log("Interact");
        }
    }

    void FixedUpdate()
    {
        GroundMovement();
    }

    public IEnumerator CoolDown()
    {
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

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.layer == gFieldLayer)
        {
            Debug.Log("Slow Down!");
            speed /= speedDivisor;
        }

    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.layer == gFieldLayer)
        {
            Debug.Log("Recover speed!");
            speed *= speedDivisor;
        }    
    }

}
