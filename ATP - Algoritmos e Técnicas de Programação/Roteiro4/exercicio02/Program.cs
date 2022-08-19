using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            Console.WriteLine("\nExercício 02 - Hora Canônica");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Digite a hora atual:");
            hora = int.Parse(Console.ReadLine());
            if (hora == 3) {
                Console.WriteLine("A hora {0} corresponde a Matinas", hora);
            } else {
                if (hora == 5) {
                    Console.WriteLine("A hora {0} corresponde a Laudes", hora);
                } else {
                    if (hora == 7) {
                        Console.WriteLine("A hora {0} corresponde a Prima", hora);
                    } else {
                        if (hora == 9) {
                            Console.WriteLine("A hora {0} corresponde a Tercia", hora);
                        } else {
                            if (hora == 12) {
                                Console.WriteLine("A hora {0} corresponde a Sexta", hora);
                            } else {
                                if (hora == 15) {
                                    Console.WriteLine("A hora {0} corresponde a Noa", hora);
                                } else {
                                    if (hora == 18) {
                                        Console.WriteLine("A hora {0} corresponde a Vésperas", hora);
                                    } else {
                                        if (hora == 21) {
                                            Console.WriteLine("A hora {0} corresponde a Completas", hora);
                                        } else {
                                            Console.WriteLine("Não é uma hora canônica");
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
