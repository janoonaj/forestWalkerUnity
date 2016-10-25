using UnityEngine;
using StartApp;
using System;

public class StartAppADS : MonoBehaviour {
    public bool interstitial = false;
    public bool banner = false;
    public bool interestial_VIDEO = false;
    public bool interestial_OFFERS = false;
    public bool interestial_FULLPAGE = false;
    private Listener listener;

	void Start () {
        if (isAndroidDevice() == false) return;

        StartAppWrapper.init();
    }

    void OnGUI() {
        if (isAndroidDevice() == false) return;

        /*if (splashScreen) {
            StartAppWrapper.showSplash();
            splashScreen = false;
        }*/

        if(banner) {
            StartAppWrapper.addBanner(
              StartAppWrapper.BannerType.AUTOMATIC,
              StartAppWrapper.BannerPosition.BOTTOM);
            banner = false;
        }

        if (interstitial) {
            listener = new Listener();
            if(interestial_VIDEO)
                StartAppWrapper.loadAd(StartAppWrapper.AdMode.REWARDED_VIDEO, listener);
            else if (interestial_OFFERS)
                StartAppWrapper.loadAd(StartAppWrapper.AdMode.OFFERWALL, listener);
            else if (interestial_FULLPAGE)
                StartAppWrapper.loadAd(StartAppWrapper.AdMode.FULLPAGE, listener);
            interstitial = false;
        }
    }

    public void hideBanner() {
        if (isAndroidDevice()) {
            StartAppWrapper.removeBanner();
        }
    }

    private bool isAndroidDevice() {
        return (Application.platform == RuntimePlatform.Android);
    }
}

class Listener : StartAppWrapper.AdEventListener {

    public void onFailedToReceiveAd() {
        Debug.Log("Error. Ad not received from StartApp");
        
    }

    public void onReceiveAd() {
        Debug.Log("Ad received. Show ad");
        StartAppWrapper.showAd();
    }
}
