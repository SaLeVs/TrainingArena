using UnityEngine;

public class EnterPlayModeSettingsTip : MonoBehaviour
{
    // If your scene was too slow to load, you can change the settings to load the scene faster
    // Go to Edit -> Project Settings -> Editor -> Enter Play Mode Settings
    // default is reload domain & scene - time to load = HIGH - secutiry with bugs = maximium - when use? normal development and final tests
    // disable reload scene - time to load = MID - secutiry with bugs = medium - when use? when need maintain objects and test little changes
    // disable reload domain - time to load = MID - secutiry with bugs = medium - when use? when need maintain statics variables between executions
    // disable  reload domain & scene - time to load = FAST - secutiry with bugs = low - when use? for fast tests and UI debugs, but can cause bugs
}
