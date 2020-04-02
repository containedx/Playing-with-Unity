using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponInfo", menuName = "Items/WeaponInfo", order = 0)]
public class WeaponInfo : ScriptableObject
{
    [SerializeField]
    private string id;
    public string Id => id;

    [SerializeField]
    private float attackDelay;
    public float AttackDelay => attackDelay;

    [SerializeField]
    private float attackDamage;
    public float AttackDamage => attackDamage;

    [SerializeField]
    private GameObject weaponPrefab;
    public GameObject WeaponPrefab => weaponPrefab; 
}
