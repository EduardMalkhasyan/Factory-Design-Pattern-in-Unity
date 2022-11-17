using TMPro;
using UnityEngine;

public class RoboPoliceman : RoboCitizenFacotry
{
    public override void BodyColor(MeshRenderer meshRenderer)
    {
        meshRenderer.material.color = bodyColor;
    }

    public override void RoboName(TextMeshPro textMeshPro)
    {
        textMeshPro.text = robotName;
    }
}
