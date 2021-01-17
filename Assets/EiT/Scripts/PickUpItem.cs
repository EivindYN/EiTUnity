using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public void PickUp(GameObject item) {
        items.Add(item);
        Debug.Log("Picked up " + item.name);
        Destroy(item);
    }
}
