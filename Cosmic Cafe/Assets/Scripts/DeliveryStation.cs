using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeliveryStation : MonoBehaviour
{
    private Rigidbody2D rb;
    private int[] recipe = new int[3];
    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        if(SceneVariableTracker.level == 1)
        {
            recipe = SceneVariableTracker.recipe1;
        }
        if (SceneVariableTracker.level == 2)
        {
            recipe = SceneVariableTracker.recipe2;
        }
        if (SceneVariableTracker.level == 3)
        {
            recipe = SceneVariableTracker.recipe3;
        }
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        SceneVariableTracker.roundTimer -= Time.deltaTime;
        //Debug.Log(SceneVariableTracker.roundTimer);

        if (SceneVariableTracker.roundTimer <= 0.0f)
        {
            timerEnded();
        }

        if (Input.GetKeyDown(KeyCode.E) && triggered && PlayerMovement.end[recipe[0]] && PlayerMovement.end[recipe[1]] && PlayerMovement.end[recipe[2]])
        {
            PlayerMovement.held = 0;
            Debug.Log("Victory!");
            SceneVariableTracker.level++;
            for(int i = 0; i<9; i++)
            {
                PlayerMovement.end[i] = false;
            }
            if(SceneVariableTracker.level == 2)
            {
                recipe = SceneVariableTracker.recipe2;
                SceneManager.LoadScene("Round2");
                SceneVariableTracker.roundTimer = 40.0f;
            }
            else if(SceneVariableTracker.level == 3)
            {
                recipe = SceneVariableTracker.recipe3;
                SceneManager.LoadScene("Round3");
                SceneVariableTracker.roundTimer = 40.0f;
            }
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

    private void timerEnded()
    {
        SceneManager.LoadScene("Gameover Screen");
    }
}
