namespace TransportChallenge;

public static class TransportResolver
{
    public static Vehicle? Resolve(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return null;

        return input.ToLower() switch
        {
            "car" => new Car(),
            "plane" => new Airplane(),
            "boat" => new Boat(),
            "helicopter" => new Helicopter(),
            // Bonus classes
            "motorcycle" => new Motorcycle(),
            "submarine" => new Submarine(),
            "drone" => new Drone(),
            // Handles invalid input
            _ => null
        };
    }
}