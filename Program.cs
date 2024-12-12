using System;
using System.Drawing;

namespace Route_Session_01

{ 
    //  .1 class
    //  .2 Struct
    //  .3 Enum
    //  .4 interface

    class Program
    {
       static void Main()
        {
            #region Type Error

            #region Syntax Error
            Console.WriteLine("Hello Route");
            #endregion

            #region Logicl Error
            int x = 5;
            int y = 0;
            Console.WriteLine(x / y);
            #endregion


            #region Run Time Error
            int z = 5;
            int a = 1;
            Console.WriteLine(a / z);
            #endregion

            #region Warning Error
            int z;
            #endregion

            #endregion

            #region Variavle Declartion
            int Num1 = 4;
                Num1 = 5; // Valid
            Num1 = 'Ahmed' Invalid

            Console.WriteLine( Num1);
            #endregion

            #region CTS & CLS

            /*
           common Type System CTS
           Datatypes in .Net  Divided into 2 Categories

           01 Value Type (Primitve 
           02 Reference Type (Non Ptimitve)
             
           */
            #endregion

            #region Data Types

            string Name = "Ahmed"; // 10Byt
            Console.WriteLine(Name);

            // 
            #endregion

            #region Value Type
            int Num01;
            // int : C# keyword
            // Allocate 4 Uninialized Byte stack
            Num01 = 5;
           Int32  Num02 = 50;
           
            Console.WriteLine(Num01); // 5 
            Console.WriteLine(Num02); // 50

            Num01 = Num02;
            Console.WriteLine(Num01); // 50
            Console.WriteLine(Num02); // 50

            Num01++;
               Console.WriteLine(Num01); // 6

            Num02++;
           Console.WriteLine(Num02); // invalid This Reference

            #endregion

            #region Reference Type

            Point P1;

            // DeclarFor Reference Form Type Point , Refe Null
            // Allocate 4 bytes at satck For Reference 
            // Zero Bytes  allocate at Heap
            
            P1 = new Point(); // 45758

            Point P2;
            
            // 1. Allocate Required  Bytes at Heap
            // 2. Initialize (corss Out ) Allocate Bytes  Of Opcets
            // 3. Call User Defined Constructor If Exist 
            // 4. Asssign Reference (P1) To Allocated Objact
            
            P2 = new Point(); // 45758  // Unreachable object // this invalid 

            P2 = P1;


            P1.x = 10;
            P2.y = 20;
            // To Valid
            Console.WriteLine(P1.x);
            Console.WriteLine(P1.x);
            Console.WriteLine("=============================");
            Console.WriteLine(P2.y);
            Console.WriteLine(P2.y);


            #endregion

            #region Value Type VS Reference Type

            #region Value Type 
            int i;
            // Allocate 4 bytesin stack 
            // int : C# Keyword 
            i = 5;


            Int32 u;
            // Allocate 4 bytesin stack 
            // int32 : BCL .Net 
            u = 1;

            i = u; // = 5

            i++; // = 6
            u++; // = invalid

            Console.WriteLine("i =" + i); // 6
            Console.WriteLine("u =" + u); // 5
            #endregion

            #region Reference Type

            Point P1;

            // DeclarFor Reference Form Type Point , Refe Null
            // Allocate 4 bytes at satck For Reference 
            // Zero Bytes  allocate at Heap

            P1 = new Point(); // 45758

            Point P2;

            // 1. Allocate Required  Bytes at Heap
            // 2. Initialize (corss Out ) Allocate Bytes  Of Opcets
            // 3. Call User Defined Constructor If Exist 
            // 4. Asssign Reference (P1) To Allocated Objact

            P2 = new Point(); // 45758  // Unreachable object // this invalid 

            P2 = P1;


            P1.x = 10;
            P2.y = 20;
            // To Reference in Objact
            Console.WriteLine(P1.x); // 10
            Console.WriteLine(P1.x); // 10 
            #endregion

            #endregion

            #region Object

            object 01;  
            01 = new object();

            object 02 = new object();
            // Unrachable
            Console.WriteLine(01.GetHashCode()); // 25485225
            Console.WriteLine(02.GetHashCode()); // 88745787

            02 = 01;
            Console.WriteLine("==========================");
            Console.WriteLine(01.GetHashCode()); // 25485225
            Console.WriteLine(02.GetHashCode()); // 25485225

            {

            };

            #endregion

            #region Function

            double x = 2222222222222222.2222222222;
            float y = 2.2F;
            decimal z = 2.2m;

            // Tostring() بتحول الي 
            // GteHashCode() genritCode
            //Equal(object) Vs object
            //getType() value بترجع الداتا تيب بتاعت ال 


            #endregion





            // <======================> Assignmen C# 01 <======================> // 

            #region Assignment C# 01

            // Write A program that Allows the user to enter a number then print it
            #region Number 01

            Console.WriteLine("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("YOU entered:" + number);
            #endregion


            // write C3 program that Assigning one Value type
            // Varible to another and Modifying the value of one 
            // Varible and mention what will happen
            #region Number 02
            int num1 = 10;
            int num2 = num1;
            num2 = 20;
           Console.WriteLine("Vaule Of num1" + num1);
           Console.WriteLine("Vaule Of num2" + num2);

            #endregion


            // -write C# program that Assigning one value type
            // varible to another and modifying the object through
            // one varible and mention what will happ 
            #region Number 03
            int[] arr1 = { 2, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 99;

            Console.WriteLine("arr1 [0]:" + arr1[0]);
            Console.WriteLine("arr2 [0]:" + arr2[0]);



            #endregion


            #endregion

        }
    }
}