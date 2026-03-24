

public class FixedLevelBuilder : ILevelbuilder
{
    public Level BuildLevel(int levelNumber)
    {
        Level level = new Level(10, 10, TerrainType.Forests);

        level.SetTerrainAt(2, 4, TerrainType.Mountains);
        level.SetTerrainAt(2, 5, TerrainType.Mountains);
        level.SetTerrainAt(6, 1, TerrainType.Desert);

        return level;  
    }
}

public interface ILevelbuilder
{
    Level BuildLevel(int levelNumber);
}

public class Level
{
    public int Width { get; }
    public int Height { get; }
    public TerrainType GetTerrainAt(int row, int column) { /* ... */ }
}


public enum TerrainType { Desert, Forests, Mountains, Pastures, Fields, Hills }