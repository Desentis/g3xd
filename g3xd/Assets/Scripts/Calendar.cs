using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calendar : MonoBehaviour
{
    [SerializeField] private Text _calendarText;
    [SerializeField] private Button _nextTurnBtn;

    private DateTime _startDate = new DateTime(2023,9,1);
    private DateTime _currentDate;

    [SerializeField] private double _interval = 1;

    private void Start()
    {
        _currentDate = _startDate;
        _calendarText.text = _currentDate.ToString("dd-MM-yyyy");
        //Debug.Log(currentDate);
    }

    public void DateChange()
    {
        _currentDate = _currentDate.AddDays(_interval);
        _calendarText.text = _currentDate.ToString("dd-MM-yyyy");
        Debug.Log(_currentDate);
    }
}
