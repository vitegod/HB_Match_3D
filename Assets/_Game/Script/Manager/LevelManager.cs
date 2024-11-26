using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : Singleton<LevelManager>
{
    Item itemSelecting;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            itemSelecting = GetSelectItem();
            Debug.Log(itemSelecting.name);
        }
        if (Input.GetMouseButton(0)) 
        {
            if (itemSelecting != null)
            {

            }
        }
        if (Input.GetMouseButtonUp(0)) 
        {
        
        }
    }

    private Item GetSelectItem()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);
        if (Physics.Raycast(ray.origin, ray.direction,out hit, 100))
        {
            return hit.collider.GetComponent<Item>();
        }
        return null;
    }
}
