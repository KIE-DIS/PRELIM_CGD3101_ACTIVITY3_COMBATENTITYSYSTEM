using UnityEngine;

public class ExplodingBarrel : MonoBehaviour, IDamageable, IExplodeable
{
    //IDamageable Variables
    public int Health{get; set;}

    public int Defense{get; set;}

    //IExplodable Variables
    public float Mass{get; set;}

    public float ExplosiveForce{get; set;}

    public int FuseDelay{get; set;}

    //IDamageable Methods
    public virtual void Die()
    {
        Debug.Log("The barrel died!");
    }

    public virtual void TakeDamage()
    {
        Debug.Log("The barrel took damage!");
    }

    public virtual void RestoreHealth()
    {
        Debug.Log("The barrel restored its health!");
    }

    //IExplodeable Methods
    public virtual void Explode()
    {
        Debug.Log("The barrel exploded!");
    }
}
