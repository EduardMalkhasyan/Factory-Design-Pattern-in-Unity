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

public class RoboDoctor : RoboCitizenFacotry
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