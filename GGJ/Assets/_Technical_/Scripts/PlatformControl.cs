using UnityEngine;
using System.Collections;

public class PlatformControl : MonoBehaviour
{
    public int CurrentPlatformIndex;
    public PlatformType type;
    public SequenceLevel myControl;

    void OnCollisionStay()
    {
        if (type.Equals(PlatformType.DelayPlayer))
            myControl.CurrentPlayerController.StopPlayer(3f);
        else
            myControl.UpdateFSA(type, CurrentPlatformIndex);
    }
}
