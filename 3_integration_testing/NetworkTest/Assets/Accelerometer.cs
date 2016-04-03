using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

[AddComponentMenu("Cardboard/CardboardHead")]
public class Accelerometer : NetworkBehaviour {

    Quaternion r;
    Vector3 p;
    [Command]
    public void CmdCameraup(Vector3 pos,Quaternion Rot)
    {
        this.transform.localRotation =  Rot;
        //this.transform.localPosition = transform.position + transform.rotation * pos;
    }
	// Update is called once per frame
    [ClientCallback]
	void Update () {
        Cardboard.SDK.UpdateState();
        r = Cardboard.SDK.HeadPose.Orientation;
        p= Cardboard.SDK.HeadPose.Position;

        CmdCameraup(p, r);
    }
}
