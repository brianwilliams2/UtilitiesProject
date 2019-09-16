using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCode : MonoBehaviour
{
    //Properties are private by default
    public InputField inputText;
    public Text outputText;
    public Button textButton;

    // Start is called before the first frame update
    void Start()
    {
       outputText.text = " ";
    }

    public void ProcessText()
    {        
        outputText.text = Utilities.ProcessText(inputText.text);
    }
    
}
