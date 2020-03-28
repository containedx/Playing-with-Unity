using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowState : BaseState<Enemy>
{

    public MeshRenderer render;

    #region -------- BaseState methods implementation 
    public override void InitState(Enemy controller)
    {
        controller.enemyRenderer.material.color = Color.green;
        Debug.Log("FollowState :: Init");
    }

    public override void UpdateState(Enemy controller)
    {
        controller.transform.RotateAround(controller.patrolSpot.position, Vector3.up, 1f); 
        Debug.Log("FollowState :: Update");        
    }

    public override void DeinitState(Enemy controller)
    {
        
        Debug.Log("FollowState :: Deinit");    
    }

    #endregion -----------------------------------------
}
