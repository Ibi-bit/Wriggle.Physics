using System.Numerics;

namespace Wriggle.Physics;

public abstract class AreaEffect
{
    public Vector2 Position { get; }

    protected AreaEffect(Vector2 position)
    {
        Position = position;
    }

    public abstract void ApplyEffect(PhysicsWorld world);
}

public class ExplosionAreaEffect : AreaEffect
{
    public float Radius { get; }
    public float Force { get; }
    public float Damage { get; }

    public ExplosionAreaEffect(Vector2 position, float radius, float force, float damage)
        : base(position)
    {
        Radius = radius;
        Force = force;
        Damage = damage;
    }

    public override void ApplyEffect(PhysicsWorld world)
    {
        world.ApplyRadialImpulse(Position, Radius, Force);
        world.CarveTerrain(Position, Radius);
    }

    public float GetDamageAt(Vector2 targetPosition)
    {
        if (Radius <= 0f)
            return 0f;

        float distance = Vector2.Distance(Position, targetPosition);
        return distance < Radius ? Damage * (1f - distance / Radius) : 0f;
    }
}
