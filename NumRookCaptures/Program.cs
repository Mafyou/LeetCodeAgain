using System;

namespace NumRookCaptures
{
    class Solution
    {
        public int NumRookCaptures(char[][] board)
        {
            int n = board.Length;
            int m = board[0].Length;
            int x = 0, y = 0, cnt = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        x = i;
                        y = j;
                        break;
                    }
                }
            }
            for (int i = x - 1; i >= 0; i--)
            {
                if (board[i][y] == 'p')
                {
                    cnt++;
                    break;
                }
                else if (board[i][y] != '.')
                    break;
            }
            for (int i = x + 1; i < n; i++)
            {
                if (board[i][y] == 'p')
                {
                    cnt++;
                    break;
                }
                else if (board[i][y] != '.')
                    break;
            }

            for (int i = y - 1; i >= 0; i--)
            {
                if (board[x][i] == 'p')
                {
                    cnt++;
                    break;
                }
                else if (board[x][i] != '.')
                    break;
            }
            for (int i = y + 1; i < m; i++)
            {
                if (board[x][i] == 'p')
                {
                    cnt++;
                    break;
                }
                else if (board[x][i] != '.')
                    break;
            }
            return cnt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            char[][] board = new char[][] { new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }, new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' }, new char[] { '.', '.', '.', 'R', '.', '.', '.', 'p' }, new char[] { '.', '.', '.', '.', '.', '.', '.', '.'},new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },new char[] { '.', '.', '.', 'p', '.', '.', '.', '.'},new char[] { '.', '.', '.', '.', '.', '.', '.', '.'},new char[] {'.', '.', '.', '.', '.', '.', '.', '.'} };
            Console.WriteLine(s.NumRookCaptures(board));
        }
    }
}