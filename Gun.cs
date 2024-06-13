using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Bullet _prefab;
    [SerializeField] private float _timeToShoot;
    [SerializeField] private Transform _objectToShoot;

    private void Start()
    {
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        bool isWork = enabled;

        while (isWork)
        {   
            Vector3 bulletDirection = (_objectToShoot.position - transform.position).normalized;
            _prefab.Spawn(transform.position, bulletDirection, _force);

            yield return new WaitForSeconds(_timeToShoot);
        }
    }
}