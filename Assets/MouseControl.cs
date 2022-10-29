using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    private Vector2 _one;
    private Vector2 _two;
    private Transform _thistransform;
    public Camera _camera;
    private void Start()
    {
        _one = Vector2.right;
        _camera = Camera.main;
        _thistransform = transform;
    }
    private float GetValueZ()
    {
        _two = Input.mousePosition - _thistransform.position;
        float scalarComposition = _one.x * _two.x + _one.y * _two.y;
        float mudelesComposition = _one.magnitude * _two.magnitude;
        float division = scalarComposition / mudelesComposition;
        float angle = Mathf.Acos(division) * Mathf.Rad2Deg;
        return angle;

    }
    private void Update()
    {
        float z = GetValueZ();
        _thistransform.rotation = Quaternion.Euler(0, 0, z);
    }

}
