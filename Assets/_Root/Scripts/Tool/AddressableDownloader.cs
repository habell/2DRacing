using System;
using System.Collections;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace _Root.Scripts.Tool
{
    public class AddressableDownloader : MonoBehaviour
    {
        [SerializeField]
        private AssetReference _loadedPrefab;

        private const string PrefabID = "TestPrefab";
        
        [SerializeField]
        private GameObject _prefab;

        [SerializeField]
        private Transform _parent;
        
        public void StartFirstEnum()
        {
            _parent = transform.parent;
            StartCoroutine(CreateLocalAddressablePrefabWithAssetReference());
        }

        public void StartSecondEnum()
        {
            _parent = transform.parent;
            StartCoroutine(CreateSomePrefabWithUseStringID());
        }
        
        // ReSharper disable Unity.PerformanceAnalysis | ps. I dont like red lines..
        private IEnumerator CreateLocalAddressablePrefabWithAssetReference()
        {
            AsyncOperationHandle<GameObject> handle = _loadedPrefab.LoadAssetAsync<GameObject>();
            
            yield return handle;
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                _prefab = handle.Result;
                Instantiate(_prefab, _parent, true);
                Addressables.Release(handle);
            }
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private IEnumerator CreateSomePrefabWithUseStringID()
        {
            var handle = Addressables.InstantiateAsync(PrefabID);
            
            yield return handle;
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                _prefab = handle.Result;
                Instantiate(_prefab, _parent, true);
                Addressables.Release(handle);
            }
        }
    }
}
