using UnityEngine;

public class RenderTextureTest : MonoBehaviour
{
    // we can use for create minimpas ou cams for view the world

    private void Start()
    {
        RenderTexture renderTeture = new RenderTexture(256, 256, 8);
        Camera.main.targetTexture = renderTeture;
        Camera.main.Render();
        Camera.main.targetTexture = null;
    }
}
