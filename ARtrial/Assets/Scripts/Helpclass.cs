using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Helpclass : MonoBehaviour
{
  private int help;
  public GameObject helpText;

 void Start()
 {
   help = PlayerPrefs.GetInt("SecondStart", 0);
   if (help == 0)
   {
     PlayerPrefs.SetInt("SecondStart", 1);
     StartCoroutine(Wait());
    }   
  } 

public void Click(){
     StartCoroutine(Wait());
 }

 IEnumerator Wait()
    {
        helpText.SetActive(true);
        yield return new WaitForSeconds(5);
        helpText.SetActive(false);
    }
}
