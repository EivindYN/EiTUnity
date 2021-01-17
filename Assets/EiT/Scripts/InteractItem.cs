using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables.PhysicsBased;

public class InteractItem : MonoBehaviour
{
    public GameObject key;
    public GameObject doorKnob;
    public GameObject doorControl;
    bool doorLocked = true;
    public void Interact(GameObject item) {
        PickUpItem pickUpItem = GetComponent<PickUpItem>();
        if (item == doorKnob && doorLocked) {
            if (pickUpItem.items.Contains(key)) {
                Debug.Log("Used key to open door");
                doorLocked = false;
                doorControl.GetComponent<VRTK_PhysicsRotator>().angleTarget = 110f;
            } else {
                Debug.Log("Door is locked");
            }
        }
            
    }
}
