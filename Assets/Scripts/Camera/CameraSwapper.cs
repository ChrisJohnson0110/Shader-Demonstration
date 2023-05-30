///////////////////////////////////////////////////////////////////////////////
/// Chris Johnson - 05/05/2023
/// Script to switch active camera between specified cameras
///////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwapper : MonoBehaviour
{
    List<Camera> li_cSwappableCameras; //list of all camera that can be swapped to
    private int iCurrentCamera; //current camera to display

    // Start is called before the first frame update
    void Start()
    {
        li_cSwappableCameras = new List<Camera>(FindObjectsOfType<Camera>()); //get all active cameras
        if (li_cSwappableCameras == null) //set current to inactive hiding camera controls
        {
            gameObject.SetActive(false);
        }
        SetActiveCamera(); //set the camera in list pos 0 
    }

    /// <summary>
    /// set all cameras visability to arg 
    /// </summary>
    private void DeactivateAllCameras()
    {
        //update all cameras to arg
        foreach (Camera c in li_cSwappableCameras)
        {
            c.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// change the current display camera to a new one
    /// </summary>
    /// <param Camera num to set="a_iCamera"></param>
    private void SetActiveCamera()
    {
        DeactivateAllCameras(); //hide all cameras
        li_cSwappableCameras[iCurrentCamera].gameObject.SetActive(true); //set desired to active
    }

    //Button functions

    /// <summary>
    /// change the current camera int to one lower in list - rolls over
    /// </summary>
    public void GoBackACamera()
    {
        //decrease current camera value
        if (iCurrentCamera == 0)
        {
            iCurrentCamera = li_cSwappableCameras.Count - 1;
        }
        else
        {
            iCurrentCamera--;
        }
        SetActiveCamera(); //set active camera
    }

    /// <summary>
    /// change the current camera int to the next in list - rolls over
    /// </summary>
    public void GoForwardACamera()
    {
        //increase current camera value
        if (iCurrentCamera == li_cSwappableCameras.Count - 1)
        {
            iCurrentCamera = 0;
        }
        else
        {
            iCurrentCamera++;
        }
        SetActiveCamera(); //set active camera
    }


}
