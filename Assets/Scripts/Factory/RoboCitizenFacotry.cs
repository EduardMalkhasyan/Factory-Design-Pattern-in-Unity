using System;
using TMPro;
using UnityEngine;

public abstract class RoboCitizenFacotry
{
    public string robotName;
    public Color bodyColor;
    public abstract void RoboName(TextMeshPro textMeshPro);
    public abstract void BodyColor(MeshRenderer meshRenderer);
}
