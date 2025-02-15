using UnityEngine;

public class VsyncCountTip : MonoBehaviour
{
    // Its good test if the game is workin in every frame rate, so we can test  using application.targetFrameRate = ?;

    // vsynccount on unity quality settings determinehow te rendering of frames is synchronized with the refresh rate of the display
    // this helps prevent screen tearing, but can also limit the frame rate of the game
    // Every V Blank = Vscync count to 1 (60hz = 60fps)
    // Every 2 V Blanks = Vscync count to 2 (30hz = 30fps), this might be useful to maintain full refresh rate performance
    // Disabling vsync allows for maximium fps, but can result in screen tearing
    // Some plataforms force vsync on hardare level, so this setting may not be available on all platforms
}
