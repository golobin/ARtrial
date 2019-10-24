using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
   public void LoadNextScene()
    {
         Scene scene = SceneManager.GetActiveScene();
          if (Application.CanStreamedLevelBeLoaded(scene.buildIndex + 1)){
            SceneManager.LoadScene (scene.buildIndex + 1);
        }
    }
    public void LoadPreviousScene(){
        Scene scene = SceneManager.GetActiveScene();
        if (Application.CanStreamedLevelBeLoaded(scene.buildIndex - 1) ){
            SceneManager.LoadScene (scene.buildIndex - 1);
        }
    }

}
