# Programa 7 – Exemplo de uso das intruções LW e SW com uso de labels
# calcula o valor da equação do segundo grau: f(x)=ax^2 + bx + c
# valores de a, b, e c como constantes na memória
#valor de x lido da entrada de usuário (limite de 16bits)
#valor de f escrito na memória e impresso para usuário
#ahm - 28/11/22
.text
.globl main
main:
	# le valor da entrada de usuário. Valor de x retorna em $s0
	jal inputval
	# carregando coeficientes da memória
	lw $t0,a
	lw $t1,b
	lw $t2,c
	#x^2
	mult $s0,$s0
	mflo $s1
	#ax^2
	mult $s1,$t0
	mflo $s1
	#bx
	mult $t1,$s0
	mflo $s2
	#ax^2+bx
	add $s1,$s1,$s2
	#ax^2+bx+c
	add $s1,$s1,$t2
	sw $s1,f
	# imprime resultado do cálculo, a partir de dado armazenado em memória
	jal outputval
	j fim
.data
###### constantes correspondentes aos coeficientes da equação
a: .word 5
b: .word 10
c: .word -4
# valor da função calculada
f: .word
.text
############ rotina para entrada de dados do usuário ##########
inputval:
	la $a0,input
	ori $v0,$zero,4 # imprime string no console
	syscall
	ori $v0,$zero,5 # lê valor inteiro do console
	syscall
	move $s0,$v0 # salva valor de retorno
	jr $ra
##########################################################
.text
.data
input: .asciiz "Entre com o valor de x:"

# ######### rotina para imprimir valor na interface de usuário #######
outputval:
	la $a0,output
	ori $v0,$zero,4 # imprime string no console
	syscall
	lw $a0,f
	ori $v0,$zero,1 # imprime valor inteiro no console
	syscall
	jr $ra # retono da função
##############################################################
.data
output: .asciiz "Valor de f(x)=ax^2+bx+c:"
.text
####### Rotina para encerrar programa. Sem retorno.
	fim: ori $v0,$0,10
	syscall