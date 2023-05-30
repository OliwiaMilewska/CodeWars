using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public int IsSolved(int[,] board)
  {
    var result = -1;
    var results = new List<int>();

    // Check horizontal
    var notFinished = 0;
    for (int i = 0; i < board.GetLength(0); i++)
    {
        var ex = 0;
        var circle = 0;
        for (int j = 0; j < board.GetLength(1); j++)
        {
            if (board[i, j] == 0)
                notFinished++;
            if (board[i, j] == 1)
                ex++;
            if (board[i, j] == 2)
                circle++;
        }

        if (ex == 3)
            results.Add(1);
        else if (circle == 3)
            results.Add(2);
    }

    // Check vertical
    for (int i = 0; i < board.GetLength(0); i++)
    {
        var ex = 0;
        var circle = 0;
        for (int j = 0; j < board.GetLength(1); j++)
        {
            if (board[j, i] == 1)
                ex++;
            if (board[j, i] == 2)
                circle++;
        }

        if (ex == 3)
            results.Add(1);
        else if (circle == 3)
            results.Add(2);
    }

    // Check diagonal 1
    var exDiag = 0;
    var circleDiag = 0;
    for (int i = 0; i < board.GetLength(0); i++)
    {
        if (board[i, i] == 1)
            exDiag++;
        if (board[i, i] == 2)
            circleDiag++;

        if (exDiag == 3)
            results.Add(1);
        else if (circleDiag == 3)
            results.Add(2);
    }

    // Check diagonal 2
    exDiag = 0;
    circleDiag = 0;
    for (int i = 0; i < board.GetLength(0); i++)
    {
        if (board[i, board.GetLength(1) - 1 - i] == 1)
            exDiag++;
        if (board[i, board.GetLength(1) - 1 - i] == 2)
            circleDiag++;
    }
    if (exDiag == 3)
        results.Add(1);
    else if (circleDiag == 3)
        results.Add(2);

    // Check the results and determine the outcome
    var exCount = results.Count(x => x == 1);
    var circlesCount = results.Count(x => x == 2);
    if (exCount > circlesCount)
        result = 1;
    else if (exCount < circlesCount)
        result = 2;
    else if (notFinished > 0)
        result = -1; //There are still empty spaces on a board
    else
        result = 0; //No empty spaces = draw

    return result;
  }
}