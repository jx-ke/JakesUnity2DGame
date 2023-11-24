using UnityEngine;
using System.Collections;
using System.IO;
using System;
using System.Threading;
using UnityEngine.UI;
 
public class StartLevel : MonoBehaviour
{
 
    static bool startGame=false;
    public Text txt;
   
    // Use this for initialization
 
    void Awake()
    {
        txt = gameObject.GetComponent<Text>();
        }
    void Start () {
   
        startGame = true;
           
        if (startGame == true)
        {
        StartCoroutine("CountDown");
        }
    }
 
        IEnumerator CountDown()
{
 
        yield return new WaitForSeconds(1);
        txt.text= "3";
        yield return new WaitForSeconds(1);  
        txt.text= "2";
        yield return new WaitForSeconds(1);
        txt.text=  "1";
        yield return new WaitForSeconds(1);
        txt.text= "GO!";
        yield return new WaitForSeconds(1);
        txt.text= "";
//
    }
       }