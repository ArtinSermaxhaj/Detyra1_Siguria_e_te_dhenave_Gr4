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
            string k = "Doruntina Hoti";
            Console.WriteLine(Dekripto(matrica, Enkripto(matrica,k)));
        }
        public static void MbusheMatricen(char[,] matrica){
            int majenmen = 97;
            for(var x=0; x<5;x++){
                for(var y=0; y<5; y++){
                    if(majenmen == 107){
                        majenmen++;
                        y--;
                        continue;
                    }
                    matrica[x,y] = (char)majenmen;
                    majenmen++;
                }
            }
        }
        public static string Enkripto(char[,] matrica, string text){
            text = text.ToLower();
            char[] tekstinchar = text.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach(var t in tekstinchar){
            for (var x = 0; x < 5; x++)
            {
                for( var y=0; y<5;y++){
                        if(t == matrica[x,y]){
                            for(var i=0; i<= x; i++){
                                sb.Append(".");
                            }
                            sb.Append(" ");
                            for(var i=0; i<= y; i++){
                            sb.Append(".");
                            }
                            sb.Append("  ");
                        }
                        else if(t == 'k'){
                            char l = 'c';
                            if(l == matrica[x,y]){
                            for(var i=0; i <= 0;i++){
                                sb.Append(".");
                            }
                            sb.Append(" ");
                            for(var i=0; i<= 2; i++){
                                sb.Append(".");
                            }
                            sb.Append("  ");
                            }
                        }
                    }
                }
            }
            return sb.ToString();
        }
        public static string Dekripto(char[,] matrica, string stringienkriptuar){
            string[] stringujone = stringienkriptuar.Split("  ");
            string[,] test = new string[stringujone.Length-1,2];
            StringBuilder testieren = new StringBuilder();
            var i =0;
            var j = 0;
            for(var t=0; t< stringujone.Length-1; t++){
                string[] k = stringujone[t].Split(" ");
                test[i,j]= k[0];
                test[i,j+1] = k[1];
                i++;
            }
            for(var kushti=0; kushti < test.GetLength(0); kushti++){
                    int x =0;
                    int y =0;
                    foreach(char c in test[kushti,0]){
                        if( c == '.'){
                            x += 1;
                        }
                    }
                    x -= 1;
                    foreach(char c in test[kushti,1]){
                        y += 1;
                    }
                    y -= 1;
                    char k = matrica[x,y];
                    testieren.Append(k);
            }
            return testieren.ToString();
        }
    }
}

