# Programa correspondente ao 5° exercício (com as respostas dos exercícios de 1 a 4), do segundo trabalho de arquitetura de computadores
# Autores: Gabriella Dantas de Abreu Fandim, João Gustavo Medeiros Pontes, Nicolas Matheus Ferreira, Pedro Siqueira Pereira Bitarães
# Data: 13/12/2022
# Ver 1.3

.data
	lerStg: .space 50
.text
	.main:
		
	imprimirString: # 01 - Elaborar um subrotina para imprimir strings
		li $v0, 4 # Imprimir String
		syscall # Imprimir
		jr $ra # Return
		
	imprimirInt: # 02 - Elaborar um subrotina para imprimir números
		li $v0, 1 # Imprimir Int
		syscall # Imprimi
		jr $ra # Return
	
	lerString: # 03 - Elaborar um subrotina para ler strings
		li $v0, 8 # Lê String
		la $a0, lerStg # $a0 = lerStg / lerStg = valor digitado pelo usuário
		la $a1, 50 #a1 = 50 / Tamanho máximo do valor
		syscall # Lê String
		jr $ra # Return
		
	lerInt: # 04 - Elaborar um subrotina para ler números inteiros
		li, $v0, 5 # Lê Inteiro
		syscall # Lê
		jr $ra # Return
