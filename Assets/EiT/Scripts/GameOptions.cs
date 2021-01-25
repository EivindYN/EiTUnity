using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOptions : OptionScript
{
    public GameObject phone;
    public GameObject siblingDoor;
    public override void HandleOption(int option, string optionString, GameObject gameObject) {
        GameObject item = gameObject;
        if (item.transform.parent.GetSiblingIndex() != GetComponent<InteractItem>().pos) {
            Debug.Log("Tried to pick up item outside your room (" + item.transform.parent.GetSiblingIndex() + " vs " + GetComponent<InteractItem>().pos + ")");
            return;
        }
        if (gameObject == phone) {
            GetComponent<PickUpItem>().AddToDo(optionString);
            Destroy(phone);
        }
        if (gameObject == siblingDoor) {
            GetComponent<PickUpItem>().AddToDo(optionString);
            Destroy(siblingDoor);
        }
    }
}
