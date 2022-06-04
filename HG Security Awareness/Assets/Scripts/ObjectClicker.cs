using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 100.0f))
            {
                if(hit.collider != null)
                {
                    if(hit.collider.tag == "Laptop"){
                        Debug.Log("You clicked on laptop");
                        animator.SetBool("laptopclick", true);
                    }
                }
            }
        }
    }
    
}
