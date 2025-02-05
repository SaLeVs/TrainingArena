using UnityEngine;

public class ShaderGraph : MonoBehaviour
{
    // Visual tool for creating Shaders no need to write any code
    // if you press shift+space you can maximaze and minimize the graph, not only the graph but all the windows in unity
    // if you click on shader graph, you can create a material with base on the shader graph

    private Material material;

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            material.SetColor("_Color", Color.red);
        }
    }

    // Some differences on shader graph V10
    // Properties are now on left side, we have a dedicate graph inspector
    // we cant create the master node
    // we can make a shader for universal or HDRP
    // The most big difference is on the divide 4 corlous node, we have to use split

}
