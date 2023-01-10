# Programa 6
# Demonstra��o subrotina, entrada e sa�da de inteiros
#ahm
.text
main: la $a0,prompt1 # prompt 1 cont�m o endere�o da rotina para imprimir strings - PrintString
	# imprime string
	jal PrintString # chama rotina para imprimir mensagem ao usu�rio
	# l� valor digitado
	ori $v0,$zero,5 # c�digo 5 define opera��o de leitura de valor inteiro pelo kernel
	syscall
	#salva valor digitado
	add $t0,$zero,$v0 # $v0 contem o valor digitado pelo usu�rio, salvo em $t0
	la $a0,prompt2
	# imprime string # chama rotina para imprimir mensagem ao usu�rio
	jal PrintString
	# imprime valor digitado
	move $a0,$t0 # $a0 cont�m o valor a ser impresso pela rotina
	ori $v0,$zero,1 # c�digo 5 define opera��o de escrita de valor inteiro pelo kernel
	syscall
	# finaliza o programa
	j fim # salto incondicional sem retorno

.data
prompt1: .asciiz "Entre valor:�
prompt2: .asciiz "Valor digitado:�

# ############ Rotina que imprime mensagem para usu�rio #################
# $a0 cont�m endere�o da mem�ria no qual a constante tipo string foi armazenada
.text
PrintString: addi $v0, $zero, 4 # c�digo 4 define opera��o de escrita de string pelo kernel
		syscall
		jr $ra

################## rotina para encerrar o programa. Sem retorno ##########
fim: ori $v0,$zero,10 # c�digo 10 define opera��o de escrita de string pelo kernel
	syscall