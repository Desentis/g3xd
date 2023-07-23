using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectScalling : MonoBehaviour
{
    [SerializeField] private float _scaleStep = 0.05f;
    private CanvasScaler _canvasScaler;


    public void Awake()
    {
        _canvasScaler = GetComponent<CanvasScaler>();
    }

    public void Update()
    {
        float mwheel = Input.mouseScrollDelta.y;
        _canvasScaler.scaleFactor += mwheel * _scaleStep;        
    }

}
