using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _bol = true;
            string _Result = string.Empty;
            
            while(_bol)
            {
                try
                {
                    string _Gender,_cm,_kg;
                    Console.WriteLine("請選擇性別(輸入數字: 1:男生 2:女生");
                    _Gender = Console.ReadLine();
                    //bmi.Gender = int.Parse(_Gender);
                    Console.WriteLine("請選擇身高(公分)");
                    _cm = Console.ReadLine();
                    //bmi.Cm = decimal.Parse(_cm);
                    Console.WriteLine("請選擇體重(公斤)");
                    _kg = Console.ReadLine();
                    //bmi.Kg = decimal.Parse(_kg);
                    BMICenter bmi = new BMICenter(int.Parse(_Gender), decimal.Parse(_cm), decimal.Parse(_kg));
                    _Result =BMICenter.BMItest().ToString();

                    switch (_Result)
                    {
                        case "1":
                            {
                                Console.WriteLine("太胖");
                                break;
                            }
                        case "0":
                            {
                                Console.WriteLine("適中");
                                break;
                            }
                        case "-1":
                            {
                                Console.WriteLine("太瘦");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("資料錯誤，無法分析");
                                break;
                            }
                    }

                    Console.WriteLine("繼續請按1");
                    if(Console.ReadLine()!="1")
                    {
                        _bol = false;
                    }
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine("資料錯誤，重新再來");
                    _bol = true;
                }
                

            }
            
            
            
        }

       


    }
}
