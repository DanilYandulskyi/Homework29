using UnityEngine;

public class PlaceChanger : MonoBehaviour
{
    [SerializeField] private Transform[] _places;

    private int _index;
    private Mover _mover;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        Transform place = _places[_index];
        transform.position = _mover.MoveToTarget(place.position);

        if (transform.position == place.position)
            NextPlaceTakerLogic();
    }

    private Vector3 NextPlaceTakerLogic()
    {
        _index++;

        if (_index == _places.Length)
            _index = 0;

        Vector3 newPoint = _places[_index].transform.position;
        transform.forward = newPoint - transform.position;

        return newPoint;
    }
}
