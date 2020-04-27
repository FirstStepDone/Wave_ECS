using Unity.Entities;
using Unity.Transforms;
using Unity.Burst;
using Unity.Mathematics;
using Unity.Jobs;

[BurstCompile]
public class WaveSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle input)
    {
        var output = Entities.ForEach((ref Translation translation, in DistanceToOrigin distance, in Lifetime lifetime) =>
        {
            translation.Value.y = math.sin((distance.Value - lifetime.Value) * 0.5f);
        }).Schedule(input);

        return output;
    }
}
