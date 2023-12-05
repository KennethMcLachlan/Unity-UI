using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _cannon;

    [SerializeField]
    private GameObject _cannonBall;

    [SerializeField]
    private GameObject _ballSpawnPoint;


    private void Start()
    {
    }

    private void FixedUpdate()
    {
    }
    public void RotateLeft()
    {
        _cannon.transform.Rotate(0, -15f, 0);
    }

    public void RotateRight()
    {
        _cannon.transform.Rotate(0, 15f, 0);
    }

    public void FireCannon()
    {
        GameObject cannon = Instantiate(_cannonBall, _ballSpawnPoint.transform.position, _ballSpawnPoint.transform.rotation);
        cannon.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(-500, 0, 0));
    }

}
