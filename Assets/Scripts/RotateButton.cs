using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject btn;
    public GameObject cube;
    int r = 0;
    bool clicked = false;


    void RotateClick(){
    	Debug.Log("Testing");
    	r = r + 100;
    	Debug.Log(r);
        clicked = true;
    }


    void Start()
    {
        Button rotatebtn = btn.GetComponent<Button>();
        rotatebtn.onClick.AddListener(RotateClick);
    }

    // Update is called once per frame
    void Update()
    {
        if(clicked){
       	cube.transform.Rotate(new Vector3(0,Time.deltaTime * 20, 0));
       }
    }


}
