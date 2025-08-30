using UnityEngine;

public class EnemyUnit : MonoBehaviour, IMovable, IUnitStats, IDamageable
{
    //IMovable Variables
    public int MoveSpeed{get; set;}

    public float Acceleration{get; set;}

    //IUnitStats Variables
    public int Strength{get; set;}

    public int Dexterity{get; set;}

    public int Endurance{get; set;}

    //IDamageable Variables
    public int Health{get; set;}

    public int Defense{get; set;}

    //IMovable Methods
    public virtual void GoForward()
    {
        Debug.Log("Moving forward...");
    }

    public virtual void Reverse()
    {
        Debug.Log("Moving backwards...");
    }

    public virtual void TurnLeft()
    {
        Debug.Log("Turning left...");
    }

    public virtual void TurnRight()
    {
        Debug.Log("Turning left...");
    }

    //IDamageable Methods
    public virtual void Die()
    {
        Debug.Log("Enemy died!");
    }

    public virtual void TakeDamage()
    {
        Debug.Log("Enemy took damage!");
    }

    public virtual void RestoreHealth()
    {
        Debug.Log("Enemy restored their health!");
    }
}
