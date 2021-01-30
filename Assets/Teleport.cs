using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject teleport;
    public int activationDistance;

    void Update()
    {
        if(Vector3.Distance(teleport.transform.position, transform.position) < activationDistance)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
