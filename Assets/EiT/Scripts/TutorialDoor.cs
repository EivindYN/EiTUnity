using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRTK.Controllables.PhysicsBased;

public class TutorialDoor : OptionScript
{
    bool unlocked;
    public GameObject doorControlTutorial;
    public GameObject door1;
    public GameObject door2;
    public override void HandleOption(int option, string optionString, GameObject gameObject) {
        if (option == 2) {
            Debug.Log("Unlocked door");
            unlocked = true;
            SwitchDoor();
        }
        if (option == 1 && unlocked) {
            Debug.Log("Opened door");
            unlocked = false;
            doorControlTutorial.GetComponent<VRTK_PhysicsRotator>().angleTarget = 110f;
            StartCoroutine("PlayGame");
        }
    }
    public void SwitchDoor() {
        door2.SetActive(door1.activeInHierarchy);
        door1.SetActive(!door1.activeInHierarchy);
    }
    IEnumerator PlayGame() {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("StoryScene");
    }
}
