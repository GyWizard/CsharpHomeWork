using System;
using System.IO;

namespace HomeWork4
{
    class DoubleArray
    {
        int[,] arr;
        int width;
        int height;

        public DoubleArray(int width,int height)
        {
            arr = new int[height,width];
            this.width = width;
            this.height = height;
            var rand = new Random();
            for (int i=0;i<height;i++)
            {
                for(int j=0;j<width;j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }
        }

        public DoubleArray(string path)
        {
            Load(path);    
        }
        public void Load(string path) //Загружаем матрицу из файла
        {
            try
            {
                string[] temp = File.ReadAllLines(path); //  Читаем файл
                if (temp.Length > 0)
                {
                    this.height = temp.Length;    // Сохраняем строки 
                    this.width = temp[0].Split(' ').Length;  // Делим строку по пробелам
                    arr = new int[height, width];
                    for (int i = 0; i < height; i++)
                    {
                        string[] temp_line = temp[i].Split(' ');
                        for (int j = 0; j < width; j++)
                        {
                            int.TryParse(temp_line[j], out arr[i, j]);
                        }
                    }
                }
            }
            catch(System.IO.FileNotFoundException)
            {
                Console.WriteLine("Не найден указанный файл");
            }
            catch (System.UnauthorizedAccessException)
            {
                Console.WriteLine("Нет доступа к файлу или указан каталог");
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Не указан путь к файлу");
            }
            catch (System.NotSupportedException)
            {
                Console.WriteLine("Неправильный формат пути");
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine("Нет разрешения на доступ к файлу");
            }
            catch
            {
                Console.WriteLine("Ошибка при записи из файла");
            }


        }
        public void Save(string path) // Сохраняем матрицу в файл
        {

            string[] temp = new string[height]; // Массив строк

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    temp[i] += $"{arr[i, j]} "; //  Заполняем строку через пробел
                }
                temp[i]=temp[i].Trim();
            }

            try 
            {
            File.WriteAllLines(path, temp);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Не найден указанный файл");
            }
            catch (System.UnauthorizedAccessException)
            {
                Console.WriteLine("Нет доступа к файлу или указан каталог");
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Не указан путь к файлу");
            }
            catch (System.NotSupportedException)
            {
                Console.WriteLine("Неправильный формат пути");
            }
            catch (System.Security.SecurityException)
            {
                Console.WriteLine("Нет разрешения на доступ к файлу");
            }
            catch
            {
                Console.WriteLine("Ошибка при записи в файл");
            }

        } 

        public void Print()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        } // Отображаем матрицу по строкам и столбцам
        public int Sum()
        {
            int s = 0;
            foreach(int a in arr)
            {
                s+=a;
            }
            return s;
        } 
        public int SumOver(int over_value)
        {
            int s = 0;
            foreach (int a in arr)
            {
                if(a>over_value)
                {
                    s += a;
                }
                
            }
            return s;
        }

        public int Min
        {
            get
            {
                int m=arr[0,0];
                foreach (int a in arr)
                {
                    if (a < m)
                    {
                        m=a;
                    }
                }
                return m;
            }
        }

        public int Max
        {
            get
            {
                int m = arr[0, 0];
                foreach (int a in arr)
                {
                    if (a > m)
                    {
                        m = a;
                    }
                }
                return m;
            }
        }

        public void MaxIndex(out int w,out int h) //Ищем номер максимального элемента
        {
            w = 0;
            h = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(arr[i,j]==this.Max)  //Перебираем элементы и возвращаем номер строки и столбца
                    {
                        w = j;
                        h = i;
                        return;
                    }
                }
            }
        }





    }
}
