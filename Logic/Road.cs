public class Road : IRoad
{
    private IVehicle[,] vehicles;
    public int RowCount { get; }
    public int ColCount { get; }
    public Road(int row, int col)
    {
        RowCount = row;
        ColCount = col;
        vehicles = new IVehicle[RowCount, ColCount];
    }
    public void SetVehicle(int row, int column, IVehicle vehicle)
    {
        vehicles[row, column] = vehicle;
    }
    public IVehicle? GetVehicle(int row, int column)
    {
        return vehicles[row, column];
    }
}