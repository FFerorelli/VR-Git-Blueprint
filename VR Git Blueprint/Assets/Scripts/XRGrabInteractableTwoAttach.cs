using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    public Transform leftAttachTranform;
    public Transform rightAttachTranform;
    // Start is called before the first frame update

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("Left Hand"))
        {
            attachTransform = leftAttachTranform;
        }
        else if (args.interactableObject.transform.CompareTag("Right Hand"))
        {
            attachTransform = rightAttachTranform;
        }
        base.OnSelectEntered(args);
    }

}
