namespace LiftButton;

public class Lift
{
    private string _lights;
    private string _doors;

    public Lift()
    {
        _lights = "Off";
        _doors = "Closed";
    }


    public string Doors()
    {
        return _doors;
    }

    public void PressButton()
    {
        _lights = "On";
    }

    public string Lights()
    {
        return _lights;
    }

    public void Arrive()
    {
        _doors = "Open";
    }
}