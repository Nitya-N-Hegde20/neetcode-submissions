public class Solution {
    public bool IsValidSudoku(char[][] board) {
       var rows = new bool[9, 9];
        var cols = new bool[9, 9];
        var boxes = new bool[9, 9];

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                if (board[r][c] == '.') continue;
                int d = board[r][c] - '1';          // digit → index 0..8
                int b = (r / 3) * 3 + (c / 3);      // box index 0..8
                if (rows[r, d] || cols[c, d] || boxes[b, d]) return false;
                rows[r, d] = cols[c, d] = boxes[b, d] = true;
            }
        }
        return true; 
    }
}
