using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float RotateSpeed = 1f;
    public float FloatSpeed = 1f;
    public float FloatScale = 1f;

    private Vector3 _basePos;
    // Start is called before the first frame update
    void Start()
    {
        _basePos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime, Space.World);
        transform.position = _basePos + FloatScale* Vector3.up * Mathf.Sin(Time.time * FloatSpeed);

    }
}
