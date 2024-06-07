using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//using UnityEngine.Windows;

public class inputHandler : MonoBehaviour
{

    public TextMeshPro userInput;
    public string textInput;

    // Start is called before the first frame update
    void Start()
    {
        userInput = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    public string getInput()
    {
        textInput = userInput.text;
        return textInput;
    }
}
