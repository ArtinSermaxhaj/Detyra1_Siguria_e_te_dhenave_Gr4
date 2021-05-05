using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Collections;
 
namespace Tap_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrica = new char[5,5];
            MbusheMatricen(matrica);
            Console.Write("Shtypni stringun qe doni ta beni me tap code: ");
            string inputiuserit= Console.ReadLine();
            Console.WriteLine("Stringu i enkoduar: " + Enkodo(matrica,inputiuserit));
            Console.WriteLine("Stringu i dekoduar: " + Dekodo(matrica, Enkodo(matrica,inputiuserit)));
        }
        public static void MbusheMatricen(char[,] matrica){
            int ascii = 97;
            for(var x=0; x<5;x++){
                for(var y=0; y<5; y++){
                    if(ascii == 107){
                        ascii++;
                        y--;
                        continue;
                    }
                    matrica[x,y] = (char)ascii;
                    ascii++;
                }
            }
        }
        public static string Enkodo(char[,] matrica, string text){
            text = text.ToLower();
            char[] tekstinchar = text.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach(var t in tekstinchar){
                if( Char.IsLower(t)){
            for (var x = 0; x < 5; x++)
            {
                bool found = false;
                for( var y=0; y<5;y++){
                        if(t == matrica[x,y]){
                            found = true;
                            for(var i=0; i<= x; i++){
                                sb.Append(".");
                            }
                            sb.Append(" ");
                            for(var i=0; i<= y; i++){
                            sb.Append(".");
                            }
                            sb.Append("  ");
                            break;
                        }
                        else if(t == 'k'){
                            found = true;
                            char l = 'c';
                            if(l == matrica[x,y]){
                            for(var i=0; i <= x;i++){
                                sb.Append(".");
                            }
                            sb.Append(" ");
                            for(var i=0; i<= y; i++){
                                sb.Append(".");
                            }
                            sb.Append("  ");
                            break;
                            }
                        }
                    } if(found)
                        break;
                }
                }
            }
            return sb.ToString();
        }
        public static string Dekodo(char[,] matrica, string stringienkriptuar){
            string[] stringuShkronjat = stringienkriptuar.Split("  ");
            string[,] karakteret = new string[stringuShkronjat.Length-1,2];
            StringBuilder sb = new StringBuilder();
            var i =0;
            var j = 0;
            for(var t=0; t< stringuShkronjat.Length-1; t++){
                string[] k = stringuShkronjat[t].Split(" ");
                karakteret[i,j]= k[0];
                karakteret[i,j+1] = k[1];
                i++;
            }
            for(var kushti=0; kushti < karakteret.GetLength(0); kushti++){
                    int x =0;
                    int y =0;
                    foreach(char c in karakteret[kushti,0]){
                        if( c == '.'){
                            x += 1;
                        }
                    }
                    x -= 1;
                    foreach(char c in karakteret[kushti,1]){
                        y += 1;
                    }
                    y -= 1;
                    char k = matrica[x,y];
                    sb.Append(k);
            }
            return sb.ToString();
        }
    }
}