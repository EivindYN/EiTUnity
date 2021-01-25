using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialMenuText : MonoBehaviour
{

    public List<string> optionsText;
    bool done = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update() {
        if (transform.childCount == optionsText.Count && !done) {
            AddText();
            done = true;
        }
    }

    void AddText() {
        for (int i = 0; i < optionsText.Count; i++) { 
            Transform textChild = transform.GetChild(i).transform.GetChild(1); 
            textChild.GetComponent<Text>().text = optionsText[i]; 
            textChild.GetComponent<RectTransform>().localRotation = Quaternion.Euler(0, 0, 90 - i * 360f / optionsText.Count); 
        } 
    }
}
