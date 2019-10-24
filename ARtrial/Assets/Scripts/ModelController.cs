using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ModelController : MonoBehaviour
{
   GameObject model;
    public GameObject plane;
    public GameObject  [] prefabs;
    public Text nameText;
    private int modelId = -1;
    private int modelCounter;

    void Start()
    {
        SetModel();
    }

    public void SetModel(){
         if (modelId == -1)
        {
          modelCounter = prefabs.Length;
          modelId = Random.Range(0, modelCounter);
          SetOtherModel();
          
        } else
        {
            if (modelId < modelCounter-1){
                prefabs[modelId].SetActive(false);
                //Destroy(prefabs[modelId]);
                modelId++;
                SetOtherModel();
            } else
            {
                 prefabs[modelId].SetActive(false);
                 modelId = 0;
                 SetOtherModel();
            }
        }
    }
    private void SetOtherModel(){
         nameText.text = prefabs[modelId].name.ToString ();
         prefabs[modelId].SetActive(true);
    }
}
