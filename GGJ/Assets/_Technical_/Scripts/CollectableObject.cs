using UnityEngine;
using System.Collections;

public class CollectableObject : MonoBehaviour {

    public CollectLevel MyControl;
    public CollectableType Type;

    void OnTriggerEnter()
    {
        gameObject.SetActive(false);
        if (Type.Equals(CollectableType.Good))
            MyControl.CollectedObjects++;
        else
            MyControl.CurrentPlayerController.StopPlayer(5f);
    }
}
