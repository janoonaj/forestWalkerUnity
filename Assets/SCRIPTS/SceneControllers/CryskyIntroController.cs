using UnityEngine;
using System.Collections;

public class CryskyIntroController : MonoBehaviour {
    public SceneNavigation sceneNavigation;
    public FadeScreen fadeScreen;
    private float DURATION_IN_SECONDS = 5f;

	
	void Start () {
        StartCoroutine(waitAndFade());
    }

    private IEnumerator waitAndFade() {
        yield return new WaitForSeconds(DURATION_IN_SECONDS);
        float fadeTime = fadeScreen.fade(FadeScreen.FadeDirection.fadeout);
        yield return new WaitForSeconds(fadeTime);
        sceneNavigation.changeScene();
    }
}
