using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRTK.Controllables.PhysicsBased;

public class InteractItem : MonoBehaviour
{
    public GameObject keyTutorial;
    public GameObject doorKnobTutorial;
    public GameObject doorControlTutorial;
    public GameObject doorKnobPos1;
    public GameObject positions;

    public GameObject player;
    bool doorLocked = true;
    public void Interact(GameObject item) {
        PickUpItem pickUpItem = GetComponent<PickUpItem>();
        if (item == doorKnobTutorial && doorLocked) {
            if (pickUpItem.items.Contains(keyTutorial)) {
                Debug.Log("Used key to open door");
                doorLocked = false;
                doorControlTutorial.GetComponent<VRTK_PhysicsRotator>().angleTarget = 110f;
                StartCoroutine("PlayGame");
            } else {
                Debug.Log("Door is locked");
            }
        }
        item = item.transform.parent.gameObject;
        if (item == doorKnobPos1) {
            player.transform.position = positions.transform.GetChild(1).transform.position;
        }
            
    }
    IEnumerator PlayGame() {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("GameScene");
    }
}
