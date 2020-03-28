using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Event : MonoBehaviour
{
    public UnityAction<float> OnObjectClicked;

    private void OnMouseDown()
    {
        OnObjectClicked?.Invoke(Time.realtimeSinceStartup);
    }

}
