using UnityEngine;
using UnityEngine.UI;

public class SpriteXTexture : MonoBehaviour
{
    // Learn the differences and how to convert one into another
    // RawImage x Image
    // Sprite x Texture2D

    // image recive only sprites
    // rawimage recive only textures

    [SerializeField] private Texture2D texture;
    [SerializeField] private Sprite sprite;

    private void Awake()
    {
        // how to convert sprite into texture

        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(.5f, .5f));
        GetComponent<Image>().sprite = sprite;

        // how to convert texture into sprite

        GetComponent<RawImage>().texture = sprite.texture;

        // basically, you can convert one into another by using the texture property of the sprite, pay attetion on component and where these scripts are attached

    }
}
