using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого слона: ");
            var whiteBishopPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию черного ферзя: ");
            var blackQueenPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию хода белого слона: ");
            var move = Console.ReadLine();

            if (IsWhiteBishopMoveCorrect(whiteBishopPosition, move) && !IsBlackQueenCanStrike(blackQueenPosition, move))
            {
                Console.WriteLine("Ход белого слона возможен.");
            }
            else
            {
                Console.WriteLine("Слон не может ходить сюда, так как находится под боем.");
            }

            Console.ReadKey();
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            column = (int)position[0] - 'a' + 1; // 'a' - это 1-я колонка
            row = int.Parse(position[1].ToString());
        }

        static bool IsWhiteBishopMoveCorrect(string whiteBishopPosition, string move)
        {
            int wbRow, wbColumn, mRow, mColumn;

            DecodePosition(whiteBishopPosition, out wbColumn, out wbRow);
            DecodePosition(move, out mColumn, out mRow);

            return Math.Abs(wbRow - mRow) == Math.Abs(wbColumn - mColumn);
        }

        static bool IsBlackQueenCanStrike(string blackQueenPosition, string position)
        {
            int bqRow, bqColumn, pRow, pColumn;

            DecodePosition(blackQueenPosition, out bqColumn, out bqRow);
            DecodePosition(position, out pColumn, out pRow);

            // Ферзь бьет по горизонтали, вертикали и диагонали 
            return (bqRow == pRow || bqColumn == pColumn || Math.Abs(bqRow - pRow) == Math.Abs(bqColumn - pColumn));
        }
    }
}
 