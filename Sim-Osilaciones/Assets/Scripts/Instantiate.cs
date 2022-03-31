using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    [SerializeField] public GameObject prefab;
    [SerializeField] public int numberOfObjects;
    [SerializeField] [Range(0, 1)] public float amplitude;
    [SerializeField] [Range(-1, 1)] public float overlap;

    [HideInInspector] [SerializeField] private List<GameObject> circleList;

    private void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            var circle = Instantiate(prefab, transform);
            circleList.Add(circle);
        }
    }

    private void Update()
    {
        DrawSen();
    }

    private void DrawSen()
    {
        for (int i = 0; i < circleList.Count; i++)
        {
            var circle = circleList[i];
            float x = i * 0.7f + overlap;
            float y = amplitude * Mathf.Sin(2 * Mathf.PI + i + Time.time);

            circle.transform.localPosition = new Vector3(x, y);
        }
    }   
}
