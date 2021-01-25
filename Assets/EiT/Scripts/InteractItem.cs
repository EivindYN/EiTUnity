using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRTK.Controllables.PhysicsBased;

public class InteractItem : MonoBehaviour
{
    public GameObject doorKnobPos1;
    public GameObject positions;
    public GameObject stairs;
    public GameObject switchboard;
    public GameObject leave;
    public GameObject doorExit;
    public GameObject doorGarage;
    public GameObject doorBasement;
    

    public GameObject player;
    bool doorLocked = true;
    public int pos = 1;
    public void Interact(GameObject item) {
        PickUpItem pickUpItem = GetComponent<PickUpItem>();
        item = item.transform.parent.gameObject;
        if (item == doorKnobPos1) {
            GetComponent<PickUpItem>().AddToDo("Move to corridor");
            pos = 2;
            player.transform.position = positions.transform.GetChild(pos).transform.position;
        }
        if (item == stairs) {
            GetComponent<PickUpItem>().AddToDo("Move to living room");
            pos = 3;
            player.transform.position = positions.transform.GetChild(pos).transform.position;
        }
        if (item == switchboard) {
            GetComponent<PickUpItem>().AddToDo("Turn off switchboard");
            Destroy(switchboard.transform.GetChild(0).gameObject);
        }
        if (item == leave) {
            GetComponent<PickUpItem>().AddToDo("Move to hallway");
            pos = 4;
            player.transform.position = positions.transform.GetChild(pos).transform.position;
        }
        if (item == doorExit) {
            GetComponent<PickUpItem>().AddToDo("Left house by door");
            EnterEndingScene();
        }
        if (item == doorGarage) {
            GetComponent<PickUpItem>().AddToDo("Left house by car");
            EnterEndingScene();
        }
        if (item == doorBasement) {
            GetComponent<PickUpItem>().AddToDo("Entered basement and died (-_-)");
            EnterEndingScene();
        }

            
    }
    void EnterEndingScene() {
        SceneManager.LoadScene("EndingScene");
    }
}
