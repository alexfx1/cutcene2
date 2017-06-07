using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFim : MonoBehaviour
{

    public void CameraAcabou()
    {
        CutsceneController.instancia.ProximaCamera();
    }
}