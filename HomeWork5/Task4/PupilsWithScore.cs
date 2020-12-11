using System;
using System.Collections.Generic;

namespace Task4
{
    partial class Program
    {
        class PupilsWithScore // Класс описывающий 3 группы худших учеников
        {
            public struct PupilsScore // Структура, которая хранит оценку и имена учеников с такой оценкой
            {
                public List<string> names;
                public int score;
            }

            public PupilsScore[] pScores= new PupilsScore[3];
            public PupilsWithScore() // Инициализируем переменные. Оценку выставляем 16 как невозможный максимальный балл
            {
                for (int i = 0; i < 3; i++)
                {
                    pScores[i].score = 16;
                    pScores[i].names = new List<string>();
                }
            }
            public int FindEqualOrMaxIndex(int value) // Возвращаем индекс группы, на основе оценки. Если такая оценка есть возвращаем индекс группы с такой оценкой. Если нет, группу с максимальной оценкой
            {
                int index = 0;
                for (int i = 0; i < 3; i++)
                { 
                    if(pScores[i].score==value)
                    {
                        return i;
                    }
                    if(pScores[i].score>pScores[index].score)
                    {
                        index = i;
                    }
                }
                return index;
            }

            public void PrintPupils() //Показываем худших учеников
            {
                for (int i = 0; i < 3; i++)
                    if(pScores[i].score!=16)
                    {
                        foreach (string n in pScores[i].names)
                        {
                            Console.WriteLine($"{n} - средний балл ={(pScores[i].score / 3.0).ToString("#.#")}");
                        }
                    }
                   
                }
            }

        }




    }

