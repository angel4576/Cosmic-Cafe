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
<<<<<<< Updated upstream
                PlayerMovement.end1 = true;
=======
                PlayerMovement.end[0] = true;
>>>>>>> Stashed changes
                Debug.Log("Star reborn!");
            }
            if (intake == 2)
            {
<<<<<<< Updated upstream
                PlayerMovement.end2 = true;
=======
                PlayerMovement.end[1] = true;
>>>>>>> Stashed changes
                Debug.Log("Eldritch Moon descends!");
            }
            if (intake == 3)
            {
<<<<<<< Updated upstream
                PlayerMovement.end3 = true;
=======
                PlayerMovement.end[2] = true;
>>>>>>> Stashed changes
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
