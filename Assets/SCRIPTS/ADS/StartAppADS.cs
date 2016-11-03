using UnityEngine;
using StartApp;
using System;

public class StartAppADS : MonoBehaviour {
    public bool randomInterestial = false;
    public bool banner = false;
    public bool interestial_VIDEO = false;
    public bool interestial_OFFERS = false;
    public bool interestial_FULLPAGE = false;
    private bool interstitial = false;
    private Listener listener;

	void Start () {
        if (isAndroidDevice() == false) return;
        setRandom();
        if(interestial_VIDEO || interestial_OFFERS || interestial_FULLPAGE) {
            interstitial = true;
        }
        StartAppWrapper.init();
    }

    void OnGUI() {
        if (isAndroidDevice() == false) return;

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

    private void setRandom() {
        if (randomInterestial == false) return;
        interestial_VIDEO = false;
        interestial_OFFERS = false;
        interestial_FULLPAGE = false;
        switch (UnityEngine.Random.Range(0, 3)) {
            case 0:
                interestial_VIDEO = true;
                break;
            case 1:
                interestial_OFFERS = true;
                break;
            case 2:
                interestial_FULLPAGE = true;
                break;
            default:
                break;
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
