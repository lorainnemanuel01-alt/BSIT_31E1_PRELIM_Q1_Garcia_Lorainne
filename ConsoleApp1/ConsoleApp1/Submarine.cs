namespace TransportChallenge;

public class Submarine : Vehicle, ISailable, IDivable
{
    public override string Move()
    {
        return "Sailing on the water.";
    }
}