using UnityEngine;
using System.Collections;

[ExecuteInEditMode]

public class createColliders : MonoBehaviour {
    void Start() {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if (obj.name.Contains("Cube")) obj.AddComponent<BoxCollider>();
		}
    }
}