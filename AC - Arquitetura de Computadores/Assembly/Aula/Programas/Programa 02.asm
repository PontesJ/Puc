# Programa 2
# Exemplos de uso das instruções de adição
.text
.globl main
main:
	li $t1,10 # instrução para carga (load) de registrador com valor imediato
	li $t2,20 # instrução para carga (load) de registrador com valor imediato
	add $t0,$t1,$t2 # soma $t1 com $t2 armazenando o resultado em $t0
	addi $t0,$t1,100 # soma valor imediato a $t1 armazenando o resultado em $t0
	addu $t0,$t1,$t2 # soma unsigned de $t1 com $t2 armazenando o resultado em $t0
	addiu $t0,$t1,0x01 # soma unsigned de valor imediato $t1, resultado em $t0
	add $t0,$t1,0x01 # soma valor imediato de 16 bits com $t1, resultado em $t0
	add $t0,$t1,100000 # soma valor imediato de 32 bits com $t1, resultado em $t0
	addi $v0,$zero,10 # Valor 10 é somado a $zero ecarregado em $v0
	# comando de termino do programa na chamada syscall
	syscall