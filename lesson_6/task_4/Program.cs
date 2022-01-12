// **Считайте файл различными способами. Смотрите “Пример записи файла различными способами”. 
// Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.

using System;
using System.IO;
using System.Diagnostics;
class Program
    {
        static void Main(string[] args)
        {
            long kbyte = 1024;
            long mbyte = 1024 * kbyte;
            long gbyte = 1024 * mbyte;
            long size = mbyte;
            //Write FileStream
            //Write BinaryStream
            //Write StreamReader/StreamWriter
            //Write BufferedStream

            Console.WriteLine("Запишем файлы различными способами:");
            Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSample("D:\\temp\\bigdata0.bin",size));
            Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSample("D:\\temp\\bigdata1.bin", size));
            Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSample("D:\\temp\\bigdata2.bin", size));
            Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSample("D:\\temp\\bigdata3.bin", size));

            Console.WriteLine("Прочтём файлы различными способами:");
            byte[] bytesFromFileStream = FileStreamSampleRead("D:\\temp\\bigdata0.bin");
            byte[] bytesFromBufferedStream = BufferedStreamSampleRead("D:\\temp\\bigdata3.bin");
            string stringFromSreamReader = StreamReaderSample("D:\\temp\\bigdata2.bin");
            int[] integersFromBinatyStream = BinaryStreamSampleRead("D:\\temp\\bigdata1.bin");
        }

        static long FileStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                fs.WriteByte(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long BinaryStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write((byte)0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long StreamWriterSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write(1);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long BufferedStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs,bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i=0;i<countPart;i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        //Чтение при помощи FileStream
        static byte[] FileStreamSampleRead(string filename)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] byteArray = new byte[fs.Length];
            for(int i = 0; i < fs.Length; i++)
                byteArray[i] = (byte)fs.ReadByte();
            fs.Close();
            stopwatch.Stop();
            Console.WriteLine("FileStream. Milliseconds: " + stopwatch.ElapsedMilliseconds);
            return byteArray;
        }

        //Чтение при помощи BufferedStream
        static byte[] BufferedStreamSampleRead(string filename)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int countPart = 4;//количество частей
            int bufsize = (int)(fs.Length / countPart);
            byte[] buffer = new byte[fs.Length];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Read(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            Console.WriteLine("BufferedStream. Milliseconds: " + stopwatch.ElapsedMilliseconds);
            return buffer;
        }

        //Чтение при помощи StreamReader
        static string StreamReaderSample(string filename)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string result = sr.ReadToEnd();
            fs.Close();
            stopwatch.Stop();
            Console.WriteLine("StreamReader. Milliseconds: " + stopwatch.ElapsedMilliseconds);
            return result;
        }

        //Чтение при помощи BinaryReader
        static int[] BinaryStreamSampleRead(string filename)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int[] intArr = new int[fs.Length / 4];
            BinaryReader br = new BinaryReader(fs);
            for (int i = 0; i < fs.Length / 4; i++)
                intArr[i] = br.ReadInt32();
            fs.Close();
            stopwatch.Stop();
            Console.WriteLine("BinaryReader. Milliseconds: " + stopwatch.ElapsedMilliseconds);
            return intArr;
        }

    }