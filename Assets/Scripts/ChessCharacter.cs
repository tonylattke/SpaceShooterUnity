using UnityEngine;

public class ChessCharacter : MonoBehaviour
{
    [SerializeField]
    protected int Speed = 5;
    
	[SerializeField]
    protected Inventory MyInventory = new Inventory();
    
    [SerializeField]
    protected Vector2 ShootDirection = Vector2.up;
}