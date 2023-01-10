# Programa Hello World
# Demonstra o uso de instruções simples e o uso do simulador MARS
# Autor: Antônio Hamilton
# Data: 19/11/2022
# Ver 1.0 – Versão inicial
.text
main:
	la $a0, Greetings # um label na área de dados (endereço)
	la $v0, 4 # opção para imprimir uma string na chamada de sistema
	syscall
	la $v0, 10 # encerra programa
	syscall
.data
Greetings: .asciiz "Hello World"
