using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBrain<T> : MonoBehaviour
{
    protected BaseState<T> currentState; 
    public abstract void ChangeState(BaseState<T> newState);

    public abstract void UpdateState();

}
