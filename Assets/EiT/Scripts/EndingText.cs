using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingText : MonoBehaviour
{
    public GameObject textObject;
    // Start is called before the first frame update
    void Start()
    {
        string endingText = "Thanks for playing!\n\nYou decided to do:\n";
        foreach(string stuffDone in PickUpItem.items) {
            endingText += stuffDone + "\n";
        }
        if (PickUpItem.items.Count > 5) {
            endingText += "\nYou did a lot of stuff yo, maybe do less stuff next time bruh";
        } else {
            endingText += "\nYou did few stuff yo, maybe do some more stuff next time bruh";
        }
        textObject.GetComponent<Text>().text = endingText;
        textObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
