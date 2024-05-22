using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGaming;
    public float points;
    public Text pointsTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGaming)
        {
            points += Time.deltaTime * 5;
            pointsTxt.text = "DISTANCE: " + Mathf.FloorToInt(points).ToString();
        }
    }   
}
