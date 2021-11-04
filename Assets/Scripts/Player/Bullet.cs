using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Pool.Instance.AddToPool(gameObject);
    }
}
