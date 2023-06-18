[int]$num1 = [int]$args[0]
[int]$num2 = [int]$args[1]

Write-Host ""
Write-Host "Exerc�cio 04" -ForegroundColor Cyan
Write-Host ""

Write-Host "Pesquisar em um intervalo fechado de n�meros inteiros [MIN ... MAX], ou seja, delimitado pelos valores inteiros MIN e MAX recebidos obrigatoriamente atrav�s par�metros na linha de comando, e imprimir os n�meros que s�o simultaneamente �mpar, m�ltiplo de 7 e n�o m�ltiplo de 5.
Exemplo (com: MIN = 2 e MAX = 10):
ENTRADA: ./intervalo.ps1 2 10 ou ./ intervalo.sh 2 10
SA�DA: 7" -ForegroundColor Yellow
Write-Host ""
Write-Host "Integrantes: Gabriella Dantas de Abreu Fandim, Jo�o Gustavo Medeiros Pontes" -ForegroundColor Magenta
Write-Host ""

Write-Host "Sa�da: " -ForegroundColor Green -NoNewline
while($num2 -gt $num1)
{
    if ($num2 % 2 -ne 0)
    {
        if ($num2 % 5 -ne 0)
        {
            if($num2 % 7 -eq 0)
            {
                Write-Host "$num2 " -NoNewline
            }
        }
    }
    $num2--;
}
Write-Host ""
Write-Host ""