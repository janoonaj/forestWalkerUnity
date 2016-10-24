using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour {
    public string nextSceneName;
    

    public void changeScene() {       
        AsyncOperation operation = SceneManager.LoadSceneAsync(nextSceneName);
       /* while (!operation.isDone) {
            yield return operation.isDone;
            Debug.Log("loading progress: " + operation.progress);
        }
        Debug.Log("load done");*/
    }

    
}
