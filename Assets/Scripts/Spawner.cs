using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    public abstract void Initialize(int w, int h, Mesh mesh, Material material);
}
