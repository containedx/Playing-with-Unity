using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FightMode", menuName = "Modes/FightMode", order = 0)]
public class FightMode : BaseGameMode
{

    public override void Init(GameModeController controller)
    {
        base.Init(controller);
        controller.playerInfo.OnPlayerAttack += OnPlayerAttack; 
    }

    public override void Deinit(GameModeController controller)
    {
        base.Deinit(controller);
        controller.playerInfo.OnPlayerAttack -= OnPlayerAttack; 
    }

    public void OnPlayerAttack()
    {
        Debug.Log("PlayerAttack"); 
    }
}
