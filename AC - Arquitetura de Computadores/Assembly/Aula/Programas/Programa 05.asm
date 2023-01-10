#programa 5
#operações lógicas, deslocamento e rotação
.text
.globl main
main:
	ori $s0,$zero,0x0001 # atribui valor inicial ao registrador $s0
	ori $s0,$s0,0x0010 # seta 5o bit do registrador $s0
	ori $s1,0xaa55 # seta bits 0,2,4,6,9,11,13 e 15 do registrador $s1
	or $s1,$s1,0x55aa # seta bits 1,3,5,7,8,10,12 e 14 do registrador $s1
	and $s1,$s1,0x00FF # zera bits 8 a 15 de $s1 e mantém os demais como estão
	andi $s1,$s1,0x0001 # zera todos os bits $s1, exceto o bit 0
	sll $s1,$s1,4 # desloca valor em $s1 de 4 bits à esquerda : multiplica por 16
	ori $t0,4 # carrega 4 em $t0
	sllv $s1,$s1,$t0 # desloca valor em $s1 de 4 bits à esquerda : multiplica por 16
	srlv $s1,$s1,$t0 # desloca valor em $s1 de 4 bits à direita : divide por 16
	rol $s1,$s1,$t0 #rotaciona $s1 de 4bits à esquerda
	ror $s1,$s1,$t0 #rotaciona $s1 de 4bits à direita
	ori $v0,$zero,10 # Encerra
	syscall # Programa