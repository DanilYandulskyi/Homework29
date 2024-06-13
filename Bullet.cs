using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 _moveDirection;
    private float _force;

    public Bullet Spawn(Vector3 position, Vector3 moveDirection, float force)
    {
        Bullet clone = Instantiate(this, position, Quaternion.identity);
        clone.Initialize(moveDirection, force);

        return Instantiate(this, position, Quaternion.identity);
    }

    private void Initialize(Vector3 moveDirection, float force)
    {
        _moveDirection = moveDirection;
        _force = force;
    }
}