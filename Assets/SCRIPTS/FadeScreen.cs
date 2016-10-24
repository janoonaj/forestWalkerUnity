using UnityEngine;
using System.Collections;

public class FadeScreen : MonoBehaviour {

    public enum FadeDirection { fadein, fadeout}

    public Texture2D fadeTexture;
    private float fadeSpeed = 0.8f;
    private int drawDepth = -1000;  //the texture should be painted at the end.
    private float alpha = 0f;
    private bool fading = false;    //enable to start fade effect
    private FadeDirection fadeDirection;

	void OnGUI () {
        if (fading == false) return;
        float newAlpha = fadeSpeed * Time.deltaTime;
        if(fadeDirection == FadeDirection.fadein) {
            newAlpha *= -1;
        }
        alpha += newAlpha;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTexture);

	}

    public float fade(FadeDirection fadeDirection) {
        this.fadeDirection = fadeDirection;
        fading = true;
        return fadeSpeed;
    }
}
