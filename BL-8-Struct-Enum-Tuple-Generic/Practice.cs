﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Practice
    {
        public static Random random = new Random();


        /// <summary>
        /// BL8-P1/3. Cоздать структуру 2DRectangle, которая будет содержать ширину, высоту и координату.
        /// </summary>
        public struct Rectangle2D
        {
            private int Width, Height, XCoord, YCoord;
        }


        /// <summary>
        /// BL8-P2/3. Cоздать случайный массив квадратов с количеством элементов 100. 
        /// Используйте класс Random(10), чтоб установить значения сторон. 
        /// </summary>
        public static void Lb8_P2_3()
        {
            Square[] ArrayOfSquare = new Square[100];
            for (int i = 0; i < ArrayOfSquare.Length; i++)
            {
                ArrayOfSquare[i].Side = random.Next(10);
            }
            int Count = ArrayOfSquare.Length - ArrayOfSquare.Distinct().ToArray().Length;
        }

        public struct Square
        {
            public int Side;
        }

        /// <summary>
        /// BL8-P3/3.Anonymous. Создать метод GetSongData, 
        /// который принимает обьекта типа Song и возвращает анонимный тип, 
        /// который содержит Title, Minutes, Seconds и AlbumYear. 
        /// </summary>
        public static void Lb8_P3_3_Anonymous()
        {
        }
    }
}