using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour
{
    public float totaltime = 5;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfray = 10;
    private RaycastHit hit;

    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gvrStatus)
        {
            gvrTimer += Time.deltaTime;
        }

         
    }
    

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
    }
}
