using Xunit;

namespace LinqExercises
{
    public class SudokuTests
    {
        [Fact]
        public void CorrectBoardRows()
        {
            var board = new Sudoku(new[]
            {
                new[] { 2, 8, 6, 1, 5, 4, 9, 7, 3 },
                new[] { 1, 9, 5, 7, 6, 3, 8, 4, 2 },
                new[] { 7, 4, 3, 2, 8, 9, 5, 1, 6 },
                new[] { 3, 7, 9, 6, 2, 5, 4, 8, 1 },
                new[] { 8, 5, 1, 3, 4, 7, 6, 2, 9 },
                new[] { 4, 6, 2, 9, 1, 8, 7, 3, 5 },
                new[] { 6, 3, 4, 5, 7, 2, 1, 9, 8 },
                new[] { 9, 1, 7, 8, 3, 6, 2, 5, 4 },
                new[] { 5, 2, 8, 4, 9, 1, 3, 6, 7 }
            });

            Assert.True(board.CheckSudoku());
        }

        [Fact]
        public void IncorrectBoardDoubleDigit()
        {
            var board = new Sudoku(new[]
            {
                new[] { 2, 8, 6, 1, 5, 4, 9, 7, 3 },
                new[] { 1, 9, 5, 7, 6, 3, 8, 4, 2 },
                new[] { 7, 4, 3, 2, 8, 9, 5, 1, 6 },
                new[] { 3, 7, 9, 6, 2, 5, 4, 8, 1 },
                new[] { 8, 5, 1, 3, 4, 7, 6, 2, 9 },
                new[] { 4, 6, 2, 9, 1, 8, 7, 3, 5 },
                new[] { 6, 3, 4, 5, 7, 2, 1, 9, 8 },
                new[] { 9, 1, 7, 8, 3, 6, 2, 5, 4 },
                new[] { 5, 2, 8, 4, 9, 1, 3, 6, 8 }
            });

            Assert.False(board.CheckSudoku());
        }

        [Fact]
        public void IncorrectBoardNumber()
        {
            var board = new Sudoku(new[]
            {
                new[] { 2, 8, 6, 1, 5, 4, 9, 7, 3 },
                new[] { 1, 9, 5, 7, 6, 3, 8, 4, 2 },
                new[] { 7, 4, 3, 2, 8, 9, 5, 1, 6 },
                new[] { 3, 7, 9, 6, 2, 5, 4, 8, 1 },
                new[] { 8, 5, 1, 3, 4, 7, 6, 2, 9 },
                new[] { 4, 6, 2, 9, 1, 8, 7, 3, 5 },
                new[] { 6, 3, 4, 5, 7, 2, 1, 9, 8 },
                new[] { 9, 1, 7, 8, 3, 6, 2, 5, 4 },
                new[] { 5, 2, 8, 4, 9, 1, 3, 6, 10 }
            });

            Assert.False(board.CheckSudoku());
        }

        [Fact]
        public void IncorrectBoard()
        {
            var board = new Sudoku(new[]
            {
                new[] { 2, 8, 6, 1, 5, 4, 9, 7, 3 },
                new[] { 1, 9, 5, 7, 6, 3, 8, 4, 2 },
                new[] { 7, 4, 3, 2, 8, 9, 5, 1, 6 },
                new[] { 3, 7, 9, 6, 2, 5, 4, 8, 1 },
                new[] { 8, 5, 1, 3, 4, 7, 6, 2, 9 },
                new[] { 4, 6, 2, 9, 1, 8, 7, 3, 5 },
                new[] { 6, 3, 4, 5, 7, 2, 1, 9, 8 },
                new[] { 9, 1, 7, 8, 3, 6, 2, 5, 4 },
                new[] { 5, 2, 8, 4, 9, 1, 3, 6 }
            });

            Assert.False(board.CheckSudoku());
        }
    }
}
