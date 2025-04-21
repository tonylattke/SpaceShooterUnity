using UnityEngine;

public class WeaponBase : MonoBehaviour
{
    [SerializeField]
    public PieceType CurrentPieceType = PieceType.None;
    
    [SerializeField] 
    protected GameObject AmmoRef = null;
    
    [SerializeField] 
    protected Transform ShootPoint;
    
    [SerializeField] 
    protected float ShootInterval = 0.5f;

    public void Attack()
    {
        // Do nothing
    }
}