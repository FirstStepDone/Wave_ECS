using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializationSystem : MonoBehaviour
{
    public bool IsECS
    {
        get { return _useECS; }
    }

    public int GridSize
    {
        get { return _gridSize; }
    }

    public int EntityCount
    {
        get { return _gridSize * _gridSize; }
    }

    [SerializeField] private int _gridSize;
    [SerializeField] private Mesh _mesh;
    [SerializeField] private Material _material;
    [SerializeField] private bool _useECS;

    private void Awake()
    {
        System.Type spawnerType = _useECS ? typeof(EntitySpawner) : typeof(GameObjectSpawner);
        GameObject spawnerObject = new GameObject("Spawner", spawnerType);
        spawnerObject.GetComponent<Spawner>().Initialize(_gridSize, _gridSize, _mesh, _material);

        if (!_useECS)
            new GameObject("MonoWaveSystem", typeof(WaveMonoSystem));
    }
}
