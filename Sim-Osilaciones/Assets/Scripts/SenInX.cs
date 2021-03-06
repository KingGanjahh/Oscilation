using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenInX : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] [Range(-3, 3)] float amplitudeX;
    [SerializeField] [Range(-3, 3)] float amplitudeY;

    private void Update()
    {
        EvaluateSen();
    }

    private void EvaluateSen()
    {
        float x = amplitudeX * Mathf.Sin(Time.time);
        float y = amplitudeY * Mathf.Sin(Time.time);
        target.position = new Vector3(x, y);
    }
}
