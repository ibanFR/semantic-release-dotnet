namespace LiftButton.Tests;

public class LiftTests
{
    //TEST LIST
    //[X] - doors should be CLOSED when Lift is created
    //[X] - should switch lights ON when button is pressed and doors are CLOSED
    //[] - should OPEN the lift doors when lift arrives
    //[] - should switch OFF the lights when lift arrives
    //[] - lights should be OFF when button is pressed and doors are OPEN

    [Test]
    public void DoorsShouldBeClosedWhenLiftIsCreated()
    {
        var lift = new Lift();
        Assert.That(lift.Doors(), Is.EqualTo("Closed"));
    }

    [Test]
    public void ShouldSwitchLightsOnWhenButtonIsPressedAndDoorsAreClosed()
    {
        //Arrange
        var lift = new Lift();
        //Act
        lift.PressButton();
        //Assert
        Assert.That(lift.Lights(), Is.EqualTo("On"));
    }
    
    
}