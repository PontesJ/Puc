# <a href="/Programas">Programas do Professor</a>

## <a href="/Programas/Programa 01.asm">Programa 01 - Hello World!</a>

Demonstra o uso de instruções simples e o uso do simulador MARS.

```
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
```

## <a href="/Programas/Programa 02.asm">Programa 02 - Instruções de Adição</a>

Exemplos de uso das instruções de adição.

```
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
```

## <a href="/Programas/Programa 03.asm">Programa 03 - Instruções de Subtração</a>

Exemplos de uso das instruções de subtração.

```
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
```

## <a href="/Programas/Programa 04.asm">Programa 04 - Instruções de Multiplicação e Divisão</a>

Exemplos de uso das instruções de multiplicação e divisão.

```
# Programa 4
# Exemplos de uso das instruções de multiplicação e divisão
.text
.globl main
main:
	li $t1,1000000 # instrução para carga (load) de registrador com valor imediato
	li $t2,1000000 # instrução para carga (load) de registrador com valor imediato
	mult $t1,$t2 # multiplica $t1 por $t2 armazenando o resultado em HI e LO.
	mfhi $s0 # move valor de hi para $s0
	mflo $s1 # move valor de lo para $s0
	mult $t1,$t2 # multiplica $t1 por $t2 armazenando o resultado em HI e LO.
	mulo $t0,$t1,0x02 # multiplica $t1 por $t2 armazenando o resultado em $t0. Detecta overflow e gera exceção
	div $t1,$t2 # divide $t1 de $t2 armazenando. Lo contém o quociente e hi contém o resto
	# verifica divisão por zero
	div $t0,$t1,$t2 # divide $t1 por $t2. verifica divisãopor zero
	div $t0,$t1,2 # divide $t1 por $t2. verifica divisãopor zero
	rem $t0,$t1,$t2 # resto da divisão inteira de $t1 de $t2 armazenando o resto em $t0.
	li $s1, 10
	rem $s0,$s1,4
	addi $v0,$zero,10 # Encerra programa
	syscall
```

## <a href="/Programas/Programa 05.asm">Programa 05 - Operações Lógicas, Deslocamento e Rotação</a>

Operações lógicas, deslocamento e rotação.

```
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
```

## <a href="/Programas/Programa 06.asm">Programa 06 - Demonstração Subrotina, Entrada e Saída de Inteiros</a>

Demonstração subrotina, entrada e saída de inteiros.

```
# Programa 6
# Demonstração subrotina, entrada e saída de inteiros
#ahm
.text
main: la $a0,prompt1 # prompt 1 contém o endereço da rotina para imprimir strings - PrintString
	# imprime string
	jal PrintString # chama rotina para imprimir mensagem ao usuário
	# lê valor digitado
	ori $v0,$zero,5 # código 5 define operação de leitura de valor inteiro pelo kernel
	syscall
	#salva valor digitado
	add $t0,$zero,$v0 # $v0 contem o valor digitado pelo usuário, salvo em $t0
	la $a0,prompt2
	# imprime string # chama rotina para imprimir mensagem ao usuário
	jal PrintString
	# imprime valor digitado
	move $a0,$t0 # $a0 contém o valor a ser impresso pela rotina
	ori $v0,$zero,1 # código 5 define operação de escrita de valor inteiro pelo kernel
	syscall
	# finaliza o programa
	j fim # salto incondicional sem retorno
.data
prompt1: .asciiz "Entre valor:“

# ############ Rotina que imprime mensagem para usuário #################
# $a0 contém endereço da memória no qual a constante tipo string foi armazenada
.text
PrintString: addi $v0, $zero, 4 # código 4 define operação de escrita de string pelo kernel
	syscall
	jr $ra
.data
prompt2: .asciiz "Valor digitado:“

################## rotina para encerrar o programa. Sem retorno ##########
.text
fim: ori $v0,$zero,10 # código 10 define operação de escrita de string pelo kernel
	syscall
```