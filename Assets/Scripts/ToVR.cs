using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.XR;

public class ToVR : MonoBehaviour {

	// Use this for initialization
	public void Start ()
    {
        StartCoroutine(VROn("Cardboard"));
	}

    public IEnumerator VROn(string VR)
    {
        XRSettings.LoadDeviceByName(VR);
        yield return null;
        XRSettings.enabled = true;
    }

}
