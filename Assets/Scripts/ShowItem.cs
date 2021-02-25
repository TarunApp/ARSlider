using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowItem : MonoBehaviour
{
 	public GameObject sphere;
    public GameObject cube;
    public Button changecube;
    public Button changesphere;




    
    void SphereClick(){
    	cube.SetActive(false);
    	sphere.SetActive(true);
    }

    void CubeClick(){
    	cube.SetActive(true);
    	sphere.SetActive(false);
    }

    void Start()
    {
    	changecube.GetComponentInChildren<Text>().text = "cube";
    	changesphere.GetComponentInChildren<Text>().text = "sphere";
    	sphere.SetActive(false);
        Button btn = changecube.GetComponent<Button>();
        btn.onClick.AddListener(CubeClick);

		Button btnsphere = changesphere.GetComponent<Button>();
        btnsphere.onClick.AddListener(SphereClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
