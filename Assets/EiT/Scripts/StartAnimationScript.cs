using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimationScript : MonoBehaviour
{
    public GameObject playerCam;
    public List<GameObject> posList;
    public GameObject VRTK;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Animation");
    }

    IEnumerator Animation() {
        foreach(GameObject pos in posList) {
            yield return StartCoroutine(Move(pos, 1f));
            yield return new WaitForSeconds(0.5f);
        }
        VRTK.SetActive(true);
        Destroy(gameObject);
    }
    IEnumerator Move(GameObject pos, float timeMax) {
        float timer = 0f;
        Vector3 startPos = playerCam.transform.position;
        Quaternion startRot = playerCam.transform.rotation;
        while(timer < timeMax) {
            float deltaTime = Time.deltaTime;
            timer += deltaTime;
            playerCam.transform.position = Vector3.Lerp(startPos, pos.transform.position, timer / timeMax);
            playerCam.transform.rotation = Quaternion.Lerp(startRot, pos.transform.rotation, timer / timeMax);
            yield return new WaitForSeconds(deltaTime);
        }
    }
}
