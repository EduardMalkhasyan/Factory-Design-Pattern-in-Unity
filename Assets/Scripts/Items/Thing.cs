using System;
using UnityEngine;

[Serializable]
public class Thing
{
    public GameObject thingPrefab;

    private Transform transform;

    public void HoldThing(Transform parentTransform)
    {
        var thing = UnityEngine.Object.Instantiate(thingPrefab);
        transform = thing.transform;
        thing.transform.SetParent(parentTransform, false);
        thing.transform.localPosition = Vector3.zero;
    }

    public void Rotate()
    {
        transform.Rotate(-50 * Time.deltaTime, 0, 0, Space.Self);
    }
}
