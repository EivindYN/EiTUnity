using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    public Text storyText;
    public Text spaceToStart;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeMultiple());
    }

    IEnumerator FadeMultiple() {
        yield return Fade(storyText);
        yield return Fade(spaceToStart);
    }

    IEnumerator Fade(Text text) {
        float timer = 0f;
        float timeMax = 1f;
        while (timer < timeMax){
            float deltaTime = Time.deltaTime;
            timer += deltaTime;
            text.color = new Color(text.color.r, text.color.g, text.color.b, timer / timeMax);
            yield return new WaitForSeconds(deltaTime);

        }
    }
}
