using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano, dias;
            Console.WriteLine("\nExercício 03 - Calendário Juliano");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Digite o dia:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano:");
            ano = int.Parse(Console.ReadLine());
            if (mes == 1) {
                Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dia);
            } else {
                if (mes == 2) {
                    dias = dia + 31;
                    Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                } else {
                    if (mes == 3) {
                        dias = dia + 31 + 28;
                        Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                    } else {
                        if (mes == 4) {
                            dias = dia + 31 + 28 + 31;
                            Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                        } else {
                            if (mes == 5) {
                                dias = dia + 31 + 28 + 31 + 30;
                                Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                            } else {
                                if (mes == 6) {
                                    dias = dia + 31 + 28 + 31 + 30 + 31;
                                    Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                                } else {
                                    if (mes == 7) {
                                        dias = dia + 31 + 28 + 31 + 30 + 31 + 30;
                                        Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                                    } else {
                                        if (mes == 8) {
                                            dias = dia + 31 + 28 + 31 + 30 + 31 + 30 + 31;
                                            Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                                        } else {
                                            if (mes == 9) {
                                                dias = dia + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                                                Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                                            } else {
                                                if (mes == 10) {
                                                    dias = dia + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                                                    Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                                                } else {
                                                    if (mes == 11 ) {
                                                        dias = dia + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                                                        Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                                                    } else {
                                                        if (mes == 12) {
                                                            dias = dia + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                                                            Console.WriteLine("O dia {0} do mês {1} do ano de {2} é o dia {3} do ano {2} no calendário Juliano", dia, mes, ano, dias);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
