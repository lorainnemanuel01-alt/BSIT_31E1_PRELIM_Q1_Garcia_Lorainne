namespace TransportChallenge;

public class Motorcycle : Vehicle, IDriveable
{
    public override string Move()
    {
        return "Driving on the road.";
    }
}