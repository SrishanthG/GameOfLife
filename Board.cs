using System.Runtime.CompilerServices;

namespace GameOfLife;

class Board
{
    private int _gridSize;
    public int GridSize
    {
        get {return _gridSize;}
        set
        {
            if (value > 0 || value < 256) _gridSize = value;
            else _gridSize = 10;
        }
    }

    private bool [,] boardStateCurrent;
    private bool [,] boardStateNext;

    public Board(int gridSize)
    {
        this.GridSize = gridSize;

        boardStateCurrent = new bool [gridSize,gridSize];
        boardStateNext = new bool [gridSize,gridSize];
    }

    public bool GetCellState(int i, int j)
    {
        return boardStateCurrent[i,j];
    }
}