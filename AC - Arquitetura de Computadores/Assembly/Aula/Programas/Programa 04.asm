# Programa 4
# Exemplos de uso das instru��es de subtra��o
.text
.globl main
main:
	li $t1,1000000 # instru��o para carga (load) de registrador com valor imediato
	li $t2,1000000 # instru��o para carga (load) de registrador com valor imediato
	mult $t1,$t2 # multiplica $t1 por $t2 armazenando o resultado em HI e LO.
	mfhi $s0 # move valor de hi para $s0
	mflo $s1 # move valor de lo para $s0
	mult $t1,$t2 # multiplica $t1 por $t2 armazenando o resultado em HI e LO.
	mulo $t0,$t1,0x02 # multiplica $t1 por $t2 armazenando o resultado em $t0. Detecta overflow e gera exce��o
	div $t1,$t2 # divide $t1 de $t2 armazenando. Lo cont�m o quociente e hi cont�m o resto
	# verifica divis�o por zero
	div $t0,$t1,$t2 # divide $t1 por $t2. verifica divis�opor zero
	div $t0,$t1,2 # divide $t1 por $t2. verifica divis�opor zero
	rem $t0,$t1,$t2 # resto da divis�o inteira de $t1 de $t2 armazenando o resto em $t0.
	li $s1, 10
	rem $s0,$s1,4
	addi $v0,$zero,10 # Encerra programa
	syscall
