[int]$num1 = [int]$args[0]
[int]$num2 = [int]$args[1]

Write-Host ""
Write-Host "Exercício 04" -ForegroundColor Cyan
Write-Host ""

Write-Host "Pesquisar em um intervalo fechado de números inteiros [MIN ... MAX], ou seja, delimitado pelos valores inteiros MIN e MAX recebidos obrigatoriamente através parâmetros na linha de comando, e imprimir os números que são simultaneamente ímpar, múltiplo de 7 e não múltiplo de 5.
Exemplo (com: MIN = 2 e MAX = 10):
ENTRADA: ./intervalo.ps1 2 10 ou ./ intervalo.sh 2 10
SAÍDA: 7" -ForegroundColor Yellow
Write-Host ""
Write-Host "Integrantes: Gabriella Dantas de Abreu Fandim, João Gustavo Medeiros Pontes" -ForegroundColor Magenta
Write-Host ""

Write-Host "Saída: " -ForegroundColor Green -NoNewline
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