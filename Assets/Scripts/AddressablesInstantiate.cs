using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Test : MonoBehaviour
{
    [SerializeField] private AssetLabelReference assetLabelReference;

    private GameObject justGO;

    void Start()
    {
        /*
        Addressables.LoadAssetAsync<Sprite>("Assets/2D/test/redHood.png").Completed +=
            (spriteHandle) =>
            {
                if (spriteHandle.Status == AsyncOperationStatus.Succeeded)
                {
                    Sprite wholeSprite = spriteHandle.Result;

                    gameObject.GetComponent<SpriteRenderer>().sprite = wholeSprite;

                }
            };
        */

        /*
        Addressables.LoadAssetAsync<GameObject>("Assets/Prefabs/redHood.prefab").Completed +=
            (spriteHandle) =>
            {
                if (spriteHandle.Status == AsyncOperationStatus.Succeeded)
                {
                    GameObject prefab = spriteHandle.Result;
                    Instantiate(prefab);
                }
            };
        */

        Addressables.LoadAssetsAsync<GameObject>(assetLabelReference, (go) =>
        {
            GameObject justGO = Instantiate(go);
        });

        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            Addressables.ReleaseInstance(justGO);
        }
    }
}
