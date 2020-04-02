using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PlayerInfo", menuName  = "Items/PlayerInfo", order = 0)]
public class PlayerInfo : ScriptableObject
{
    public Vector3 playerPosition;

    public UnityAction OnPlayerAttack;
    public void CallOnPlayerAttack()
    {
        OnPlayerAttack?.Invoke(); 
    }

    public UnityAction<WeaponInfo> OnWeaponPickup; 
    public void CallOnWeaponPickup(WeaponInfo newWeapon)
    {
        OnWeaponPickup?.Invoke(newWeapon);
    }
}
