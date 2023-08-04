using System;
using UnityEngine;

public class Resource
{
    public event Action<int, int> ResourceAmountChanged;

    private int _amount;

    public int Amount 
    { 
        get => _amount; 
        set
        {
            var OldValue = _amount;
            _amount = value;

            if (OldValue != _amount)
            {
                ResourceAmountChanged?.Invoke(OldValue, _amount);
            }
        }
        
    }

    public ResourceType Type { get; }

    public Resource(ResourceType type, int defaultAmount = default)
    {
        Type = type;
        Amount = defaultAmount;
    }
}
