using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VrGaze : MonoBehaviour{

    public Image imgGaze;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;
   
    public int distanceOfRay = 10;
    private RaycastHit hit;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    if (gvrStatus)
    {
        gvrTimer += Time.deltaTime;
        imgGaze.fillAmount = gvrTimer / totalTime;
    }
    
 }
     public void GVROn(){
        gvrStatus = true;
        }
        
        public void GVROff(){
        gvrStatus = false;
        }

     
}
