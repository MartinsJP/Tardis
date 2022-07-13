using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeB : MonoBehaviour
{

    public float totalTimer = 2;
    public float currentTimer = 0;
    public bool isActivee = false;
    public Image imagee;
    public GameObject playerr;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void EnableGazee()
    {
        isActivee = true;
        currentTimer = 0;

    }
    public void DisableGazee()
    {
        isActivee = false;
        imagee.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivee)
        {
            currentTimer += Time.deltaTime;
            imagee.fillAmount = currentTimer / totalTimer;
        }
        if (imagee.fillAmount == 1 && isActivee)
        {
            isActivee = false;
            playerr.transform.position = new Vector3(-4.46f, 2, 9.69f);
        }
    }
}