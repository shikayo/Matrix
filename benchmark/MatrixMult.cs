using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using Microsoft.Diagnostics.Tracing.Parsers.IIS_Trace;

namespace benchmark;

public class MatrixMult
{
    public static int[,] matrix1;
    public static int[,] matrix2;
    public static int dim;
    public static Random rnd = new Random();
    public static void Te()
    {
        
        var n = int.Parse(Console.ReadLine());
        matrix1 = new int[n, n];
        matrix2 = new int[n, n];
        dim = n;
        for (int i = 0; i < dim; i++)
        {
            for (int j = 0; j < dim; j++)
            {

                matrix1[i, j] = rnd.Next(0, 10);
            }
        }
        Console.WriteLine("вторая матрица");
        for (int i = 0; i < dim; i++)
        {
            for (int j = 0; j < dim; j++)
            {

                matrix2[i, j] = rnd.Next(0, 10);
            }
        }
    }
    
    [Benchmark]
    public int[,] CalcIJK()
    {
        var matrix = new int[dim, dim];
        for (var i = 0; i < dim; i++)
        {
            for (var j = 0; j < dim; j++)
            {
                for (var k = 0; k < dim; k++)
                {
                    matrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return matrix;
    }

    [Benchmark]
    public int[,] CalcIKJ()
    {
        var matrix = new int[dim, dim];
        for (var i = 0; i < dim; i++)
        {
            for (var j = 0; j < dim; j++)
            {
                for (var k = 0; k < dim; k++)
                {
                    matrix[i, k] += matrix1[i, j] * matrix2[j, k];
                }
            }
        }

        return matrix;
    }

    [Benchmark()]
    public int[,] CalcJIK()
    {
        var matrix = new int[dim, dim];
        for (var i = 0; i < dim; i++)
        {
            for (var j = 0; j < dim; j++)
            {
                for (var k = 0; k < dim; k++)
                {
                    matrix[j, i] += matrix1[j, k] * matrix2[k, i];
                }
            }
        }

        return matrix;
    }

    [Benchmark()]
    public int[,] CalcJKI()
    {
        var matrix = new int[dim, dim];
        for (var i = 0; i < dim; i++)
        {
            for (var j = 0; j < dim; j++)
            {
                for (var k = 0; k < dim; k++)
                {
                    matrix[j, k] += matrix1[j, i] * matrix2[i, k];
                }
            }
        }

        return matrix;
    }

    [Benchmark()]
    public int[,] CalcKIJ()
    {
        var matrix = new int[dim, dim];
        for (var i = 0; i < dim; i++)
        {
            for (var j = 0; j < dim; j++)
            {
                for (var k = 0; k < dim; k++)
                {
                    matrix[k, i] += matrix1[k, j] * matrix2[j, i];
                }
            }
        }

        return matrix;
    }

    [Benchmark()]
    public int[,] CalcKJI()
    {
        var matrix = new int[dim, dim];
        for (var i = 0; i < dim; i++)
        {
            for (var j = 0; j < dim; j++)
            {
                for (var k = 0; k < dim; k++)
                {
                    matrix[k, j] += matrix1[k, i] * matrix2[i, j];
                }
            }
        }

        return matrix;
    }
}