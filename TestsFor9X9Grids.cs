using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmegaSudokuSolver;

namespace OmegaSudokuTester
{
    [TestClass]
    public class TestsFor9X9Grids
    {
        [TestMethod]
        public void TestEmpty9X9()
        {
            string board = "000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            string expectedSolution = "123456789687139254495278136712893465956714823348625917261347598879561342534982671";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        [TestMethod]
        public void Test1For9X9()
        {
            string board = "800000070006010053040600000000080400003000700020005038000000800004050061900002000";
            string expectedSolution = "831529674796814253542637189159783426483296715627145938365471892274958361918362547";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        [TestMethod]
        public void Test2For9X9()
        {
            string board = "100000027000304015500170683430962001900007256006810000040600030012043500058001000";
            string expectedSolution = "193586427867324915524179683435962871981437256276815349749658132612743598358291764";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        [TestMethod]
        public void Test3For9X9()
        {
            string board = "000001000008000002000000000300000800000004000000000005000008006000000700000000100";
            string expectedSolution = "693521487178439562425876931362795814519684273847213695751948326936152748284367159";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        [TestMethod]
        public void Test4For9X9()
        {
            string board = "009000200008000001000000000203000800000004070000009005000008006000000700090000100";
            string expectedSolution = "159863247438927561627451938213675894965184372784239615371598426842316759596742183";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        [TestMethod]
        public void Test5For9X9()
        {
            string board = "900340600600007004020500013700009508008730062130000470340051700006000891871020040";
            string expectedSolution = "915342687683197254427568913764219538598734162132685479349851726256473891871926345";
            string actual = OmegaSudokuSolver.Sudoku.Solve(new Board(board));
            Assert.AreEqual(expectedSolution, actual);
        }

        //duplicate elements in row
        [TestMethod]
        public void DuplicateElementsInRowExceptionFor9X9()
        {
            string board = "900340609600007004020500013700009508008730062130000470340051700006000891871020040";
            Assert.ThrowsException<DuplicateElementsException>(() => Sudoku.Solve(new Board(board)));
        }

        //duplicate elements in col
        [TestMethod]
        public void DuplicateElementsInColExceptionFor9X9()
        {
            string board = "900340600900007004020500013700009508008730062130000470340051700006000891871020040";
            Assert.ThrowsException<DuplicateElementsException>(() => Sudoku.Solve(new Board(board)));
        }

        //duplicate elements in sub square
        [TestMethod]
        public void DuplicateElementsInSubSquareExceptionFor9X9()
        {
            string board = "900340609609007004020500013700009508008730062130000470340051700006000891871020040";
            Assert.ThrowsException<DuplicateElementsException>(() => Sudoku.Solve(new Board(board)));
        }
    }
}
