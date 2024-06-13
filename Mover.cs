using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    public Vector3 MoveToTarget(Vector3 target)
    {
        return Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
    }
}
