using UnityEngine;

public class SimpleWeapon : WeaponBase
{
    public override void Attack(GameObject User)
    {
        Debug.Log("Simple weapon fired!");
    }
}