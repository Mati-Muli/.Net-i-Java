using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Macierze
{
    internal class Matrix
    {
        public double[,] Generate(int size)
        {
            Random random = new Random();
            double[,] matrix = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.NextDouble() * 100;
                }
            }
            return matrix;
        }
        private long Measure(double[,] A, double[,] B, int threads, int reps)
        {
            int size = A.GetLength(0);
            double[,] doubles = new double[size, size];
            ParallelOptions options = new ParallelOptions { MaxDegreeOfParallelism = threads };
            Stopwatch watch = new Stopwatch();
            double time = 0;

            for (int i = 0; i < reps; i++)
            {
                watch.Restart();
                Parallel.For(0, size, options, i =>
                {
                    for (int j = 0; j < size; j++)
                    {
                        double sum = 0;
                        for (int k = 0; k < size; k++)
                        {
                            sum += A[i, k] * B[k, j];
                        }
                        doubles[i, j] = sum;
                    }
                });
                watch.Stop();
                double nanoseconds = (double)watch.ElapsedTicks * 1000 / Stopwatch.Frequency;
                time += nanoseconds;
            }
            return (long)(time / reps);
        }
        public (long seq, long par) Multiply(int size, int threads)
        {
            var A = Generate(size);
            var B = Generate(size);
            int reps = 10;
            long seqTime = Measure(A, B, 1, 10);
            long parTime = Measure(A, B, threads, 10);
            return (seqTime, parTime);
        }
        public (long seq, long par) MultiplyThreads(int size, int threads)
        {
            var A = Generate(size);
            var B = Generate(size);
            int reps = 10;
            long seqTime = MeasureThreads(A, B, 1, 10);
            long parTime = MeasureThreads(A, B, threads, 10);
            return (seqTime, parTime);
        }
        private long MeasureThreads(double[,] A, double[,] B, int threads, int reps)
        {
            int size = A.GetLength(0);
            double[,] doubles = new double[size, size];
            Stopwatch watch = new Stopwatch();
            double time = 0;

            for (int i = 0; i < reps; i++)
            {
                Thread[] Threads = new Thread[threads];
                int rowsPerThread = size / threads;
                watch.Restart();
                for (int t = 0; t < threads; t++)
                {
                    int threadIdx = t;
                    int startRow = threadIdx * rowsPerThread;
                    int endRow = (threadIdx == threads - 1) ? size : (threadIdx + 1) * rowsPerThread;
                    Threads[t] = new Thread(() =>
                    {
                        for (int i = startRow; i < endRow; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                double sum = 0;
                                for (int k = 0; k < size; k++)
                                {
                                    sum += A[i, k] * B[k, j];
                                }
                                doubles[i, j] = sum;
                            }
                        }
                    });
                    Threads[t].Start();
                }
                foreach (Thread x in Threads)
                {
                    x.Join();
                }
                watch.Stop();

                time += (double)watch.ElapsedTicks * 1000 / Stopwatch.Frequency;
            }
            return (long)time/reps;
        }
    }
        }
