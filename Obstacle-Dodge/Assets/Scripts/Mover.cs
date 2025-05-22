using UnityEngine;

public class Mover : MonoBehaviour
{
    float xValue = 0f;
    float yValue = 0.05f;
    float zValue = 0f;


    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
