using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Followed from AR Slider Tutorial: https://www.youtube.com/watch?v=uxgF9DkRYLM&ab_channel=JUNO%26LEONATANU

public class AdjustCube : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationMin = 0.0f;
    public float rotationMax = 45.0f;
    public Slider RotationSlider;
    public Slider ScaleSlider;

	float currentRotation = 0f;
    [SerializeField] float currentScale = 10.0f;
    void Start()
    {
        RotationSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
        ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0.0f, RotationSlider.value * 360,0f);
        transform.localScale = new Vector3(ScaleSlider.value * 200, ScaleSlider.value * 200, ScaleSlider.value * 200);

    }

    private void onGUI(){
    	currentRotation = GUI.HorizontalSlider(new Rect(-280f, 165.0f, 228.0f, 57.0f), currentRotation * 360, 0.0f,45.0f);
    	transform.localEulerAngles = new Vector3(0.0f, currentRotation * 360, 0.0f);
    	currentRotation = GUI.HorizontalSlider(new Rect(-280f, 120.0f, 228.0f, 57.0f), currentScale * 200, 0.0f, 2f);
    	transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }

    public void AdjustAngle(float newAngle){

    }

    public void AdjustScale(float newScale){

    }
}
