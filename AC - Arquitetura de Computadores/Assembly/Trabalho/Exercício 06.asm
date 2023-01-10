# Programa com a resposta do exercício 6, do segundo trabalho de arquitetura de computadores
# Autores: Gabriella Dantas de Abreu Fandim, João Gustavo Medeiros Pontes, Nicolas Matheus Ferreira, Pedro Siqueira Pereira Bitarães
# Data: 13/12/2022
# Ver 1.4

.data
	lerStg: .space 50
	nome: .asciiz "Digite o nome de um integrante: "
	matricula: .asciiz "Digite a matricula: "
	eh: .asciiz "Possui como número de matricula: "
	integrante: .asciiz "O integrante: "
	espaco: .asciiz "\n"
	formula: .asciiz "De acordo com a fórmula: -9ax³ - 6bx² - 7cz² + 5dz"
	variavela: .asciiz "Digite um valor para a variável 'a': "
	variavelb: .asciiz "Digite um valor para a variável 'b': "
	variavelc: .asciiz "Digite um valor para a variável 'c': "
	variaveld: .asciiz "Digite um valor para a variável 'd': "
	variavelx: .asciiz "Digite um valor para a variável 'x': "
	variavely: .asciiz "Digite um valor para a variável 'y': "
	variavelz: .asciiz "Digite um valor para a variável 'z': "
	resultado: .asciiz "O resultado dessa operação é: "
.text
	.main:
		li $t2, 3 # $t2 = 3
		move $t1, $zero # $t1 = 0
		while:
			bgt $t1, $t2, saida # if ($1 > $t2) Vai pra "saida"
			
			# Imprimi mensagem "Digite o nome de um integrante: "
			la $a0, nome # $a0 = nome
			jal imprimirString # Chama a função "imprimirString"
		
			# Lê o nome digitado pelo usuário
			jal lerString # Chama a função "lerString"
			move $t0, $a0 # $t0 = $a0
			
			# Imprimi a mensagem "Digite a matricula: "
			la $a0, matricula # $a0 = matricula
			jal imprimirString # Chama a função "imprimirString"
			
			# Lê o número digitado
			jal lerInt # Chama a função "lerInt"
			move $t3, $v0 # $t3 = $v0
			
			# Imprimi a mensagem "O integrante: "
			la $a0, integrante # $a0 = integrante
			jal imprimirString # Chama a função "imprimirString"
			
			# Imprimi o nome do integrante
			move $a0, $t0 # $a0 = $t0
			jal imprimirString # Chama a função "imprimirString"
			
			# Imprimi a mensagem "Possui como número de matricula: "
			la $a0, eh # $a0 = eh
			jal imprimirString # Chama a função "imprimirString"
			
			#Imprimi a matricula
			move $a0, $t3 # $a0 = $t3
			jal imprimirInt # Chama a função "imprimirInt"
			
			addi $t1, $t1, 1 # $t1++
			
			jal branco # Chama a função "branco"
			
			j while # Vai para "while"
			
		saida: 
			la $a0, formula # $a0 = formula
			jal imprimirString # Chama a função "imprimirString"
			
			jal branco # Chama a função "branco"
			
			la $a0, variavela # $a0 = variavela
			jal imprimirString # Chama a função "imprimirString"
			
			jal lerInt # Chama a função "lerInt"
			move $t0, $v0 # $t0 = a
			
			la $a0, variavelb # $a0 = variavelb
			jal imprimirString # Chama a função "imprimirString"
			
			jal lerInt # Chama a função "lerInt"
			move $t1, $v0 # $t1 = b
			
			la $a0, variavelc # $a0 = variavelc
			jal imprimirString # Chama a função "imprimirString"
			
			jal lerInt # Chama a função "lerInt"
			move $t2, $v0 # $t2 = c
			
			la $a0, variaveld # $a0 = variaveld
			jal imprimirString # Chama a função "imprimirString"
			
			jal lerInt # Chama a função "lerInt"
			move $t3, $v0 # $t3 = d
			
			la $a0, variavelx # $a0 = variavelx
			jal imprimirString # Chama a função "imprimirString"
			
			jal lerInt # Chama a função "lerInt"
			move $t4, $v0 # $t4 = x
			
			la $a0, variavely # $a0 = variavely
			jal imprimirString # Chama a função "imprimirString"
			
			jal lerInt # Chama a função "lerInt"
			move $t5, $v0 # $t5 = y
			
			la $a0, variavelz # $a0 = variavelz
			jal imprimirString # Chama a função "imprimirString"
			
			jal lerInt # Chama a função "lerInt"
			move $t6, $v0 # $t6 = z
			
			# -9ax³
			li $t7, -9 # $t7 = -9
			mul $t0, $t0, $t7 # $t0 = a * -9
			
			move $t7, $t4 # $t7 = x
			mul $t7, $t7, $t4 # $t7 = x²
			mul $t7, $t7, $t4 # $t7 = x³
			
			mul $t0, $t0, $t7 # $t0 = -9ax³
			
			# 6bx²
			li $t7, 6 # $t7 = 6
			mul $t1, $t1, $t7 # $t1 = b * 6
			
			move $t7, $t4 # $t7 = x
			mul $t7, $t7, $t4 # $t7 = x²
			
			mul $t1, $t1, $t7 # $t1 = 6bx²
			
			# 7cy²
			li $t7, 7 # $t7 = 7
			mul $t2, $t2, $t7 # $t2 = c * 7
			
			move $t7, $t5 # $t7 = y
			mul $t7, $t7, $t5 # $t7 = y²
			
			mul $t2, $t2, $t7 # $t2 = 7cy²
			
			# 5dz
			li $t7, 5 # $t7 = 5
			mul $t3, $t3, $t7 # $t3 = d * 5
			mul $t3, $t3, $t6 # $t3 = 5dz
			
			# -9ax³ - 6bx² - 7cz² + 5dz
			sub $t0, $t0, $t1 # $t0 = -9ax³ - 6bx²
			sub $t0, $t0, $t2 # $t0 = -9ax³ - 6bx² - 7cz²
			add $t0, $t0, $t3 # $t0 = -9ax³ - 6bx² - 7cz² + 5dz
			
			la $a0, resultado # a0 = resultado
			jal imprimirString # Chama a função "imprimirString"
			
			move $a0, $t0 # $a0 = $t0
			jal imprimirInt # Chama a função "imprimirInt"
			
			jal fim # Chama a função "fim"
			
# ==========================================================
# Funções - Exercício 05

	imprimirString: # 01 - Elaborar um subrotina para imprimir strings
		li $v0, 4 # Imprimir String
		syscall # Imprimir
		jr $ra # Return
		
	imprimirInt: # 02 - Elaborar um subrotina para imprimir números
		li $v0, 1 # Imprimir Int
		syscall # Imprimir
		jr $ra # Return
	
	lerString: # 03 - Elaborar um subrotina para ler strings
		li $v0, 8  # Lê String
		la $a0, lerStg # $a0 = lerStg / lerStg = valor digitado pelo usuário
		la $a1, 50 #a1 = 50 / Tamanho máximo do valor
		syscall # Lê
		jr $ra # Return
		
	lerInt: # 04 - Elaborar um subrotina para ler números inteiros
		li, $v0, 5 # Lê Inteiro
		syscall # Lê
		jr $ra # Return

# ==========================================================	
# Funções - Extras

	branco:
		li $v0, 4 # Imprimir String
		la $a0, espaco # $a0 = espaco
		syscall # Imprimir
		jr $ra # Return
		
	fim:
		li $v0, 10 # Encerrar Programa
		syscall # Encerra
