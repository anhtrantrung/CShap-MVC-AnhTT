using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai26RayCasHit : MonoBehaviour
{
    void Update()
    {
        RayCas();
    }

    public void RayCas()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit object: " + hit.collider.gameObject.name);
            }
        }
    }
}
