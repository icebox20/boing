using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public List<GameObject> backgrounds;
    private Vector3 startPosition;
    private float lastPosition;

    void Start()
    {
        startPosition = transform.position;
        lastPosition = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
    	float delta = transform.position.x - lastPosition; 
    	lastPosition = transform.position.x;

        foreach (GameObject background in backgrounds)
        {
        	float parallaxSpeed = (Mathf.Clamp01(Mathf.Abs(background.transform.position.z/transform.position.z)));
        	//Debug.Log(background + ":" + parallaxSpeed + transform.position.z/background.transform.position.z);
        	background.transform.position = new Vector3(background.transform.position.x + delta*parallaxSpeed, background.transform.position.y, background.transform.position.z);
        }
        
    }
}
