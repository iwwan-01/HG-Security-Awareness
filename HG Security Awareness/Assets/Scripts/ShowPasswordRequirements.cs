using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPasswordRequirements : MonoBehaviour
{
    [SerializeField]
    public GameObject passwordRequirements;


    // Update is called once per frame
    void Update()
    {
        if (SaveBooleans.IsFirstAttempt == false)
        {
            passwordRequirements.SetActive(true);
        } else
        {
            passwordRequirements.SetActive(false);
        }

        Debug.Log(SaveBooleans.IsFirstAttempt);
    }
}
