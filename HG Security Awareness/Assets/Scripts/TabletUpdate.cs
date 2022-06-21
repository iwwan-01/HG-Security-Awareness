using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletUpdate : MonoBehaviour
{
    // private GameObject tablet;
    private Renderer tabletRenderer;

    public Material firstAttemptImage;
    public Material secondAttemptImage;
    public Material finalAttemptImage;

    // Start is called before the first frame update
    void Awake()
    {
        tabletRenderer = GetComponent<Renderer>();
        // tablet = GameObject.Find("Tablet");
    }


    // Update is called once per frame
    void Update()
    {

        // IT WORKS!!!
        if (SaveBooleans.IsStrong == false)
        {
            //SaveBooleans.IsSuccessful = false;
            SaveBooleans.IsFirstAttempt = false;
        }
        else if (SaveBooleans.IsStrong == true)
        {
            //SaveBooleans.IsSuccessful = true;
            SaveBooleans.IsFirstAssignment = false;
        }


        if (SaveBooleans.IsFirstAssignment)
        {
            if(!SaveBooleans.IsFirstAttempt)
            {
                tabletRenderer.material = secondAttemptImage;

            } else
            {
                tabletRenderer.material = firstAttemptImage;
            }
        } else
        {
            tabletRenderer.enabled = false;
        }


        if(SaveBooleans.IsSecondAttempt)
        {
            tabletRenderer.material = finalAttemptImage;
        }


        /*
        if(SaveBooleans.IsFirstAssignment) // If we are on the first assignment
        {
            if (!SaveBooleans.IsFirstAttempt) // If we are on the second attempt
            {
                tabletRenderer.material = secondAttemptImage; // Set the secondAttemptImage
                // Problem starts here
                SaveBooleans.IsStrong = null; // Resets the IsStrong boolean to null
                if(SaveBooleans.IsStrong == true) 
                {
                    SaveBooleans.IsSuccessful = true;
                    SaveBooleans.IsFirstAssignment = false;
                } else if (SaveBooleans.IsStrong == false)
                {
                    tabletRenderer.material = finalAttemptImage;
                    SaveBooleans.IsSuccessful = false;
                    SaveBooleans.IsFirstAssignment = true;
                }
                // Problem ends here
            }
            else // If we are on the first attempt
                tabletRenderer.material = firstAttemptImage; // Set the firstAttemptImage
            {
                if (SaveBooleans.IsStrong == true) // Password is strong 
                {
                    SaveBooleans.IsSuccessful = true; // Assignment is successful
                    SaveBooleans.IsFirstAssignment = false; // We move to the next assignment
                }
                else if (SaveBooleans.IsStrong == false) // Password is weak
                {
                    SaveBooleans.IsSuccessful = false; // Assignment is unsuccesssful
                    SaveBooleans.IsFirstAssignment = true; // We are still on the first assignment
                }
            }
        } else
        {
            tabletRenderer.enabled = false; // Disables the Mesh Renderer, if the assignment is successful
        }
        */




        /*
        if (SaveBooleans.IsFirstAssignment)
        {
            if (!SaveBooleans.IsFirstAttempt)
            {
                tabletRenderer.material = secondAttemptImage;
                if(SaveBooleans.IsSuccessful == true)
                {
                    SaveBooleans.IsFirstAssignment = false; 
                } else if (SaveBooleans.IsSuccessful == false) 
                {
                    tabletRenderer.material = finalAttemptImage; 
                }
            } else 
            {
                if(SaveBooleans.IsSuccessful == true)
                {
                    SaveBooleans.IsFirstAssignment = false; 
                } 
                else if (SaveBooleans.IsSuccessful == false) 
                {
                    SaveBooleans.IsFirstAttempt = false; 
                }
            }
        } else
        {
            tabletRenderer.enabled = false;
        }
        */
    }
}
