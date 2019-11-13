using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExercises
{
    public class Sudoku
    {
        private readonly int[][] board;

        public Sudoku(int[][] board)
        {
            this.board = board;
        }

        public bool CheckSudoku()
        {
            return ValidateRows() && ValidateColumns() && ValidateSquares();
        }

        private bool ValidateRows()
        {
            return board.All(x => x.Where(c => c > 0 && c < 10).Distinct().Count() == 9);
        }

        private bool ValidateColumns()
        {
            return Enumerable.Range(0, board.Length).Select((x, i) =>
                board.Select(x => x[i])).All(x => x.Where(c => c > 0 && c < 10).Distinct().Count() == 9);
        }

        private bool ValidateSquares()
        {
            return Enumerable.Range(0, 3).All(x =>
                Enumerable.Range(0, 3).All(y => GetSquares(x, y)
                .Where(c => c > 0 && c < 10).Distinct().Count() == 9));
        }

        private IEnumerable<int> GetSquares(int x, int y)
        {
            return Enumerable.Range(0, 3).SelectMany(a =>
                Enumerable.Range(0, 3).Select(b => board[x * 3 + a][(y * 3) + b]));
        }
    }
}
