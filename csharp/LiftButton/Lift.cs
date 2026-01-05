namespace LiftButton;

public class Lift
{
    private string _lights;

    public Lift()
    {
        _lights = "Off";
    }


    public string Doors()
    {
        return "Closed";
    }

    public void PressButton()
    {
        _lights = "On";
    }

    public string Lights()
    {
        return _lights;
    }
}