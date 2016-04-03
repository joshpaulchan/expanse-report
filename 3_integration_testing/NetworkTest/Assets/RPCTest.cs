using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[AddComponentMenu("Cardboard/CardboardHead")]
public class RPCTest : MonoBehaviour
{
    Quaternion r;
    Vector3 p;

    void Update()
    {
        //This is owned by the server
       if(networkView.isMine)
       {

        networkView.RPC("CmdCameraup",RPCMode.All,newobject[] {r,q});
       }
       //This is the client, assumed to be the smartphone
       else{
        Cardboard.SDK.UpdateState();
        //Get Rotation data
        r = Cardboard.SDK.HeadPose.Orientation;
        p= Cardboard.SDK.HeadPose.Position;

        CmdCameraup(p, r);
       }
       //The RPC function
       [RPC]
       public void CmdCameraup(Vector3 pos,Quaternion Rot){
            this.transform.localRotation =  Rot;
       }
}
