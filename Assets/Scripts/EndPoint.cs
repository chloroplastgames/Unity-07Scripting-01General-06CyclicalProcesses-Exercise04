using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public delegate void OnEnter();

    public static OnEnter Execute;

    private void OnTriggerEnter()
    {
        if (Execute == null) return;

        Execute.Invoke();
    }

}
