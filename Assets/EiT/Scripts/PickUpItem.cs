using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public void PickUp(GameObject item) {
        item = item.transform.parent.gameObject;
        items.Add(item);
        Debug.Log("Picked up " + item.name);
        Destroy(item);
    }
}
