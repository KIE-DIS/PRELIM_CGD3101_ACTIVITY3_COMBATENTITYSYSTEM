public interface IDamageable
{
    //Variables
    public int Health{get; set;}

    public int Defense{get; set;}

    //Methods
    public void Die();

    public void TakeDamage();

    public void RestoreHealth();
}
