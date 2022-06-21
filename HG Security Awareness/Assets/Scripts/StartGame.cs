using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void AssignBooleans()
    {
        SaveBooleans.IsFirstAssignment = true;
        SaveBooleans.IsFirstAttempt = true;
        SaveBooleans.IsSuccessful = null;
    }

}
