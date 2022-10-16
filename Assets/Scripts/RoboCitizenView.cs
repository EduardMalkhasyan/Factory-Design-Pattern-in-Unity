using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class RoboCitizenView : MonoBehaviour
{
    [SerializeField]
    private RoboFactory roboFactoryObject;

    [SerializeField]
    private Transform thingParent;

    [SerializeField]
    private Transform hatParent;

    [SerializeField]
    private TextMeshPro nameText;

    [SerializeField]
    private MeshRenderer bodyMeshRenderer;

    private void Start()
    {
        roboFactoryObject.CreateRobot(hatParent, thingParent, bodyMeshRenderer, nameText);
    }

    private void Update()
    {
        roboFactoryObject.RotateThing();
    }
}
