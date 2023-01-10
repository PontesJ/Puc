# Programa 3
# Exemplos de uso das instruções de subtração
.text
.globl main
main:
	li $t1,10                  # instrução para carga (load) de registrador com valor imediato
	li $t2,20                  # instrução para carga (load) de registrador com valor imediato
	sub $t0,$t2,$t1       # subtrai $t2 de $t1 armazenando o resultado em $t0.
	sub $t0,$t1,$t2       # subtrai $t1 de $t2 armazenando o resultado em $t0
	subi $t0,$t1,10       # subtrai valor imediato de $t1, resultado em $t0 - pseudoinstrução
	subu $t0,$t1,$t2     # subtrai $t1 de $t2 armazenando o resultado em $t0.
	subu $t0,$t2,$t1     # subtrai $t1 de $t2 armazenando o resultado em $t0.
	addi $v0,$zero,10  # Encerra programa
	syscall