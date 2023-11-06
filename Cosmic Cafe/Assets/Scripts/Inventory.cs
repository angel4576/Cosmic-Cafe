using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{

    public TextMeshProUGUI[]ingredients;
    private int curLevel;
    // Start is called before the first frame update
    void Start()
    {
        curLevel = SceneVariableTracker.level;
    }

    // Update is called once per frame
    void Update()
    {
        int target = -1;
        for(int i = 0; i < 3; i++){
            if(SceneVariableTracker.recipe1[i] == PlayerMovement.held){
                target = i;
            }
        }
        ingredients[target].gameObject.SetActive(true);

    }


}
