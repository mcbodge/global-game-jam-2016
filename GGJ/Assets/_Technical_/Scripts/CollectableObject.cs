using UnityEngine;
using System.Collections;

public class CollectableObject : MonoBehaviour {

    public CollectLevel myControl;
    public CollectableType type;

    void OnTriggerEnter()
    {
        gameObject.SetActive(false);
        if (type.Equals(CollectableType.Good))
            myControl.CollectedObjects++;
        else
            myControl.CurrentPlayerController.StopPlayer(5f);
    }
}
