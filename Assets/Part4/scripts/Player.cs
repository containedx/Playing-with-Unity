using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject currentWeapon;
    public Transform weaponPosition;
    public Animator playerAnimator; 

    public PlayerFightParams fightParams;

    public PlayerInfo playerInfo; 

    public const string ATTACK_KEY = "Attact";

    private void Start()
    {
        playerInfo.OnWeaponPickup += PickUpWeapon; 
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > fightParams.attactTime + fightParams.attactDelay)
        {
            Attack(); 
        }
    }

    public void Attack()
    {
        fightParams.attactTime = Time.time;
        playerAnimator.SetTrigger(ATTACK_KEY);
        playerInfo.CallOnPlayerAttack(); 
    }

    public void PickUpWeapon( WeaponInfo info )
    {
        fightParams.weaponId = info.Id;
        fightParams.attactDelay = info.AttackDelay;
        fightParams.attactDamage = info.AttackDamage; 

        if(currentWeapon != null)
        {
            Destroy(currentWeapon); 
        }

        currentWeapon = Instantiate(info.WeaponPrefab);
        currentWeapon.transform.parent = weaponPosition;
        
        if (info.Id == "axe0")
        {
            currentWeapon.transform.localPosition = new Vector3( 0.17f, -0.35f, 0.03f);
            currentWeapon.transform.Rotate(0, 180, 30, Space.Self);
        }
        else if (info.Id == "sword0")
        {
            currentWeapon.transform.localPosition = new Vector3(-0.04f, -0.67f, 0.12f);
            currentWeapon.transform.Rotate(180, 0, 0, Space.Self);
        }

        Debug.Log(info.Id); 
    }


    private void OnApplicationQuit()
    {
        playerInfo.OnWeaponPickup -= PickUpWeapon; 
    }

}

[System.Serializable]
public class PlayerFightParams
{
    public string weaponId;
    public float attactDelay;
    public float attactDamage;

    public float attactTime; 
}
