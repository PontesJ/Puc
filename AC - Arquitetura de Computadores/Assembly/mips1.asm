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
prompt2: .asciiz "Valor digitado:“

# ############ Rotina que imprime mensagem para usuário #################
# $a0 contém endereço da memória no qual a constante tipo string foi armazenada
.text
PrintString: addi $v0, $zero, 4 # código 4 define operação de escrita de string pelo kernel
		syscall
		jr $ra

################## rotina para encerrar o programa. Sem retorno ##########
fim: ori $v0,$zero,10 # código 10 define operação de escrita de string pelo kernel
	syscall