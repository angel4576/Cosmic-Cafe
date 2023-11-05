using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static int held = 0;
    private bool triggered = false;
    private Rigidbody2D rb;
    private int intake = 0;
    private bool operationDone = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggered && PlayerMovement.held != 0)
        {
            intake = PlayerMovement.held;
            PlayerMovement.held = 0;
            Debug.Log(PlayerMovement.held);
            

            Debug.Log("Operation starts");
            StartCoroutine(OperatingTask());
        }

        if (Input.GetKeyDown(KeyCode.E) && triggered && operationDone)
        {
            if(intake == 1)
            {
                PlayerMovement.end1 = true;
                Debug.Log("Star reborn!");
            }
            if (intake == 2)
            {
                PlayerMovement.end2 = true;
                Debug.Log("Eldritch Moon descends!");
            }
            if (intake == 3)
            {
                PlayerMovement.end3 = true;
                Debug.Log("Gas Giant coalesces!");
            }
        }
    }

    public IEnumerator OperatingTask()
    {
        yield return new WaitForSeconds(5.0f);
        Debug.Log("Time's up!");
        operationDone = true;
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
