using UnityEngine;

// we have to add these 2 namespaces
using UnityEngine.U2D; 
using UnityEngine.UI;

public class SpriteAtlasTip : MonoBehaviour
{
    // include in build
    // tigh packing is for better performance
    // we can set a different sprite for each plataform
    // we can override the sprite for each plataform
    // we grab a folder and put for packing
    // for use a sprite atlas we need to create a sprite atlas script

    [SerializeField] private SpriteAtlas spriteAtlas;
    [SerializeField] private string spriteName; // these name will be the name that the asset have in folder that we put in sprite atlas

    private void Awake()
    {
        Image image = GetComponent<Image>();
        image.sprite = spriteAtlas.GetSprite(spriteName);
    }

}
