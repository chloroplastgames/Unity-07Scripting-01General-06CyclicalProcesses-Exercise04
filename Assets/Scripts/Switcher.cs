using UnityEngine;

public class Switcher : MonoBehaviour
{

    public bool IsSwitched { get; private set;}

    public delegate void OnTriggerHandler();
    public event OnTriggerHandler OnTrigger;

    private void Start()
    {
        IsSwitched = false;
    }


    private void OnTriggerEnter()
    {
        if (!IsSwitched)
        {
            IsSwitched = true;
            OnTrigger?.Invoke();
        }
    }
}
