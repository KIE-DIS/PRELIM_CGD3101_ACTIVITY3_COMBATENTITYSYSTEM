public interface IMovable
{
    //Variables
    public int MoveSpeed{get; set;}

    public float Acceleration{get; set;}

    //Methods
    public void GoForward();

    public void Reverse();

    public void TurnLeft();

    public void TurnRight();
}
