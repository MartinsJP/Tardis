using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeA : MonoBehaviour
{

    public float totalTime = 2;
    public float currentTime = 0;
    public bool isActive = false;
    public Image image;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void EnableGaze()
    {
        isActive = true;
        currentTime = 0;

    }
    public void DisableGaze()
    {
        isActive = false;
        image.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            currentTime += Time.deltaTime;
            image.fillAmount = currentTime / totalTime;
        }
        if (image.fillAmount == 1 && isActive)
        {
            isActive = false;
            player.transform.position = new Vector3(4.25f, 1.17f, 8.27f);
        }
    }
}