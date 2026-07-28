public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // create a dictionary of int and hashset for rows
        // create a dictionary of int and hashset for columns
        // create a dictionary to store current subgrid (key will be the coordinates of the subgrid)

        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<string, HashSet<char>>();

        // iterate through each row
        for (int r = 0; r < 9; r++)
        {
            //iterate through each column
            for (int c = 0; c < 9; c++)
            {
                // check if square is empty, if so continue
                if (board[r][c] == '.')
                    continue;
                
                // populate squaresKey for subgrids
                string squaresKey = r / 3 + "," + c / 3;

                // check for duplicates in each row, column and each subgrid
                if (rows.ContainsKey(r) && rows[r].Contains(board[r][c])
                || cols.ContainsKey(c) && cols[c].Contains(board[r][c])
                || squares.ContainsKey(squaresKey) && squares[squaresKey].Contains(board[r][c]))
                    return false;
                
                // check if keys exist, if not populate them
                if (!rows.ContainsKey(r))
                {
                    rows[r] = new HashSet<char>();
                }
                if (!cols.ContainsKey(c))
                {
                    cols[c] = new HashSet<char>();
                }
                if (!squares.ContainsKey(squaresKey))
                {
                    squares[squaresKey] = new HashSet<char>();
                }

                // fill each row, column and square after each pass
                rows[r].Add(board[r][c]);
                cols[c].Add(board[r][c]);
                squares[squaresKey].Add(board[r][c]);
            }
        }

        return true;
    }
}
