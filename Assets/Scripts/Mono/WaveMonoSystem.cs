using UnityEngine;

public class WaveMonoSystem : MonoBehaviour
{
    private float _time = 0;
            
    private void Update()
    {
        _time += Time.deltaTime * 5f;

        for (int i = 0; i < GameObjectSpawner.monoComponents.Length; i++)
        {
            WaveMonoComponent waveComponent = GameObjectSpawner.monoComponents[i];
            Vector3 pos = waveComponent.transform.position;
            pos.y = Mathf.Sin((waveComponent.distanceToOrigin - _time) * 0.5f);
            waveComponent.transform.position = pos;
        }
    }
}
