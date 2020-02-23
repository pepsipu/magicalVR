using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handMovement : MonoBehaviour
{
    public Transform rightHand;
    public Transform leftHand;

    void Update()
    {
        rightHand.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        leftHand.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);

        rightHand.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);
        leftHand.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
    }
}
