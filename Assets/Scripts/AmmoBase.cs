using UnityEngine;

public abstract class AmmoBase : MonoBehaviour
{
    [SerializeField]
    PieceType CurrentPieceType = PieceType.None;
    
    [SerializeField] 
    protected float Speed = 5f;
    
    [SerializeField] 
    protected Vector2 Direction = Vector2.up;

    void Update()
    {
        transform.Translate(Direction * Speed * Time.deltaTime);
    }
}