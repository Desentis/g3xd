using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private ResourcesFeature _resourcesFeature;
    void Start()
    {
        var health = new Resource(ResourceType.Health, 100);
        var time = new Resource(ResourceType.Time, 60);
        var horizon = new Resource(ResourceType.Horizon, 20);

        var resources = new[] { health, time, horizon };

        _resourcesFeature = new ResourcesFeature(resources);

        _resourcesFeature.ResourceChanged += OnResourceChanged;

        Debug.Log($"Created: Resource ({ResourceType.Health}) = {_resourcesFeature.GetResourceValueString(ResourceType.Health)}");
        Debug.Log($"Created: Resource ({ResourceType.Time}) = {_resourcesFeature.GetResourceValueString(ResourceType.Time)}");
        Debug.Log($"Created: Resource ({ResourceType.Horizon}) = {_resourcesFeature.GetResourceValueString(ResourceType.Horizon)}");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            _resourcesFeature.AddResource(ResourceType.Health, 100);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            _resourcesFeature.SpendResource(ResourceType.Health, 100);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            _resourcesFeature.AddResource(ResourceType.Time, 60);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            _resourcesFeature.SpendResource(ResourceType.Time, 60);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            _resourcesFeature.AddResource(ResourceType.Horizon, 20);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            _resourcesFeature.SpendResource(ResourceType.Horizon, 20);
        }
    }

    private void OnResourceChanged(ResourceType type, int oldValue, int newValue)
    {
        Debug.Log($"Resource amount changed. Resource type ({type}), old value = {oldValue}, new value = {newValue}");
    }

    private void OnDestroy()
    {
        _resourcesFeature.ResourceChanged -= OnResourceChanged;
    }
}
