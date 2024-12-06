using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayDistanceText : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _DistanceText ;
    [SerializeField] private Transform _playerTransform;
    private Vector2 _StartPosition;

    private void Start()
    {
        _StartPosition =_playerTransform.position;

    }
    private void Update()
    {
        Vector2 distance = (Vector2) _playerTransform.position- _StartPosition;
        distance.y = 0f;
        if (distance.x<0)
        {
            distance.x = 0;
        }

        _DistanceText.text = distance.x.ToString("0");
    }
}
