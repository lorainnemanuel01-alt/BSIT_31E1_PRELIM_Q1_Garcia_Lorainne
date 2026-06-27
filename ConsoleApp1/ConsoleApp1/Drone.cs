namespace TransportChallenge;

public class Drone : Vehicle, IFlyable
{
    public override string Move()
    {
        return "Flying in the sky.";
    }
}