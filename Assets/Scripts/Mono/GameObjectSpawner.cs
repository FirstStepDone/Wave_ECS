using UnityEngine;

public class GameObjectSpawner : Spawner
{
    public static WaveMonoComponent[] monoComponents;

    public override void Initialize(int widht, int height, Mesh objectMesh, Material objectMaterial)
    {
        monoComponents = new WaveMonoComponent[widht * height];

        float startX = widht / 2 * -1;
        float startZ = height / 2 * -1;

        int indexer = 0;
        for (int i = 0; i < widht; i++)
        {
            for (int ii = 0; ii < height; ii++)
            {
                float xPosition = startX + (i + 1) * 1;
                float zPosition = startZ + (ii + 1) * 1;

                float magnitude = Mathf.Sqrt(xPosition * xPosition + zPosition * zPosition);

                GameObject gameObject = new GameObject("GameObject", typeof(MeshRenderer), typeof(MeshFilter), typeof(WaveMonoComponent));

                gameObject.GetComponent<MeshFilter>().mesh = objectMesh;
                gameObject.GetComponent<MeshRenderer>().material = objectMaterial;

                gameObject.transform.position = new Vector3(xPosition, 0, zPosition);

                WaveMonoComponent waveMonoComponent = gameObject.GetComponent<WaveMonoComponent>();
                waveMonoComponent.distanceToOrigin = magnitude;
                monoComponents[indexer] = waveMonoComponent;

                indexer++;
            }    
        }
    }

}
