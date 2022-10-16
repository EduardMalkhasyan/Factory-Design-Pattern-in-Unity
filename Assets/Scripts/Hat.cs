using System;
using TMPro;
using UnityEngine;

[Serializable]
public class Hat
{
    public GameObject hatPrefab;

    public void PutOnHat(Transform parentTransform)
    {
        var hat = UnityEngine.Object.Instantiate(hatPrefab);
        hat.transform.SetParent(parentTransform, false);
        hat.transform.localPosition = Vector3.zero;
    }
}
