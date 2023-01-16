using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmegaSudokuSolver;

namespace OmegaSudokuTester
{
    [TestClass]
    public class TestsFor4X4
    {
        [TestMethod]
        public void TestEmpty4X4()
        {
            string board = "0000000000000000";
            string expectedSolution = "1234341221434321";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        [TestMethod]
        public void Test1For4X4()
        {
            string board = "0001010030001002";
            string expectedSolution = "2341412332141432";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        [TestMethod]
        public void Test2For4X4()
        {
            string board = "4321000012340000";
            string expectedSolution = "4321214312343412";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        [TestMethod]
        public void Test3For4X4()
        {
            string board = "1200002134000043";
            string expectedSolution = "1234432134122143";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        [TestMethod]
        public void Test4For4X4()
        {
            string board = "3001400300001030";
            string expectedSolution = "3241412323141432";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        [TestMethod]
        public void Test5For4X4()
        {
            string board = "4200104000310000";
            string expectedSolution = "4213134224313124";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        //duplicate elements in row
        [TestMethod]
        public void DuplicateElementsInRowExceptionFor4X4()
        {
            string board = "4204104000310000";
            Assert.ThrowsException<DuplicateElementsException>(() => Sudoku.Solve(new Board(board)));
        }

        //duplicate elements in col
        [TestMethod]
        public void DuplicateElementsInColExceptionFor4X4()
        {
            string board = "4200404000310000";
            Assert.ThrowsException<DuplicateElementsException>(() => Sudoku.Solve(new Board(board)));
        }

        //duplicate elements in sub square
        [TestMethod]
        public void DuplicateElementsInSubSquareExceptionFor4X4()
        {
            string board = "4200140000310000";
            Assert.ThrowsException<DuplicateElementsException>(() => Sudoku.Solve(new Board(board)));
        }
    }
}