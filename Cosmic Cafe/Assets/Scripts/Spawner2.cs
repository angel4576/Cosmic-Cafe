using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    private bool triggered = false;
    private Rigidbody2D rb;
    private int timesTriggered = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggered && PlayerMovement.held == 0)
        {
            PlayerMovement.held+= timesTriggered;
            timesTriggered++;
            Debug.Log(PlayerMovement.held);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Triggered!");
            triggered = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Exited!");
            triggered = false;
        }
    }
}