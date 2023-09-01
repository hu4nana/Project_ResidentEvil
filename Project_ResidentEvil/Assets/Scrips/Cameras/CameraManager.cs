using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    List<Camera> cams = new List<Camera>();

    int curCam = 0;
    int camNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        camNum = int.Parse(other.gameObject.name.Substring(other.gameObject.name.Length - 1));
        curCam = camNum - 1;
        Debug.Log("camNum : "+ camNum + " || " +"curCam__camNum-1 :" +curCam);
        if (other.gameObject.tag == "CamEnter")
        {
            cams[camNum - 1].enabled = false;
            cams[camNum].enabled = true;

            cams[camNum].gameObject.SetActive(true);
            cams[camNum - 1].gameObject.SetActive(false);
            

        }
        else if(other.gameObject.tag == "CamExit")
        {
            cams[camNum - 1].enabled = true;
            
            cams[camNum].enabled = false;

            cams[camNum - 1].gameObject.SetActive(true);
            cams[camNum].gameObject.SetActive(false);
        }
        
    }
}
