using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewDistanceSetter : MonoBehaviour
{
    [SerializeField] private InitializationSystem _initialization;

    private void Awake()
    {
        SetDistanceFromOrigin(_initialization.GridSize);
    }

    public void SetDistanceFromOrigin(float distance)
    {
        Vector3 viewDirection = transform.position.normalized;
        transform.position = viewDirection * distance;
    }
}
