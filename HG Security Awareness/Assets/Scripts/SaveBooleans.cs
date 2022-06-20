using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveBooleans
{
    public static bool IsFirstAssignment { get; set; }
    public static bool IsFirstAttempt { get; set; }
    public static bool? IsSuccessful { get; set; } // nullable bool!!!
    public static bool HasFailed { get; set; }
}
