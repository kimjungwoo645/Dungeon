using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    bool OnOff = true;

    public GameObject inventory;

    private void Start()
    {
        inventory.SetActive(false);
    }

    public void InventoryOnOff()
    {
        if(OnOff)
        {
            inventory.SetActive(true);
            OnOff = !OnOff;
        }
        else if(!OnOff)
        {
            inventory.SetActive(false);
            OnOff = !OnOff;
        }
    }
}
