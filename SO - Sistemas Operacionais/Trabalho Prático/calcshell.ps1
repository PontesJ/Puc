[float]$num1 = [float]$args[0]
$operacao = $args[1]
[float]$num2 = [float]$args[2]
[float]$equa = 0

Write-Host ""
Write-Host "Exerc�cio 02" -ForegroundColor Cyan
Write-Host ""

Write-Host "Implementar uma calculadora das quatro opera��es aritm�ticas inteiras b�sicas (+, -, x e /). Os operandos e o operador s�o recebidos obrigatoriamente atrav�s par�metros na linha de comando.
Exemplo:
ENTRADA: ./calcshell.ps1 2 x 3 ou ./calcshell.sh 2 x 3
SA�DA: 2 x 3 = 6" -ForegroundColor Yellow
Write-Host ""
Write-Host "Integrantes: Gabriella Dantas de Abreu Fandim, Jo�o Gustavo Medeiros Pontes" -ForegroundColor Magenta
Write-Host ""

if ($operacao -eq '+')
{
    $equa = $num1 + $num2
    Write-Host "$num1 $operacao $num2 = $equa" -ForegroundColor Green
}
else 
{
    if ($operacao -eq '-')
    {
        $equa = $num1 - $num2
        Write-Host "$num1 $operacao $num2 = $equa" -ForegroundColor Green
    }
    else
    {
        if ($operacao -eq 'x')
        {
            $equa = $num1 * $num2
            Write-Host "$num1 $operacao $num2 = $equa" -ForegroundColor Green
        }
        else
        {
            if($operacao -eq '/')
            {
                if($num2 -eq 0)
                {
                    Write-Host "Imposs�vel dividir por zero" -ForegroundColor Red
                }
                else
                {
                    $equa = $num1 / $num2
                    Write-Host "$num1 $operacao $num2 = $equa" -ForegroundColor Green
                }
            }
            else
            {
                Write-Host "Sintaxe Incorreta" -ForegroundColor Red
            }
        }
    }
}
Write-Host ""