using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightState : BaseState<Enemy>
{

    #region -------- BaseState methods implementation    
    public override void InitState(Enemy controller)
    {
        controller.enemyRenderer.material.color = Color.red;
        Debug.Log("FightState :: Init"); 
    }

    public override void UpdateState(Enemy controller)
    {
        controller.transform.position = Vector3.MoveTowards(controller.transform.position, controller.patrolSpot.position, 1f); 
        Debug.Log("FightState :: Update");         
    }
    public override void DeinitState(Enemy controller)
    {
        Debug.Log("FightState :: Deinit");        

    }
    #endregion -----------------------------------------
}
