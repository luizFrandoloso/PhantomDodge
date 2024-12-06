using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public static bool BGMexists;

    void Start()
    {

        if (!BGMexists)
        {
            BGMexists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {

    }
}