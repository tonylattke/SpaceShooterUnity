using UnityEngine;
using System.Collections.Generic;

public class Inventory
{
    private PieceType CurrentPieceType = PieceType.None;
    
    [SerializeField]
    List<WeaponBase> Weapons = new List<WeaponBase>();
    
    public PieceType GetCurrentPieceType()
    {
        return CurrentPieceType;
    }

    public WeaponBase GetCurrentWeaponGameObject()
    {
        foreach (var Weapon in Weapons)
        {
            WeaponBase WeaponBaseComponent = Weapon.GetComponent<WeaponBase>();
            if (WeaponBaseComponent != null && WeaponBaseComponent.CurrentPieceType == CurrentPieceType)
            {
                return Weapon;
            }
        }
        
        Debug.Log("Weapon not found");
        return null;
    }
}