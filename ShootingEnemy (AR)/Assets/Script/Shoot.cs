using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject arCamera;
    public int theScore = 10;
    public void Shooting()   // when the user click shoot button, this func will work
    {
        RaycastHit hit;
       
        //Invisible raycast projectd from the middle of the phn's screen

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)) // A invisible raycast is projected from the center of the phn
                                                                                               // the result is store in the (out)"hit" variable
        {
            // "ball(Clone)"/"ball 1(Clone)"/"Box(Clone)"/"Box 1(Clone)"  These are the prefabs names of 3d model in unity
            if (hit.transform.name == "BlueEnemy(Clone)" || hit.transform.name == "GreenEnemy(Clone)" || hit.transform.name == "PurpleEnemy(Clone)" || hit.transform.name == "RedEnemy(Clone)")
            {
                Destroy(hit.transform.gameObject);   // after click baloon will be destroyed

                ScoreManager.score += theScore;
            }
        }
    }

}
