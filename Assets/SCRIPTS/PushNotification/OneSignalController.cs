using UnityEngine;
using System.Collections;

public class OneSignalController : MonoBehaviour {
    private const string ONE_SIGNAL_APP_ID = "0948c7b5-1d67-4561-89ed-918a0217f019";
    private const string GOOGLE_SENDER_ID = "136672613096";

    void Start() {
        // Enable line below to enable logging if you are having issues setting up OneSignal. (logLevel, visualLogLevel)
        //OneSignal.SetLogLevel(OneSignal.LOG_LEVEL.INFO, OneSignal.LOG_LEVEL.INFO);

        OneSignal.StartInit(ONE_SIGNAL_APP_ID, GOOGLE_SENDER_ID)
          .HandleNotificationOpened(HandleNotificationOpened)
          .EndInit();

        // Sync hashed email if you have a login system or collect it.
        //   Will be used to reach the user at the most optimal time of day.
        // OneSignal.syncHashedEmail(userEmail);
    }

    // Gets called when the player opens the notification.
    private static void HandleNotificationOpened(OSNotificationOpenedResult result) {
    }
}
