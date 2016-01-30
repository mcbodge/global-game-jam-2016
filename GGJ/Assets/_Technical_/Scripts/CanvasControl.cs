using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanvasControl : MonoBehaviour {

    private Slider firstPlayerSlider;
    private Slider secondPlayerSlider;

	// Use this for initialization
	void Start () {
        Slider[] sliders = gameObject.GetComponentsInChildren<Slider>();
        foreach(Slider slider in sliders)
        {
            if (slider.name.Equals("First"))
                firstPlayerSlider = slider;
            else if (slider.name.Equals("Second"))
                secondPlayerSlider = slider;
        }
    }
	
	// Update is called once per frame
	void Update () {
        firstPlayerSlider.value = SceneControl.Instance.Points[0];
        firstPlayerSlider.value = SceneControl.Instance.Points[1];
    }
}
