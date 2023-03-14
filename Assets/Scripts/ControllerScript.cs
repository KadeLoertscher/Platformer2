using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ControllerScript : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public GameObject dialoguePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void showDialogue(string text)
    {
        dialoguePanel.SetActive(true);
        dialogueText.SetText(text);
    }

    public void hideDialogue()
    {
        dialoguePanel.SetActive(false);
    }

    public void changeScene(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
