using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations; // we need to add these two namespaces

public class AdressablesTip : MonoBehaviour
{
    // Adressables are good for instantiating prefabs, loading assets and scenes
    // can be useful for loading worlds and save memory
    // we can load objects from server, so we can add content dinamically without updating the game
    // firts we need to install the package
    // then we need to create a group, windows -> asset management -> adressables -> groups 
    // so we drop a prefab on group, we need to mark prefab with addressable attribute

    [SerializeField] AssetReferenceGameObject prefabReference; // we need to create a reference to the prefab

    [SerializeField] AssetReferenceGameObject prefabReference2;
    GameObject instanceRefarence;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            prefabReference.LoadAssetAsync().Completed += OnLoadDone; // we load the asset
        }

        // we can use prefabReference.InstantiateAsync() to instantiate the object, its the same, but dont have a event

        if(Input.GetKeyDown(KeyCode.A))
        {
            prefabReference2.InstantiateAsync().Completed += OnAddressableInstantiated; // we can instantiate the object with a position and rotation
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            Destroy(instanceRefarence); // we can destroy the object
        }
    }

   

    private void OnLoadDone(AsyncOperationHandle<GameObject> handle) // this event is for verify if the asset was loaded
    {
        if(handle.Status == AsyncOperationStatus.Succeeded)
        {
            Instantiate(handle.Result); // we instantiate the object
        }
        else
        {
            Debug.LogError("Failed to load asset");
        }
    }



    private void OnAddressableInstantiated(AsyncOperationHandle<GameObject> handle)
    {
        if(handle.Status == AsyncOperationStatus.Succeeded)
        {
            instanceRefarence = handle.Result;
        }
        else
        {
            Debug.LogError("Failed to load asset");
        }
       
    }

    // we can add audioclips too, but we need to create a specific class with : AssetReferenceT<AudioClip>, make this System.Serializable, create a constructor and after that put on class
    // for load objects from server we need to go on AddressableAssetsData - adressableAssetSetings - enable the option "build remote catalog", mark build & load paths with remote
    // then scrool down and click on packed assets on assetGroupTemplates
    // build & load paths with mark with custom
    // build path with remote.buildpath
    // Loadpath with remote.loadpath
    // after this go to default local group on assetgroup folder and change uptade restriction for can change post release, and other same as before
    // middle seetings default local group bundledAssetGroupSchema, change the build path to remote.buildpath and load path to remote.loadpath
    // and finally on AdressablesSettings click on manage profile and change remote for custom
    // after that put the url from your server, but we use the unity content delivery network
    // we have the limit of 50 gigabytes for this work
    // we need to create a bucket, drop down on entries, delete all, click on upload content
    // for get the content on your unity project we go back for adressable groups, click on new build and default build scripts, inside on serverData folder we have your files
    // juts get this files and drop on upload content on entries nad after that upload files
    // refresh the page, create a notes, badges and confirm
    // after that acess on releases, on addressable remote paths urls and copy the url
    // and past on remote load path on adressable settings
    // this is crazy, but works very well
}
