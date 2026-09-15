using UnityEngine;

public class MobileInput : MonoBehaviour
{
    public static bool left;
    public static bool right;
    public static bool forward;
    public static bool back;
    public static bool jump;

    // Forward stays active until another direction is selected
    public void ForwardDown()
    {
        forward = true;
        back = false;
    }

    // Backward stays active until another direction is selected
    public void BackDown()
    {
        forward = false;
        back = true;
    }

    // Left: active only while holding
    public void LeftDown()
    {
        left = true;
        right = false;
        forward = false;
        back = false;
    }

    public void LeftUp()
    {
        left = false;
    }

    // Right: active only while holding
    public void RightDown()
    {
        right = true;
        left = false;
        forward = false;
        back = false;
    }

    public void RightUp()
    {
        right = false;
    }

    public void JumpButton()
    {
        jump = true;
    }
}