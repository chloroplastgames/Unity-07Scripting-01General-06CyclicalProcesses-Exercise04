using UnityEngine;

public class Switcher : MonoBehaviour
{
    public delegate void OnPress();

    public static OnPress Execute; 

    private void OnTriggerEnter()
    {
        if (Execute == null) return;

        Execute.Invoke();
    }
}
