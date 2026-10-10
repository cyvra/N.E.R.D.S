
using Godot;

public partial class WorldManager : Node
{
	private DayManager _dayManager;

	public override void _Ready()
	{
		_dayManager = GetNode<DayManager>("/root/DayManager");

		_dayManager.DayChanged += OnDayChanged;

		GD.Print("WorldManager conectado correctamente.");
		ApplyDay(_dayManager.CurrentDay);
	}

	private void OnDayChanged(int newDay)
	{
		ApplyDay(newDay);
	}

	private void ApplyDay(int day)
	{
		switch (day)
		{
			case 1:
				GD.Print("Mundo: ambiente normal.");
				break;

			case 2:
				GD.Print("Mundo: preparar niebla y lluvia.");
				break;

			case 3:
				GD.Print("Mundo: preparar ambiente distorsionado.");
				break;
		}
	}
}
