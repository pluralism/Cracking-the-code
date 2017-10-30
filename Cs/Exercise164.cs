import java.util.ArrayList;

public class Exercise164 {
    enum Piece {
        Empty,
        Red,
        Blue
    }

    int convertBoardToInt(Piece[][] board) {
        int sum = 0;
        for(int i = 0; i < board.length; i++) {
            for(int j = 0; j < board[i].length; j++) {
                int value = board[i][j].ordinal();
                sum = sum * 3 + value;
            }
        }
        return sum;
    }

    Piece hasWon(Piece[][] board) {
        for(int i = 0; i < board.length; i++) {
            // Check row
            if(hasWinner(board[i][0], board[i][1], board[i][2]))
                return board[i][0];

            // Check columns
            if(hasWinner(board[0][i], board[1][i], board[2][i]))
                return board[0][i];

            // Check diagonals
            if(hasWinner(board[0][0], board[1][1], board[2][2]))
                return board[0][0];

            if(hasWinner(board[0][2], board[1][1], board[2][0]))
                return board[0][2];
        }
        return Piece.Empty;
    }

    boolean hasWinner(Piece p1, Piece p2, Piece p3) {
        return p1 != Piece.Empty && p1 == p2 && p2 == p3;
    }

    Piece hasWon2(Piece[][] board) {
        if(board.length != board[0].length)
            return Piece.Empty;
        int size = board.length;

        ArrayList<PositionIterator> instructions = new ArrayList<>();
        for(int i = 0; i < board.length; i++) {
            // Check column
            instructions.add(new PositionIterator(new Position(0, i), 1, 0, size));
            // Check row
            instructions.add(new PositionIterator(new Position(i, 0), 0, 1, size));
        }
        // Check diagonals
        instructions.add(new PositionIterator(new Position(0, 0), 1, 1, size));
        instructions.add(new PositionIterator(new Position(0, size - 1), 1, -1, size));

        for(PositionIterator iterator : instructions) {
            Piece winner = hasWon(board, iterator);
            if(winner != Piece.Empty)
                return winner;
        }
        return Piece.Empty;
    }

    Piece hasWon(Piece[][] board, PositionIterator iterator) {
        Position first = iterator.next();
        Piece firstPiece = board[first.row][first.column];
        while (iterator.hasNext()) {
            Position position = iterator.next();
            // All pieces must be equal
            if(board[position.row][position.column] != firstPiece)
                return Piece.Empty;
        }
        return firstPiece;
    }
}
