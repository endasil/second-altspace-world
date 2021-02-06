using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class find : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MonoBehaviour[] scriptsInScene = (MonoBehaviour[])FindObjectsOfType(typeof(MonoBehaviour));
        Debug.Log("Objects fóund " + scriptsInScene.Length);
        foreach (var scriptFile in scriptsInScene)
        {
            Debug.Log(scriptFile);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
