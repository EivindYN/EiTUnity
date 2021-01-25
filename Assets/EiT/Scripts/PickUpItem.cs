using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public static List<string> items = new List<string>();
    public void PickUp(GameObject item) {
        item = item.transform.parent.gameObject;
        if (GetComponent<InteractItem>() != null) {
            if (item.transform.parent.GetSiblingIndex() != GetComponent<InteractItem>().pos) {
                Debug.Log("Tried to pick up item outside your room (" + item.transform.parent.GetSiblingIndex() + " vs " + GetComponent<InteractItem>().pos + ")");
                return;
            }
            AddToDo("Picked up " + item.name);
            Debug.Log("Picked up " + item.name);
        } else { //Hacky
            GetComponent<TutorialDoor>().SwitchDoor();
        }
        Destroy(item);
    }

    public void AddToDo(string txt) {
        if (!items.Contains(txt)) {
            Debug.Log("ADDTODO: " + txt);
            items.Add(txt);
        } else {
            Debug.Log("Tried ADDTODO: " + txt);
        }
    }
}
