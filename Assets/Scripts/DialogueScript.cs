using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    public string dialogue;
    private ControllerScript gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<ControllerScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.showDialogue(dialogue);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameController.hideDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
