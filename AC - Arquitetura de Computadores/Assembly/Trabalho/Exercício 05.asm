# Programa correspondente ao 5� exerc�cio (com as respostas dos exerc�cios de 1 a 4), do segundo trabalho de arquitetura de computadores
# Autores: Gabriella Dantas de Abreu Fandim, Jo�o Gustavo Medeiros Pontes, Nicolas Matheus Ferreira, Pedro Siqueira Pereira Bitar�es
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
		
	imprimirInt: # 02 - Elaborar um subrotina para imprimir n�meros
		li $v0, 1 # Imprimir Int
		syscall # Imprimi
		jr $ra # Return
	
	lerString: # 03 - Elaborar um subrotina para ler strings
		li $v0, 8 # L� String
		la $a0, lerStg # $a0 = lerStg / lerStg = valor digitado pelo usu�rio
		la $a1, 50 #a1 = 50 / Tamanho m�ximo do valor
		syscall # L� String
		jr $ra # Return
		
	lerInt: # 04 - Elaborar um subrotina para ler n�meros inteiros
		li, $v0, 5 # L� Inteiro
		syscall # L�
		jr $ra # Return
