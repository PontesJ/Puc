# Programa Hello World
# Demonstra o uso de instru��es simples e o uso do simulador MARS
# Autor: Ant�nio Hamilton
# Data: 19/11/2022
# Ver 1.0 � Vers�o inicial
.text
main:
	la $a0, Greetings # um label na �rea de dados (endere�o)
	la $v0, 4 # op��o para imprimir uma string na chamada de sistema
	syscall
	la $v0, 10 # encerra programa
	syscall
.data
Greetings: .asciiz "Hello World"
