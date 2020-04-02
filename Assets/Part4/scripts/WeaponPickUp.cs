using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour, IPickable
{
    [SerializeField]
    private WeaponInfo weapon;
    public WeaponInfo Weapon => weapon;

    [SerializeField]
    private Player currentPlayer;
    public Player CurrentPlayer => currentPlayer;

    [SerializeField]
    private Light itemLight;
    public Light ItemLight => itemLight; 
    public bool animateLight; 

    public PlayerInfo playerInfo;

    private void Start()
    {
        playerInfo.OnPlayerAttack += OnPlayerAttack; 
    }

    private void Update()
    {
        if (animateLight)
        {
            itemLight.intensity = Mathf.Lerp(0.1f, 1.5f, Mathf.InverseLerp(-1f, 1f, Mathf.Sin(Time.time)));
        }
    }

    public void OnPlayerAttack()
    {
        animateLight = true; 
    }

    private void PickupWeapon()
    {
        playerInfo.CallOnWeaponPickup(weapon);
    }

    private void OnMouseDown()
    {
        //currentPlayer.PickUpWeapon(weapon);
        PickupWeapon(); 
    }

    #region ----- IPickable Interface implementation -------

    public void OnInteraction()
    {
        PickupWeapon();
    }

    #endregion
}
