using UnityEngine;
using System.Collections;

public class PlatformControl : MonoBehaviour
{
    public int CurrentPlatformIndex;
    public PlatformType type;
    public SequenceLevel myControl;

    void OnCollisionStay()
    {
        myControl.UpdateFSA(type, CurrentPlatformIndex);
    }

}
