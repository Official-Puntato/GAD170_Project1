using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private PlayerScript player;
    [SerializeField]
    private GameObject game_text_obj;
    private TMP_Text game_text;
    /*[SerializeField]
    private TMP_InputField userInputField;
    private string userInput;*/
    // Start is called before the first frame update
    void Start()
    {
        game_text = game_text_obj.GetComponent<TMP_Text>();
        game_text.SetText("Test");
        game_text.maxVisibleLines = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.exp += 100;
        }
        /*if (Input.GetButtonDown("Submit"))
        {
            Debug.Log(userInputField.text);
            userInput = userInputField.text;
            Debug.Log(userInput);
            userInputField.text = string.Empty;
            Debug.Log(userInputField.text);
            userInputField.ActivateInputField();
        }
        if (userInput == "test")
        {
            game_text.SetText($"Test{Random.Range(1, 10)}\n{game_text.text}");
            userInput = string.Empty;
        }
        if (userInput == "level up")
        {
            player.exp += 100;
            userInput = string.Empty;
        }*/

        player.LevelUp();
        
    }
}
