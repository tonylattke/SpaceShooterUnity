using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class Inventory
{
	[SerializeField]
    private PieceType CurrentPieceType = PieceType.None;
    
    [SerializeField]
    List<GameObject> Weapons = new List<GameObject>();
    
    public PieceType GetCurrentPieceType()
    {
        return CurrentPieceType;
    }

    public GameObject GetCurrentWeaponGameObject()
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