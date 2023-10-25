using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    [SerializeField] Material mat;
    float count;
    void Start()
    {
        StartCoroutine("CountCor");
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator CountCor()
    {
        yield return new WaitForSeconds(1.5f);
        count = 0;
        mat.SetFloat("_time", 1);
        yield return new WaitForSeconds(0.2f);
        mat.SetFloat("_time", 0);
        StartCoroutine("CountCor");
    }
}
