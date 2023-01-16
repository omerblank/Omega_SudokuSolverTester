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
    public class TestsForGeneralExceptions
    {
        //illegal input length exception
        [TestMethod]
        public void IllegalLengthException()
        {
            string board = "4200140000310000000";
            Assert.ThrowsException<InputLengthException>(() => Sudoku.Solve(new Board(board)));
        }

        //unsolvable grid exception
        [TestMethod]
        public void UnsolvableGridException()
        {
            string board = "0010320010000020";
            Assert.ThrowsException<UnsolvableGridException>(() => Sudoku.Solve(new Board(board)));
        }

        //illegal value exception 1
        [TestMethod]
        public void IllegalValueException1()
        {
            string board = "0010520010000000";
            Assert.ThrowsException<ArgumentException>(() => Sudoku.Solve(new Board(board)));
        }

        //illegal value exception 2
        [TestMethod]
        public void IllegalValueException2()
        {
            string board = "0010320000ע00000";
            Assert.ThrowsException<ArgumentException>(() => Sudoku.Solve(new Board(board)));
        }
    }
}
