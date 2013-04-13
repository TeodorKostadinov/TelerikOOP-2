using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Matrix<T> where T : IComparable
{
    private T[,] matrix;
    public readonly int cols;
    public readonly int rows;
    public T this[int index1,int index2]
    {
        get
        {
            return matrix[index1,index2];
        }
        set
        {
            matrix[index1,index2]=value;
        }
    }
    public Matrix(int cols, int rows)
    {
        this.cols = cols;
        this.rows = rows;
        matrix = new T[cols, rows];
    }
    //for an uknown reason it doesn't recognize the matrixTwo name in the + and - overrides
    public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
    {
        Matrix<T> resultMat = new Matrix<T>(martixTwo.cols, matrixTwo.rows);
        if ((matrixOne.cols == martixTwo.cols) && (martixTwo.rows == matrixOne.rows))
        {
            for (int i = 0; i < matrixTwo.cols; i++)
            {
                for (int j = 0; j < matrixTwo.rows; j++)
                {
                    dynamic value1 = matrixOne[i, j];
                    dynamic value2 = matrixTwo[i, j];
                    resultMat[i, j] = value1 - value2;
                }
            }
        }
        else
            throw new ArgumentException("Matrices not equal size");
        return resultMat;
    }
    public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> martixTwo)
    {
        Matrix<T> resultMat = new Matrix<T>(martixTwo.cols, matrixTwo.rows);
        if((matrixOne.cols==martixTwo.cols)&&(martixTwo.rows==matrixOne.rows))
        {
            for (int i = 0; i < matrixTwo.cols; i++)
			{
                for (int j = 0; j < matrixTwo.rows; j++)
			    {
                    dynamic value1 = matrixOne[i, j];
                    dynamic value2 = matrixTwo[i, j];
                    resultMat[i, j] = value1 + value2;
			    }
			}
        }
        else
            throw new ArgumentException("Matrices not equal size");
        return resultMat;
    }
    public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
    {
        Matrix<T> resultMat = new Matrix<T>(matrixOne.rows, matrixTwo.cols);
        for (int i = 0; i < resultMat.rows; i++)
        {
            for (int j = 0; j < resultMat.cols; j++)
            {
                for (int multiCol = 0; multiCol < matrixOne.cols; multiCol++)
                {
                    for (int k = 0; k < matrixOne.cols; k++)
                    {
                        dynamic tempValueOne = matrixOne[i, j];
                        dynamic tempValueTwo = matrixTwo[i, j];
                        resultMat[i, j] += tempValueOne * tempValueTwo;
                    }
                }
            }
        }

        return resultMat;
    }
    public static bool operator true(Matrix<T> firstMatrix)
    {
        for (int i = 0; i < firstMatrix.cols; i++)
        {
            for (int j = 0; j < firstMatrix.rows; j++)
            {
                dynamic value = firstMatrix[j, i];
                if ( value== 0) return false;
            }
        }
        return true;
    }
    public static bool operator false(Matrix<T> firstMatrix)
    {
        for (int i = 0; i < firstMatrix.cols; i++)
        {
            for (int j = 0; j < firstMatrix.rows; j++)
            {
                dynamic value = firstMatrix[j, i];
                if (value == 0) return false;
            }
        }
        return true;
    }
}

