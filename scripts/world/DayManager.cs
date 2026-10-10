
using Godot;

public partial class DayManager : Node
{
	public int CurrentDay { get; private set; } = 1;

	[Signal]
	public delegate void DayChangedEventHandler(int newDay);

	public override void _Ready()
	{
		GD.Print($"N.E.R.D.S. - Día actual: {CurrentDay}");
	}

	public void AdvanceDay()
	{
		if (CurrentDay >= 3)
		{
			GD.Print("Ya estás en el último día.");
			return;
		}

		CurrentDay++;

		EmitSignal(SignalName.DayChanged, CurrentDay);

		GD.Print($"N.E.R.D.S. - Avanzaste al día {CurrentDay}");
	}
}
