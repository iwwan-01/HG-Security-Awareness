using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public Animator cameraAnimator;
    public Animator cabinetAnimator;
    public Animator secondCabinetAnimator;
    public Animator lastCabinetAnimator;
    public Animator tabletAnimator;
    public GameObject Canvas1;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 100.0f))
                Canvas1.gameObject.SetActive(true);

            {
                if (hit.collider != null)
                {
                    if(hit.collider.tag == "Laptop"){
                        Debug.Log("You clicked on laptop");
                        cameraAnimator.SetBool("laptopclick", true);
                        Canvas1.gameObject.SetActive(false);
                    }
                    if(hit.collider.tag == "Cabinet1"){
                        Debug.Log("You clicked on the first cabinet");
                        cabinetAnimator.SetBool("isclosed", true);
                        cabinetAnimator.SetBool("isopened", false);
                    }
                    if(hit.collider.tag == "Cabinet2"){
                        Debug.Log("You clicked on the second cabinet");
                        secondCabinetAnimator.SetBool("isclosed", true);
                        secondCabinetAnimator.SetBool("isopened", false);
                    }
                    if(hit.collider.tag == "Cabinet3"){
                        Debug.Log("You clicked on the second cabinet");
                        lastCabinetAnimator.SetBool("isclosed", true);
                        lastCabinetAnimator.SetBool("isopened", false);
                    }
                    if(hit.collider.tag == "Tablet"){
                        tabletAnimator.SetBool("tabletclicked", true);
                        tabletAnimator.SetBool("tabletclosed", false);
                    }
                }
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 100.0f))
            {
                if(hit.collider != null)
                {
                    if(hit.collider.tag == "Cabinet1"){
                        cabinetAnimator.SetBool("isopened", true);
                        cabinetAnimator.SetBool("isclosed", false);
                    }
                    if(hit.collider.tag == "Cabinet2"){
                        secondCabinetAnimator.SetBool("isopened", true);
                        secondCabinetAnimator.SetBool("isclosed", false);
                    }
                    if(hit.collider.tag == "Cabinet3"){
                        lastCabinetAnimator.SetBool("isopened", true);
                        lastCabinetAnimator.SetBool("isclosed", false);
                    }
                    if(hit.collider.tag == "Tablet"){
                        tabletAnimator.SetBool("tabletclosed", true);
                        tabletAnimator.SetBool("tabletclicked", false);
                    }
                }
            }
    
        }
    }
}
