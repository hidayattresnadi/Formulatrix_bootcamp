public abstract class Piece
{
    private int _id;
    private Colour _pieceColour;

    private enum Type;

    private bool _hasMoved;

// SearchValidLocations(Location current, int boardSize) : List<Location>
// public bool MoveTo(Location newLocation){
// return true }
}

public enum Type
{
    PAWN = 1,
    KNIGHT = 3,
    BISHOP = 3,
    ROOK = 5,
    QUEEN = 9,
    KING
}