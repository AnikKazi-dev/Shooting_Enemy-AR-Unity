using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanObject : MonoBehaviour
{

    public Transform[] points;
    public GameObject[] models;

    private void Start()
    {
        StartCoroutine(Spwaning());
    }

    IEnumerator Spwaning()
    {
        yield return new WaitForSeconds(5);
        for(int i = 0 ; i<4 ; i++)
        {

            Instantiate(models[i], points[i].position, Quaternion.identity);

        }

        StartCoroutine(Spwaning());
    }

}
