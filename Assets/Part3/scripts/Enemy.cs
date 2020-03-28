using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : BaseBrain<Enemy>
{

    public Event eventLauncher; 
    public MeshRenderer enemyRenderer;
    public Transform patrolSpot;
    private void Start()
    {
        eventLauncher.OnObjectClicked += OnObjectClicked; 
        StartFollowState(); 
    }

    private void Update()
    {
        UpdateState(); 
    }

    public void OnObjectClicked( float value )
    {
        Debug.Log(value);
        StartFightState(); 
    }

    [ContextMenu("StartFollowState")]
    public void StartFollowState()
    {
        ChangeState(new FollowState()); 
    }

    [ContextMenu("StartFightState")]
    public void StartFightState()
    {
        ChangeState(new FightState()); 
    }

    #region --------------------- BaseBrain methods implementation
    public override void ChangeState(BaseState<Enemy> newState)
    {
        currentState?.DeinitState(this);
        currentState = newState;
        currentState?.InitState(this); 
    }

    public override void UpdateState()
    {
        currentState?.UpdateState(this); 
    }
    #endregion --------------------------------------------------

    private void OnDisable()
    {
        eventLauncher.OnObjectClicked -= OnObjectClicked; 
    }
}
