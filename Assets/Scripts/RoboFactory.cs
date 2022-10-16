using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "RoboItem", menuName = "ScriptableObjects/RoboItem")]
public class RoboFactory : ScriptableObject
{
    [SerializeField]
    private Thing Thing;

    [SerializeField]
    private Hat Hat;

    [SerializeReference, SubclassPicker]
    private RoboCitizenFacotry RoboCitizenFacotry;

    public void CreateRobot(Transform hatParent, Transform thingParent, MeshRenderer bodyMesh, TextMeshPro nameText)
    {
        Hat.PutOnHat(hatParent);
        Thing.HoldThing(thingParent);
        RoboCitizenFacotry.RoboName(nameText);
        RoboCitizenFacotry.BodyColor(bodyMesh);
    }

    public void RotateThing()
    {
        Thing.Rotate();
    }
}
