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
            return Validate(board) && Validate(GetColumns()) && Validate(GetSquares());
        }

        private bool Validate(IEnumerable<IEnumerable<int>> item)
        {
            return item.All(x => x.Where(c => c > 0 && c < 10).Distinct().Count() == 9);
        }

        private IEnumerable<IEnumerable<int>> GetColumns()
        {
            return Enumerable.Range(0, board.Length).Select((x, i) =>
                board.Select(x => x[i]));
        }

        private IEnumerable<IEnumerable<int>> GetSquares()
        {
            return Enumerable.Range(0, 3).SelectMany(x =>
                Enumerable.Range(0, 3).Select(y => GetSquares(x, y)));
        }

        private IEnumerable<int> GetSquares(int x, int y)
        {
            return Enumerable.Range(0, 3).SelectMany(a =>
                Enumerable.Range(0, 3).Select(b => board[x * 3 + a][(y * 3) + b]));
        }
    }
}
