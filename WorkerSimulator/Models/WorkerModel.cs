using WorkerSimulator.Enums;

namespace WorkerSimulator.Models;

public class WorkerModel
{
	public MaterialType Material { get; private set; }
	public int Fuel { get; private set; }
	public int Speed { get; private set; }
}