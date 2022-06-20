using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveSystem : MonoBehaviour
{
    // Update is called once per frame

    void Awake()
    {
        SaveBooleans.IsFirstAssignment = true;
        SaveBooleans.IsFirstAttempt = true;
        // The boolean IsSuccessful is updated from a different script based on the decision the player makes!
        // Possible issues: Make sure to assign null to the nullable boolean (isSuccessful) if the player fails!
    }


    void Update()
    {
        #region The function for the first level of the game
        if (SaveBooleans.IsFirstAssignment)
        {
            if(SaveBooleans.IsFirstAttempt)
            {
                if (SaveBooleans.IsSuccessful ?? true)
                {
                    //SceneManager.LoadScene(""); // Boss is happy, you can continue to the next assignment!
                }
                else
                {
                    //SceneManager.LoadScene(""); // Boss isn't happy, you replay the same level, but the password requirements update in real time!
                    SaveBooleans.IsFirstAttempt = false;
                    //SaveBooleans.HasFailed = true; CAN BE UNNECCESSARY!
                }
            } else if (!SaveBooleans.IsFirstAttempt)
            {
                if(SaveBooleans.IsSuccessful ?? false) // CAN CAUSE SOME ISSUES!!!
                {
                    //SceneManager.LoadScene("") // Game Over!
                }
                else
                {
                    //SceneManager.LoadScene("") // Boss is satisfied, you can continue to the next assignment!
                }
            }
        } else if (!SaveBooleans.IsFirstAssignment)
        {
            return; 
            // If bool IsFirstAssignment is false, exits the function for the first assignment and goes to the function for the second assignment!
        }
        #endregion
    }
}
