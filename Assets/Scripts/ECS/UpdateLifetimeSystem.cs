using Unity.Entities;
using Unity.Burst;
using Unity.Mathematics;
using Unity.Jobs;

[BurstCompile]
public class UpdateLifetimeSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle input)
    {
        float value = math.mul(Time.DeltaTime, 5f);
        var output = Entities.ForEach((ref Lifetime component) =>
        {
            component.Value += value;
        }).Schedule(input);

        return output;
    }
}
