public interface IExplodeable
{
    //Variables
    public float Mass{get; set;}

    public float ExplosiveForce{get; set;}

    public int FuseDelay{get; set;}

    //Methods
    public void Explode();
}

